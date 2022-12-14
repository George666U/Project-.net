using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using HotelService.Controllers;
using HotelService.Dtos;
using HotelService.Models;
using HotelServise.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelServiceTests.Controller
{
    public class HotelsControllerTests
    {
        private HotelsController _HotelsController;
        private IHotelRepo _repository;
        private IMapper _mapper;
        public HotelsControllerTests()
        {
            //dependencies
            _repository = A.Fake<IHotelRepo>();
            _mapper = A.Fake<IMapper>();

            //SUT
            _HotelsController = new HotelsController(_repository, _mapper);
        }
        [Fact]
        public void HotelsController_GetHotels_ReturnsSuccess()
        {
            //Arrange
            var hotelItem = A.Fake<IEnumerable<Hotel>>();
            A.CallTo(() => _repository.GetAllHotels()).Returns(hotelItem);
            //Act
            var result = _HotelsController.GetHotels();
            //Assert
            result.Should().BeOfType<ActionResult<IEnumerable<HotelReadDto>>>();
        }
    }
} 
