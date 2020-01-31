using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteRequest
{
    interface IRequest
    {
        string request(string path);
    }
}
