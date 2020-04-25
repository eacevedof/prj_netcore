namespace Theframework
{
    namespace Components
    {
        public sealed class Utils
        {
            public Utils()
            {

            }

            public string get_domain()
            {
                return System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            }

        }//class Utils

    }//Components

}//Theframework
