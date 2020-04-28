using RestSharp;
using RestSharp.Authenticators;

namespace Theframework
{
    namespace Components
    {
        public sealed class Curl
        {
            private string url;

            public Curl()
            {
                this.url = "http://localhost:3000/apify/contexts/";


            }// __construct

            private IRestResponse get_response()
            {
                var client = new RestClient(this.url);
                //var request = new RestRequest(Method.POST);
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("header1", "headerval");
                request.AddParameter("application/x-www-form-urlencoded", "bodykey=bodyval", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                return response;
            }

        }//class Curl

    }//Components

}//Theframework
