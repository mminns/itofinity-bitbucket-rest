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
    public interface IDeployApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns all deploy-keys belonging to a repository.  Example: &#x60;&#x60;&#x60; $ curl -H \&quot;Authorization &lt;auth header&gt;\&quot; \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys  Output: {     \&quot;comment\&quot;: \&quot;mleu@C02W454JHTD8\&quot;,     \&quot;last_used\&quot;: null,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys\&quot;         }     },     \&quot;repository\&quot;: \&quot;test\&quot;,     \&quot;label\&quot;: \&quot;mykey\&quot;,     \&quot;created_on\&quot;: \&quot;2018-08-15T23:50:59.993890+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\&quot;,     \&quot;pk\&quot;: 1,     \&quot;type\&quot;: \&quot;deploy_key\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username.</param>
        /// <param name="repo_slug">The name of the repository the deploy key belongs to.</param>
        /// <returns>Task of DeployKey</returns>
        [Get("/repositories/{username}/{repo_slug}/deploy-keys")]
        System.Threading.Tasks.Task<DeployKey> RepositoriesUsernameRepoSlugDeployKeysGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This deletes a deploy key from a repository.  Example: &#x60;&#x60;&#x60; $ curl -XDELETE \\ -H \&quot;Authorization &lt;auth header&gt;\&quot; \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/1234 &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username.</param>
        /// <param name="repo_slug">The name of the repository the deploy key belongs to.</param>
        /// <param name="key_id">The key ID matching the deploy key.</param>
        /// <returns>Task of void</returns>
        [Delete("/repositories/{username}/{repo_slug}/deploy-keys/{key_id}")]
        System.Threading.Tasks.Task RepositoriesUsernameRepoSlugDeployKeysKeyIdDelete([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("key_id")]string key_id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns the deploy key belonging to a specific key.  Example: &#x60;&#x60;&#x60; $ curl -H \&quot;Authorization &lt;auth header&gt;\&quot; \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-key/1234  Output: {     \&quot;comment\&quot;: \&quot;mleu@C02W454JHTD8\&quot;,     \&quot;last_used\&quot;: null,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-key/1234\&quot;         }     },     \&quot;repository\&quot;: \&quot;test\&quot;,     \&quot;label\&quot;: \&quot;mykey\&quot;,     \&quot;created_on\&quot;: \&quot;2018-08-15T23:50:59.993890+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\&quot;,     \&quot;pk\&quot;: 1234,     \&quot;type\&quot;: \&quot;deploy_key\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username.</param>
        /// <param name="repo_slug">The name of the repository the deploy key belongs to.</param>
        /// <param name="key_id">The key ID matching the deploy key.</param>
        /// <returns>Task of DeployKey</returns>
        [Get("/repositories/{username}/{repo_slug}/deploy-keys/{key_id}")]
        System.Threading.Tasks.Task<DeployKey> RepositoriesUsernameRepoSlugDeployKeysKeyIdGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("key_id")]string key_id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new deploy key in a repository.  The same key needs to be passed in but the comment and label can change.  Example: &#x60;&#x60;&#x60; $ curl -XPUT \\ -H \&quot;Authorization &lt;auth header&gt;\&quot; \\ -H \&quot;Content-type: application/json\&quot; \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/1234 -d \\ &#39;{     \&quot;label\&quot;: \&quot;newlabel\&quot;,     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5 newcomment\&quot;, }&#39;  Output: {     \&quot;comment\&quot;: \&quot;newcomment\&quot;,     \&quot;last_used\&quot;: null,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: \&quot;http://localhost:8000/!api/2.0/repositories/mleu/test/deploy-keys/1234\&quot;         }     },     \&quot;repository\&quot;: \&quot;test\&quot;,     \&quot;label\&quot;: \&quot;newlabel\&quot;,     \&quot;created_on\&quot;: \&quot;2018-08-15T23:50:59.993890+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\&quot;,     \&quot;pk\&quot;: 1234,     \&quot;type\&quot;: \&quot;deploy_key\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username.</param>
        /// <param name="repo_slug">The name of the repository the deploy key belongs to.</param>
        /// <param name="key_id">The key ID matching the deploy key.</param>
        /// <returns>Task of DeployKey</returns>
        [Put("/repositories/{username}/{repo_slug}/deploy-keys/{key_id}")]
        System.Threading.Tasks.Task<DeployKey> RepositoriesUsernameRepoSlugDeployKeysKeyIdPut([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("key_id")]string key_id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create a new deploy key in a repository.  Example: &#x60;&#x60;&#x60; $ curl -XPOST \\ -H \&quot;Authorization &lt;auth header&gt;\&quot; \\ -H \&quot;Content-type: application/json\&quot; \\ https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys -d \\ &#39;{     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5 mleu@C02W454JHTD8\&quot;,     \&quot;label\&quot;: \&quot;mydeploykey\&quot; }&#39;  Output: {     \&quot;pk\&quot;: 123,     \&quot;key\&quot;: \&quot;ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDAK/b1cHHDr/TEV1JGQl+WjCwStKG6Bhrv0rFpEsYlyTBm1fzN0VOJJYn4ZOPCPJwqse6fGbXntEs+BbXiptR+++HycVgl65TMR0b5ul5AgwrVdZdT7qjCOCgaSV74/9xlHDK8oqgGnfA7ZoBBU+qpVyaloSjBdJfLtPY/xqj4yHnXKYzrtn/uFc4Kp9Tb7PUg9Io3qohSTGJGVHnsVblq/rToJG7L5xIo0OxK0SJSQ5vuId93ZuFZrCNMXj8JDHZeSEtjJzpRCBEXHxpOPhAcbm4MzULgkFHhAVgp4JbkrT99/wpvZ7r9AdkTg7HGqL3rlaDrEcWfL7Lu6TnhBdq5\&quot;,     \&quot;label\&quot;: \&quot;mydeploykey\&quot;,     \&quot;type\&quot;: \&quot;deploy_key\&quot;,     \&quot;created_on\&quot;: \&quot;2018-08-15T23:50:59.993890+00:00\&quot;,     \&quot;repository\&quot;: \&quot;test\&quot;,     \&quot;links\&quot;:{         \&quot;self\&quot;:{             \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/repositories/mleu/test/deploy-keys/123\&quot;         }     }     \&quot;last_used\&quot;: null,     \&quot;comment\&quot;: \&quot;mleu@C02W454JHTD8\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username.</param>
        /// <param name="repo_slug">The name of the repository the deploy key belongs to.</param>
        /// <returns>Task of DeployKey</returns>
        [Post("/repositories/{username}/{repo_slug}/deploy-keys")]
        System.Threading.Tasks.Task<DeployKey> RepositoriesUsernameRepoSlugDeployKeysPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug);
        #endregion Asynchronous Operations
    }
}
