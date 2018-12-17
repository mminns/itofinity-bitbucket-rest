/* 
 * Bitbucket API
 *
 * Code against the Bitbucket API to automate simple tasks, embed Bitbucket data into your own site, build mobile or desktop apps, or even add custom UI add-ons into Bitbucket itself using the Connect framework.
 *
 * OpenAPI spec version: 2.0
 * Contact: support@bitbucket.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Itofinity.Bitbucket.Refit.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISnippetApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Convenience resource for getting to a snippet&#39;s raw files without the need for first having to retrieve the snippet itself and having to pull out the versioned file links.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="path"></param>
        /// <param name="encoded_id"></param>
        /// <returns>Task of void</returns>
        [Get("/snippets/{username}/{encoded_id}/files/{path}")]
        System.Threading.Tasks.Task SnippetsUsernameEncodedIdFilesPathGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("path")]string path, [AliasAs("encoded_id")]string encoded_id);
        #endregion Asynchronous Operations
    }
}