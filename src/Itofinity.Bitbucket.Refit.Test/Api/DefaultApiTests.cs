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
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Bitbucket.Refit.Test.DefaultApiTests";

        private IDefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<IDefaultApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test RepositoriesUsernameRepoSlugDiffstatSpecGet
        /// </summary>
        [Test]
        public async void RepositoriesUsernameRepoSlugDiffstatSpecGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string repo_slug = null;
            //string spec = null;
            //bool? ignore_whitespace = null;
            //var response = await instance.RepositoriesUsernameRepoSlugDiffstatSpecGet(userAgent, username, repo_slug, spec, ignore_whitespace);
            //Assert.IsInstanceOf<PaginatedDiffstats> (response, "response is PaginatedDiffstats");
        }
        
        /// <summary>
        /// Test TeamsUsernamePermissionsGet
        /// </summary>
        [Test]
        public async void TeamsUsernamePermissionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string q = null;
            //string sort = null;
            //var response = await instance.TeamsUsernamePermissionsGet(userAgent, username, q, sort);
            //Assert.IsInstanceOf<PaginatedTeamPermissions> (response, "response is PaginatedTeamPermissions");
        }
        
        /// <summary>
        /// Test TeamsUsernamePermissionsRepositoriesGet
        /// </summary>
        [Test]
        public async void TeamsUsernamePermissionsRepositoriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string q = null;
            //string sort = null;
            //var response = await instance.TeamsUsernamePermissionsRepositoriesGet(userAgent, username, q, sort);
            //Assert.IsInstanceOf<PaginatedRepositoryPermissions> (response, "response is PaginatedRepositoryPermissions");
        }
        
        /// <summary>
        /// Test UserPermissionsTeamsGet
        /// </summary>
        [Test]
        public async void UserPermissionsTeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //string sort = null;
            //var response = await instance.UserPermissionsTeamsGet(userAgent, q, sort);
            //Assert.IsInstanceOf<PaginatedTeamPermissions> (response, "response is PaginatedTeamPermissions");
        }
        
    }

}
