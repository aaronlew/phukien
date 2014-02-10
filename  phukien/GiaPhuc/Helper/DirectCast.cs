using System;
using System.Collections.Generic;

namespace MichaelKappel.Net.CSharp
{
    public static partial class Helper
    {

        /// <summary>
        /// DirectCast for C#
        /// Unbox Object to Specific Type
        /// </summary>
        /// <returns>Explicit Type</returns>
        public static T DirectCast<T>(Object Arg)
        {
            return (T)Arg;
        }
    }
}