using System.Security.Policy;

namespace Managarr.Server.Types
{
    public class RequestService
    {
        public RequestServiceType requestServiceType { get; set; }
        public bool searchRequests { get; set; }
        public Uri url { get; set; }
        public string apiKey { get; set; }
        public bool approvedOnly { get; set; }
        public bool is4k { get; set; }

        public RequestService() { }

        public RequestService(RequestServiceType requestServiceType, bool searchRequests, Uri url, string apiKey, bool approvedOnly, bool is4k)
        {
            this.requestServiceType = requestServiceType;
            this.searchRequests = searchRequests;
            this.url = url;
            this.apiKey = apiKey;
            this.approvedOnly = approvedOnly;
            this.is4k = is4k;
        }
    }
}