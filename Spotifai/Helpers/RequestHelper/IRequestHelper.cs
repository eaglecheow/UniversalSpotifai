using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifai.Helpers.RequestHelper
{
    interface IRequestHelper
    {
        /// <summary>
        /// Sends a GET request to a URL
        /// </summary>
        /// <param name="url">Request URL</param>
        /// <returns>Response body in string form</returns>
        string RequestGet(string url);

        /// <summary>
        /// Sends a POST request to a URL
        /// </summary>
        /// <typeparam name="T">Post object type</typeparam>
        /// <param name="postObject">Object as request body</param>
        /// <param name="url">Request URL</param>
        /// <returns>Response body in string form</returns>
        string RequestPost<T>(T postObject, string url);

        /// <summary>
        /// Sends an UPDATE request to a URL
        /// </summary>
        /// <typeparam name="T">Update object type</typeparam>
        /// <param name="updateObject">Object as request body</param>
        /// <param name="url">Request URL</param>
        /// <returns>Response body in string form</returns>
        string RequestUpdate<T>(T updateObject, string url);

        /// <summary>
        /// Sends a DELETE request to a URL
        /// </summary>
        /// <param name="url">Request URL</param>
        /// <returns>Response body in string form</returns>
        string RequestDelete(string url);
    }
}
