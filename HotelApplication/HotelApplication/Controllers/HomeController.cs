using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelApplication.Models;
using Microsoft.AspNetCore.Authorization;
using HotelApplication.Entities;
using HotelApplication.Repositories;
using HotelApplication.Data;

namespace HotelApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReservationRepository _reservationRepository;
        private readonly PaymentRepository _paymentRepository;

        public HomeController(ReservationRepository reservationRepository, PaymentRepository paymentRepository)
        {
            _reservationRepository = reservationRepository;
            _paymentRepository = paymentRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {         
            var reservations = _reservationRepository.GetReservations();
            var homeViewModel = new HomeViewModel();
            homeViewModel.Reservations = reservations;
            return View(homeViewModel);
        } 

        [HttpGet]
        [Authorize]
        public IActionResult Details(string id)
        {
            var payment = _paymentRepository.GetPayment(id);
            var detailsViewModel = new DetailsViewModel();
            detailsViewModel.PaymentId = payment.Id;
            detailsViewModel.Price = payment.Price;
            detailsViewModel.Discount = payment.Relief.Discount;
            detailsViewModel.Customer = payment.Customer.FirstName + " " + payment.Customer.LastName + ", " + payment.Customer.Address;
            return View(detailsViewModel);
        }

    }
}
