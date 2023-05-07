using Crypto_Marketplace.Models;
using System.Collections.Generic;
using System.Data.Common;

namespace Crypto_Marketplace.Api
{
    public interface IGetData
    {
        public List<Data> GetData(string filter);
        public  Task<string> Convert(string currency,string val);
    }
}
