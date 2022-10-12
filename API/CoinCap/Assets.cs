using CryptoAPI.Core;
using CryptoAPI.MVVM.Models.Enum;

namespace CryptoAPI.API.CoinCap
{
    public class Assets
    {  
        private string assets = "api.coincap.io/v2/assets";

        private Execute execute = new Execute();
        private string Response { get; set; }
        private string _url;

        // GET/assets
        public string GetAssets()
        {
            return Response = execute.ExequteRequest(assets, RequestTypes.GET.ToString());
        }

        // GET/assets/{{id}}
        public string GetAssetsById(string id)
        {
            if (id != null)
            {
                _url = assets + "/" + id;
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());
        }

        // GET/assets/{{id}}/history
        public string GetHistory(string id)
        {
            if (id != null)
            {
                _url = assets + "/" + id + "/history";
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());
        }

        //GET/assets/{{id}}/markets
        public string GetMarkets(string id)
        {
            if (id != null)
            {
                _url = assets + "/" + id + "/history";
            }
            return Response = execute.ExequteRequest(_url, RequestTypes.GET.ToString());
        }
    }
}
