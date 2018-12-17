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
    public interface ICommitstatusesApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the specified build status for a commit.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="node">The commit&#39;s SHA1.</param>
        /// <param name="key">The build status&#39; unique key</param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <returns>Task of Commitstatus</returns>
        [Get("/repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key}")]
        System.Threading.Tasks.Task<Commitstatus> RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("node")]string node, [AliasAs("key")]string key, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to update the current status of a build status object on the specific commit.  This operation can also be used to change other properties of the build status:  * &#x60;state&#x60; * &#x60;name&#x60; * &#x60;description&#x60; * &#x60;url&#x60; * &#x60;refname&#x60;  The &#x60;key&#x60; cannot be changed.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="node">The commit&#39;s SHA1.</param>
        /// <param name="key">The build status&#39; unique key</param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="_body">The updated build status object (optional)</param>
        /// <returns>Task of Commitstatus</returns>
        [Put("/repositories/{username}/{repo_slug}/commit/{node}/statuses/build/{key}")]
        System.Threading.Tasks.Task<Commitstatus> RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("node")]string node, [AliasAs("key")]string key, [AliasAs("repo_slug")]string repo_slug, [Body]Commitstatus _body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new build status against the specified commit.  If the specified key already exists, the existing status object will be overwritten.  When creating a new commit status, you can use a URI template for the URL. Templates are URLs that contain variable names that Bitbucket will evaluate at runtime whenever the URL is displayed anywhere similar to parameter substitution in [Bitbucket Connect](https://developer.atlassian.com/bitbucket/concepts/context-parameters.html). For example, one could use &#x60;https://foo.com/builds/{repository.full_name}&#x60; which Bitbucket will turn into &#x60;https://foo.com/builds/foo/bar&#x60; at render time. The context variables available are &#x60;repository&#x60; and &#x60;commit&#x60;.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="node">The commit&#39;s SHA1.</param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="_body">The new commit status object. (optional)</param>
        /// <returns>Task of Commitstatus</returns>
        [Post("/repositories/{username}/{repo_slug}/commit/{node}/statuses/build")]
        System.Threading.Tasks.Task<Commitstatus> RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("node")]string node, [AliasAs("repo_slug")]string repo_slug, [Body]Commitstatus _body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all statuses (e.g. build results) for a specific commit.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="node">The commit&#39;s SHA1.</param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <returns>Task of PaginatedCommitstatuses</returns>
        [Get("/repositories/{username}/{repo_slug}/commit/{node}/statuses")]
        System.Threading.Tasks.Task<PaginatedCommitstatuses> RepositoriesUsernameRepoSlugCommitNodeStatusesGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("node")]string node, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all statuses (e.g. build results) for the given pull request.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="pull_request_id">The id of the pull request.</param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <returns>Task of PaginatedCommitstatuses</returns>
        [Get("/repositories/{username}/{repo_slug}/pullrequests/{pull_request_id}/statuses")]
        System.Threading.Tasks.Task<PaginatedCommitstatuses> RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("pull_request_id")]int? pull_request_id, [AliasAs("repo_slug")]string repo_slug);
        #endregion Asynchronous Operations
    }
}
