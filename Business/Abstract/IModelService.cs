using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        IDataResult<List<Model>> GetByBradnId(int id);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);
    }
}
