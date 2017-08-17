using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

// Alternat code using MVC to get API
namespace testApp.Models
{
    public class Transit
    {
        public Object getMetroTransitInfo()
        {
            string url = "http://svc.metrotransit.org/NexTrip/Routes";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var json = new JavaScriptSerializer().Serialize(content); // unsuccesful attempt to parse object array data
            return json;

        }
    }
}