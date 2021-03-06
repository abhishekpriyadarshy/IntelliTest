// <copyright file="ContactTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;

namespace WebFormIntelliTest.Util.Tests
{
    [TestClass]
    [PexClass(typeof(Contact))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContactTest
    {

        [PexMethod]
        public string PhotoUrlGet([PexAssumeUnderTest] Contact target)
        {
            string result = target.PhotoUrl;
            return result;
            // TODO: add assertions to method ContactTest.PhotoUrlGet(Contact)
        }
    }
}
