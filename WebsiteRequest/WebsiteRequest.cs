using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteRequest
{
    class WebsiteRequest : IRequest
    {
        public string request(string path)
        {
            return RequestWebsite(path);
        }

        public string RequestWebsite(string path)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(path);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                response.Close();
                return responseFromServer;
            }
        }
    }
}
