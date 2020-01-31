using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebsiteRequest
{
    class FileRequest : IRequest
    {
        public string request(string path)
        {
            return ReadFile(path);
        }

        public string ReadFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }

    }
}
