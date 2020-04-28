using Newtonsoft.Json;
using System;

namespace Theframework
{
    namespace Components
    {
        static class Log
        {
            public static void console<T>(this T x)
            {
                string json = JsonConvert.SerializeObject(x, Formatting.Indented);
                Console.WriteLine(json);
            }

        }//class Log

    }//Components

}//Theframework
