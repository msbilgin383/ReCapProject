using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId);
        IResult Add(Rental rental);
        IResult CheckReturnDate(int carId);
        IDataResult<List<Rental>> GetAll();
    }
}
