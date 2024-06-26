﻿using Booking_API.Models;
using Booking_API.Repository.IRepository;
using Booking_API.Services.IService;

namespace Booking_API.Services
{
    public class CarAgencyServices : Service<CarAgency>, ICarAgencyService
    {
        public CarAgencyServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
