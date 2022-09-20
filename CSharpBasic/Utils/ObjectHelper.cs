using System;
using Newtonsoft.Json;

namespace CSharpBasic.Utils
{
    public static class ObjectHelper
    {
        public static void Dump<T>(this T x)
        {
            string json = JsonConvert.SerializeObject(x, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}