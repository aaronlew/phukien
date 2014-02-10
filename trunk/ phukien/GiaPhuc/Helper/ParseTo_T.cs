using System;
using System.Collections.Generic;

namespace MichaelKappel.Net.CSharp
{
    public static partial class Helper
    {
        /// <summary>
        /// Implied Types Generic Type Converter
        /// </summary>
        /// <returns>Converted Type</returns>
        public static T ParseTo<T>(Object Arg)
        {
            return ParseTo<T>(Arg, default(T));
        }
        /// <summary>
        /// Implied Types Generic Type Converter
        /// </summary>
        /// <returns>Converted Type</returns>
        public static T ParseTo<T>(Object Arg, T defaultValue)
        {
            if (Arg == null && defaultValue == null)
            {
                if (IsNumeric(typeof(T)))
                    return (T)Convert.ChangeType(0, typeof(T));
                else if (typeof(T) == typeof(String))
                    return (T)Convert.ChangeType("", typeof(T));
                else if (typeof(T) == typeof(DateTime))
                    return (T)Convert.ChangeType(default(DateTime), typeof(DateTime));
                else
                    return default(T);
            }
            else if (Arg == null)
            {
                return ParseTo<T>(defaultValue);
            }
            else
            {
                try
                {
                    if (defaultValue == null)
                        defaultValue = (T)default(T);

                    Int32 numericResult = 0;
                    if (typeof(T) == typeof(String))
                        return (T)Convert.ChangeType(Arg.ToString().Trim(), typeof(T));
                    else if (typeof(T).IsEnum && Arg is Char)
                        return (T)Enum.Parse(typeof(T), Enum.GetName(typeof(T), (Int32)(Arg as Char?).Value));
                    else if (typeof(T).IsEnum && Arg is Int32)
                        return (T)Enum.Parse(typeof(T), Enum.GetName(typeof(T), (Int32)Arg));
                    else if (typeof(T).IsEnum && Int32.TryParse(Arg.ToString(), out numericResult))
                        return (T)Enum.Parse(typeof(T), Enum.GetName(typeof(T), numericResult));
                    else if (typeof(T).IsEnum)
                        return (T)Enum.Parse(typeof(T), Arg.ToString());
                    else if (Arg.ToString() == "")
                        return defaultValue;
                    else if (typeof(T) == typeof(Boolean))
                        if (Arg is Boolean)
                            return (T)Arg;
                        else
                            return DirectCast<T>(Arg.ToString().Trim().ToUpper().Substring(0, 1).Replace("Y", "T") == "T");
                    else if (typeof(T) == typeof(Guid) && Arg.ToString().Trim() != "")
                        return DirectCast<T>(new Guid(Arg.ToString()));
                    else
                        return (T)Convert.ChangeType(Arg, typeof(T));
                }
                catch
                {
                    return defaultValue;
                }
            }
        }
    }
}