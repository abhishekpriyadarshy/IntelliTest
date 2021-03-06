// <copyright file="OrganizationDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(OrganizationDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrganizationDLLTest
    {

        [PexMethod]
        public void Update([PexAssumeUnderTest] OrganizationDLL target, OrganizationBLL objectBLL)
        {
            target.Update(objectBLL);
            // TODO: add assertions to method OrganizationDLLTest.Update(OrganizationDLL, OrganizationBLL)
        }

        [PexMethod]
        public void Delete([PexAssumeUnderTest] OrganizationDLL target, OrganizationBLL objectBLL)
        {
            target.Delete(objectBLL);
            // TODO: add assertions to method OrganizationDLLTest.Delete(OrganizationDLL, OrganizationBLL)
        }
    }
}
