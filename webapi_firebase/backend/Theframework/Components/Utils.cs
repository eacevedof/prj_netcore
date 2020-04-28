namespace Theframework
{
    namespace Components
    {
        public static class Utils
        {

            public static string get_domain()
            {
                return System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            }

        }//class Utils

    }//Components

}//Theframework
