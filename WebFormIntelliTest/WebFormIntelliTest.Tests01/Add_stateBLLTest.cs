// <copyright file="Add_stateBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Add_stateBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_stateBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Add_stateBLL target, Add_stateBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_stateBLLTest.insert(Add_stateBLL, Add_stateBLL)
        }
    }
}
