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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Refit;

using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Api;
using Itofinity.Bitbucket.Refit.Model;

namespace Itofinity.Bitbucket.Refit.Test
{
    /// <summary>
    ///  Class for testing CommitstatusesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CommitstatusesApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Bitbucket.Refit.Test.CommitstatusesApiTests";

        private ICommitstatusesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<ICommitstatusesApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommitstatusesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CommitstatusesApi
            //Assert.IsInstanceOfType(typeof(CommitstatusesApi), instance, "instance is a CommitstatusesApi");
        }

        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string node = null;
            //string key = null;
            //string repo_slug = null;
            //var response = await instance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyGet(userAgent, username, node, key, repo_slug);
            //Assert.IsInstanceOf<Commitstatus> (response, "response is Commitstatus");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string node = null;
            //string key = null;
            //string repo_slug = null;
            //Commitstatus _body = null;
            //var response = await instance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildKeyPut(userAgent, username, node, key, repo_slug, _body);
            //Assert.IsInstanceOf<Commitstatus> (response, "response is Commitstatus");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string node = null;
            //string repo_slug = null;
            //Commitstatus _body = null;
            //var response = await instance.RepositoriesUsernameRepoSlugCommitNodeStatusesBuildPost(userAgent, username, node, repo_slug, _body);
            //Assert.IsInstanceOf<Commitstatus> (response, "response is Commitstatus");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugCommitNodeStatusesGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugCommitNodeStatusesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string node = null;
            //string repo_slug = null;
            //var response = await instance.RepositoriesUsernameRepoSlugCommitNodeStatusesGet(userAgent, username, node, repo_slug);
            //Assert.IsInstanceOf<PaginatedCommitstatuses> (response, "response is PaginatedCommitstatuses");
        }
        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? pull_request_id = null;
            //string repo_slug = null;
            //var response = await instance.RepositoriesUsernameRepoSlugPullrequestsPullRequestIdStatusesGet(userAgent, username, pull_request_id, repo_slug);
            //Assert.IsInstanceOf<PaginatedCommitstatuses> (response, "response is PaginatedCommitstatuses");
        }
        
    }

}