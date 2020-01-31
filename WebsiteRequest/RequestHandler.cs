using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteRequest
{
    class RequestHandler
    {
        string Path;
        IRequest Request;
        public RequestHandler(IRequest request)
        {
            Request = request;
        }

        public string ReturnRequst(string path)
        {
            Path = path;
            return Path;
        }
    }
}
