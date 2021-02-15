using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if(CheckReturnDate(rental.CarId).Success)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult(CheckReturnDate(rental.CarId).Message);
        }

        public IResult CheckReturnDate(int carId)
        {
            var rentList = _rentalDal.GetRentalDetails(r => r.CarId == carId && r.ReturnDate == null);
            if(rentList.Count >0)
            {
                return new ErrorResult(Messages.InvalidCarRent);
            }
            return new SuccessResult();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(c => c.CarId == carId));
        }
    }
}
