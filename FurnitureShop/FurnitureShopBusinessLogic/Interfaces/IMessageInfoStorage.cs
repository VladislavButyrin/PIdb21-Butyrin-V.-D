using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.ViewModels;
using System.Collections.Generic;


namespace FurnitureShopBusinessLogic.Interfaces
{
    public interface IMessageInfoStorage
    {
        List<MessageInfoViewModel> GetFullList();
        List<MessageInfoViewModel> GetFilteredList(MessageInfoBindingModel model);
        void Insert(MessageInfoBindingModel model);
    }
}
