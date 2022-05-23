using Core;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetCarsByColorId(int id);
        //IDataResult<List<ColorDetailDto>> GetColorDetails();

        IResult Add(Color color);
        IResult Remove(Color color);
        IResult Update(Color color);

    }
}
