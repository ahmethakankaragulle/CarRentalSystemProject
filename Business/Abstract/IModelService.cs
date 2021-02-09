using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    interface IModelService
    {
        List<Model> GetAll();
        List<Model> GetByBradnId(int id);
        void Add(Model model);
        void Update(Model model);
        void Delete(Model model);
    }
}
