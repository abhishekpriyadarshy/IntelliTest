// <copyright file="Add_donation_detailsDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Add_donation_detailsDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_donation_detailsDLLTest
    {

        [PexMethod(MaxBranches = 20000)]
        public void insert([PexAssumeUnderTest] Add_donation_detailsDLL target, Add_donation_detailsBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_donation_detailsDLLTest.insert(Add_donation_detailsDLL, Add_donation_detailsBLL)
        }
    }
}
