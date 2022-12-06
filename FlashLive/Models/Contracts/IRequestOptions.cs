using System;

namespace FlashLive.Models.Contracts
{
    public interface IRequestOptions
    {
        public void AddUrlParameters(ref UriBuilder uriBuilder);
    }
}
