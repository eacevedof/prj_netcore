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
                url = "http://localhost:3000/apify/contexts/";
                url = "http://xxx.theframework.es/apify/read";
                url = "http://xxx.theframework.es/apify/contexts/c2";
            }// __construct

            public string get_response()
            {
                var client = new RestClient(this.url);
                //var request = new RestRequest(Method.POST);
                var request = new RestRequest(Method.GET);
                //request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("cache-control", "no-cache");
                //request.AddHeader("header1", "headerval");
                //request.AddParameter("application/x-www-form-urlencoded", "bodykey=bodyval", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                //Log.file(response,"response");
                
                return response.Content;
            }

        }//class Curl

    }//Components

}//Theframework
