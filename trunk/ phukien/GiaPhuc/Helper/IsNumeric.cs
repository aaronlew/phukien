using System;

namespace MichaelKappel.Net.CSharp
{
    public static partial class Helper
    {
  	/// <summary>
        /// Determines if an object type is numeric
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static Boolean IsNumeric(Type type)
        {
            if (!type.IsEnum)
            {
                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Char:
                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                        return true;
                }
            }
            return false;
        }
    }
}