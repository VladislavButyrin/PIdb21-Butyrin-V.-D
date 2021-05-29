﻿using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.ViewModels;
using System.Collections.Generic;
using System.Text;

namespace FurnitureShopBusinessLogic.Interfaces
{
    public interface IImplementerStorage
    {
        List<ImplementerViewModel> GetFullList();
        List<ImplementerViewModel> GetFilteredList(ImplementerBindingModel model);
        ImplementerViewModel GetElement(ImplementerBindingModel model);
        void Insert(ImplementerBindingModel model);
        void Update(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);

    }
}
