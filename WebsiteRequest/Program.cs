using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebsiteRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequest requestweb = new WebsiteRequest();
            IRequest requestfile = new FileRequest();
            RequestHandler handler = new RequestHandler(requestfile);
            string temp = Console.ReadLine();
            Console.WriteLine(requestweb.request(handler.ReturnRequst(temp)));
            Console.ReadKey();

        }
    }
}
