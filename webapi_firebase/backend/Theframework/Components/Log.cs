using Newtonsoft.Json;
using System;
using System.IO;

namespace Theframework
{
    namespace Components
    {
        static class Log
        {
            public static void console<T>(this T mxvar, string title="")
            {
                string strjson = get_string(mxvar);
                strjson = "\n[" + get_timenow() + "]\n" + title + "\n" + strjson;
                Console.WriteLine(strjson);
            }

            public static void file<T>(this T mxvar, string title="")
            {
                string paththis = Directory.GetCurrentDirectory();
                paththis += "/logs/debug/sys_"+ get_today() + ".log";
                string strjson = get_string(mxvar);
                
                strjson = "\n["+get_timenow()+"]\n" + title + "\n" + strjson;
                var pathfix = @paththis;
                Files.write(strjson,pathfix);
            }            

            private static string get_string<T>(this T mxvar)
            {
                string strjson = JsonConvert.SerializeObject(mxvar, Formatting.Indented);
                return strjson;
            }

            private static string get_today()
            {
                string today = DateTime.Now.ToString("yyyyMMdd");
                return today;
            }

            private static string get_timenow()
            {
                string now = DateTime.Now.ToString("HH:mm:ss");
                return now;
            } 

        }//class Log

    }//Components

}//Theframework
