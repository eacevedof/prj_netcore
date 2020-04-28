using System;
using System.IO;
using Strm = System.IO.StreamReader;

namespace Theframework
{
    namespace Components
    {
        public static class Files
        {

            public static string get_content(string pathfile)
            {
                Strm objstrm = new Strm(pathfile);
                string strcontent = objstrm.ReadToEnd();
                objstrm.Close();
                return strcontent;
            }

            public static void write(string content, string pathfile)
            {
                var pathfile1 = @pathfile;
                if(!File.Exists(pathfile1))
                {
                    var objfile = File.Create(pathfile1);
                    objfile.Close();
                }
                File.WriteAllText(pathfile1, content);
            }

        }//class Files

    }//Components

}//Theframework
