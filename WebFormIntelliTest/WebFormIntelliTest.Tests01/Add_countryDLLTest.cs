// <copyright file="Add_countryDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Add_countryDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_countryDLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Add_countryDLL target, Add_countryBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_countryDLLTest.insert(Add_countryDLL, Add_countryBLL)
        }
    }
}
