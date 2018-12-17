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
    public interface ITeamsApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all the teams that the authenticated user is associated with.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="role"> Filters the teams based on the authenticated user&#39;s role on each team.  * **member**: returns a list of all the teams which the caller is a member of   at least one team group or repository owned by the team * **contributor**: returns a list of teams which the caller has write access   to at least one repository owned by the team * **admin**: returns a list teams which the caller has team administrator access  (optional)</param>
        /// <returns>Task of PaginatedTeams</returns>
        [Get("/teams")]
        System.Threading.Tasks.Task<PaginatedTeams> TeamsGet([Header("UserAgent")] string userAgent, [AliasAs("role")]string role = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the list of accounts that are following this team.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The team&#39;s username</param>
        /// <returns>Task of PaginatedUsers</returns>
        [Get("/teams/{username}/followers")]
        System.Threading.Tasks.Task<PaginatedUsers> TeamsUsernameFollowersGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the list of accounts this team is following.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The team&#39;s username</param>
        /// <returns>Task of PaginatedUsers</returns>
        [Get("/teams/{username}/following")]
        System.Threading.Tasks.Task<PaginatedUsers> TeamsUsernameFollowingGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets the public information associated with a team.  If the team&#39;s profile is private, &#x60;location&#x60;, &#x60;website&#x60; and &#x60;created_on&#x60; elements are omitted.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The team&#39;s username or UUID.</param>
        /// <returns>Task of Team</returns>
        [Get("/teams/{username}")]
        System.Threading.Tasks.Task<Team> TeamsUsernameGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of webhooks installed on this team.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of PaginatedWebhookSubscriptions</returns>
        [Get("/teams/{username}/hooks")]
        System.Threading.Tasks.Task<PaginatedWebhookSubscriptions> TeamsUsernameHooksGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new webhook on the specified team.  Team webhooks are fired for events from all repositories belonging to that team account.  Note that only admins can install webhooks on teams.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of WebhookSubscription</returns>
        [Post("/teams/{username}/hooks")]
        System.Threading.Tasks.Task<WebhookSubscription> TeamsUsernameHooksPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes the specified webhook subscription from the given team account.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="uid">The installed webhook&#39;s id</param>
        /// <returns>Task of void</returns>
        [Delete("/teams/{username}/hooks/{uid}")]
        System.Threading.Tasks.Task TeamsUsernameHooksUidDelete([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("uid")]string uid);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the webhook with the specified id installed on the given team account.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="uid">The installed webhook&#39;s id.</param>
        /// <returns>Task of WebhookSubscription</returns>
        [Get("/teams/{username}/hooks/{uid}")]
        System.Threading.Tasks.Task<WebhookSubscription> TeamsUsernameHooksUidGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("uid")]string uid);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates the specified webhook subscription.  The following properties can be mutated:  * &#x60;description&#x60; * &#x60;url&#x60; * &#x60;active&#x60; * &#x60;events&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="uid">The installed webhook&#39;s id</param>
        /// <returns>Task of WebhookSubscription</returns>
        [Put("/teams/{username}/hooks/{uid}")]
        System.Threading.Tasks.Task<WebhookSubscription> TeamsUsernameHooksUidPut([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("uid")]string uid);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// All members of a team.  Returns all members of the specified team. Any member of any of the team&#39;s groups is considered a member of the team. This includes users in groups that may not actually have access to any of the team&#39;s repositories.  Note that members using the \&quot;private profile\&quot; feature are not included.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of User</returns>
        [Get("/teams/{username}/members")]
        System.Threading.Tasks.Task<User> TeamsUsernameMembersGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// All repositories owned by a user/team. This includes private repositories, but filtered down to the ones that the calling user has access to.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of Error</returns>
        [Get("/teams/{username}/repositories")]
        System.Threading.Tasks.Task<Error> TeamsUsernameRepositoriesGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// All members of a team.  Returns all members of the specified team. Any member of any of the team&#39;s groups is considered a member of the team. This includes users in groups that may not actually have access to any of the team&#39;s repositories.  Note that members using the \&quot;private profile\&quot; feature are not included.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of User</returns>
        [Get("/users/{username}/members")]
        System.Threading.Tasks.Task<User> UsersUsernameMembersGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// All repositories owned by a user/team. This includes private repositories, but filtered down to the ones that the calling user has access to.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <returns>Task of Error</returns>
        [Get("/users/{username}/repositories")]
        System.Threading.Tasks.Task<Error> UsersUsernameRepositoriesGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);
        #endregion Asynchronous Operations
    }
}
