// <copyright file="Doner_regBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Doner_regBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Doner_regBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Doner_regBLL target, Doner_regBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Doner_regBLLTest.insert(Doner_regBLL, Doner_regBLL)
        }
    }
}
