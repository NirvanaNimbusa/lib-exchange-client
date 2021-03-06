/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.com.blockchain.exchange.rest.api;
using Org.OpenAPITools.com.blockchain.exchange.rest.model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing Balance
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BalanceTests
    {
        // TODO uncomment below to declare an instance variable for Balance
        //private Balance instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Balance
            //instance = new Balance();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Balance
        /// </summary>
        [Test]
        public void BalanceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Balance
            //Assert.IsInstanceOf(typeof(Balance), instance);
        }


        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property '_Balance'
        /// </summary>
        [Test]
        public void _BalanceTest()
        {
            // TODO unit test for the property '_Balance'
        }
        /// <summary>
        /// Test the property 'Available'
        /// </summary>
        [Test]
        public void AvailableTest()
        {
            // TODO unit test for the property 'Available'
        }
        /// <summary>
        /// Test the property 'BalanceLocal'
        /// </summary>
        [Test]
        public void BalanceLocalTest()
        {
            // TODO unit test for the property 'BalanceLocal'
        }
        /// <summary>
        /// Test the property 'AvailableLocal'
        /// </summary>
        [Test]
        public void AvailableLocalTest()
        {
            // TODO unit test for the property 'AvailableLocal'
        }
        /// <summary>
        /// Test the property 'Rate'
        /// </summary>
        [Test]
        public void RateTest()
        {
            // TODO unit test for the property 'Rate'
        }

    }

}
