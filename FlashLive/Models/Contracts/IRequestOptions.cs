using System;

namespace FlashLive.Models.Contracts
{
    /// <summary>
    /// Generic implementation of an API request.
    /// </summary>
    public interface IRequestOptions
    {
        /// <summary>
        /// Updates the <see cref="UriBuilder.Query"/> based on the properties contained within the <see cref="IRequestOptions"/>.
        /// </summary>
        /// <param name="uriBuilder">Reference to the <see cref="UriBuilder"/>.</param>
        public void AddUrlParameters(ref UriBuilder uriBuilder);
    }
}
