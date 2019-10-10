using System;
using Xunit;
using Misfit.Manager;
using Misfit.Web.ViewModels;
using Moq;
using Misfit.Web.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Misfit.Test
{
    public class MisfitUnitTest
    {
        private MisfitController controller;
        private Mock<IUserManager> _UserManager;
        private Mock<IMisfitNumberManager> _NumberManager;
        private Mock<IMapper> _Mapper;
        private readonly string FirstNumber = "12345";
        private readonly string SecondNumber = "12345";
        private ResultViewModel MocResultViewModel;
        private Utilities _Utility;

        public MisfitUnitTest()
        {
            _Utility = new Utilities();
            _UserManager = new Mock<IUserManager>();
            _NumberManager = new Mock<IMisfitNumberManager>();
            _Mapper = new Mock<IMapper>();
            controller = new MisfitController(_UserManager.Object, _NumberManager.Object, _Mapper.Object);
            prepareMocModel();
        }

        private void prepareMocModel()
        {
            MocResultViewModel = new ResultViewModel
            {
                Id = 0,
                FirstNumber = FirstNumber,
                SecondNumber = SecondNumber,
                Sum = _Utility.AddNumbers(FirstNumber, SecondNumber),
                DateOfCalculation = DateTime.Now,
                User = new UserViewModel
                {
                    Id = 0,
                    UserName = "KhairulOmi"
                }

            };

        }

        [Fact]
        public void SaveUserResult_SaveSumIntoDb_AndReturnOk()
        {
            var vm = MocResultViewModel;
            Assert.Equal("24690", vm.Sum);
            var okResult = controller.SaveUserResult(vm) as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
            Assert.IsType<ResultViewModel>(okResult.Value);
        }
    }
}
