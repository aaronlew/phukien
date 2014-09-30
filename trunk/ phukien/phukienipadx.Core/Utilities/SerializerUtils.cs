using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

public static class SerializerUtils
{
    #region Serializer Object

    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string SerializeObj<T>(this T obj)
    {
        var serializer = new XmlSerializer(obj.GetType());
        using (var writer = new StringWriter())
        {
            serializer.Serialize(writer, obj);

            return writer.ToString();
        }
    }

    public static void DeserializeObj<T>(this T obj, string xml) where T : class
    {
        var serializer = new XmlSerializer(typeof (T));
        using (var reader = new StringReader(xml))
        {
            var temp = (T) serializer.Deserialize(reader);
            if (null == temp)
                temp = default(T);
            else
            {
                // Copy properties
                temp.CopyTo(obj);
            }
        }
    }

    #endregion

    #region Serializer to Files

    public static void Serialize<T>(this T obj, string filelocation)
    {
        var xmlSerializer = new XmlSerializer(typeof (T));
        using (TextWriter textWriter = new StreamWriter(filelocation))
        {
            xmlSerializer.Serialize(textWriter, obj);
        }
    }

    public static void Deserialize<T>(this T obj, string filelocation)
    {
        try
        {
            var xmlSerializer = new XmlSerializer(typeof (T));
            using (TextReader textReader = new StreamReader(filelocation))
            {
                var temp = (T) xmlSerializer.Deserialize(textReader);
                if (null == temp)
                    temp = default(T);
                else
                {
                    // Copy properties
                    temp.CopyTo(obj);
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Clone and Copy Dynamic Object

    private static bool IsGenericEnumerable(Type T)
    {
        Type[] genArgs = T.GetGenericArguments();
        if (genArgs.Length == 1 &&
            typeof (IEnumerable<>).MakeGenericType(genArgs).IsAssignableFrom(T)
            )
            return true;
        return T.BaseType != null && IsGenericEnumerable(T.BaseType);
    }

    /// Code : http://stackoverflow.com/questions/78536/cloning-objects-in-c-sharp
    /// <summary>
    ///     Perform a deep Clone of the object.
    /// </summary>
    /// <typeparam name="T">The type of object being copied.</typeparam>
    /// <param name="source">The object instance to copy.</param>
    /// <returns>The copied object.</returns>
    public static T Clone<T>(this T source)
    {
        if (!typeof (T).IsSerializable)
        {
            throw new ArgumentException("The type must be serializable.", "source");
        }

        // Don't serialize a null object, simply return the default for that object
        if (ReferenceEquals(source, null))
        {
            return default(T);
        }

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream)
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T) formatter.Deserialize(stream);
        }
    }

    public static T DeepClone<T>(this T obj)
    {
        T objResult;
        using (var ms = new MemoryStream())
        {
            var bf = new BinaryFormatter();
            bf.Serialize(ms, obj);

            ms.Position = 0;
            objResult = (T) bf.Deserialize(ms);
        }
        return objResult;
    }

    /// Code : http://stackoverflow.com/questions/78536/cloning-objects-in-c-sharp
    /// <summary>
    ///     Perform a deep Clone of the object list.
    /// </summary>
    /// <returns>The copied object.</returns>
    public static IEnumerable<T> CloneList<T>(this IEnumerable<T> list)
    {
        return list.Select(item => item.Clone());
    }

    /// Code : http://stackoverflow.com/questions/78536/cloning-objects-in-c-sharp
    /// <summary>
    ///     Copy the source object to the target object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="target"></param>
    public static void CopyTo<T>(this T source, T target)
    {
        // grab the type and create a new instance of that type
        Type sourceType = source.GetType();
        if (null == target) target = Activator.CreateInstance<T>();

        // grab the properties
        PropertyInfo[] pis =
            sourceType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        // iterate over the properties and if it has a 'set' method assign it from the source TO the target
        foreach (PropertyInfo item in pis)
        {
            if (item.CanWrite)
            {
                if (item.PropertyType.IsValueType || item.PropertyType.IsEnum ||
                    item.PropertyType == typeof (string))
                {
                    // value types can simply be 'set'
                    item.SetValue(target, item.GetValue(source, null), null);
                }
                else
                {
                    // object/complex types need to recursively call this method until the end of the tree is reached
                    object propertyValue = item.GetValue(source, null);
                    if (propertyValue == null)
                    {
                        item.SetValue(target, null, null);
                    }
                    else
                    {
                        T temp = default(T);
                        CopyTo(source, temp);
                        item.SetValue(target, temp, null);

                        //PermissionTypes per = (PermissionTypes)9;
                        //bool canRead = per.Has(PermissionTypes.Read);
                    }
                }
            }
        }
    }

    #endregion
}