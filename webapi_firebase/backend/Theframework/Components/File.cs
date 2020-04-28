using System;
using System.IO;


namespace Theframework
{
    namespace Components
    {
        public static class Files
        {

            public static string get_content(string pathfile)
            {
                StreamReader objstrm = new StreamReader(pathfile);
                string strcontent = objstrm.ReadToEnd();
                objstrm.Close();
                return strcontent;
            }

            public static void write(string content, string pathfile)
            {
                var pathfix = @pathfile;
                if(!File.Exists(pathfix))
                {
                    var objfile = File.Create(pathfix);
                    objfile.Close();
                    write_new(content,pathfile);
                }
                else
                {
                    write_append(content,pathfile);
                }
            }

            private static void write_new(string content, string pathfile)
            {
                var pathfix = @pathfile;
                using (StreamWriter sw = File.CreateText(pathfix)) 
                {
                    sw.WriteLine(content);
                }                
            }

            private static void write_append(string content, string pathfile)
            {
                var pathfix = @pathfile;
                using (StreamWriter sw = File.AppendText(pathfix)) 
                {
                    sw.WriteLine(content);
                }                
            }

        }//class Files

    }//Components

}//Theframework
