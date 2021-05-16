using FurnitureShopBusinessLogic.Interfaces;
using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.ViewModels;
using FurnitureShopFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FurnitureShopFileImplement.Implements
{
    public class FurnitureStorage : IFurnitureStorage
    {
        private readonly FileDataListSingleton source;

        public FurnitureStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }

        public List<FurnitureViewModel> GetFullList()
        {
            return source.Furnitures
                .Select(CreateModel)
                .ToList();

        }

        public List<FurnitureViewModel> GetFilteredList(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Furnitures
                .Where(rec => rec.FurnitureName.Contains(model.FurnitureName))
                .Select(CreateModel)
                .ToList();

        }

        public FurnitureViewModel GetElement(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var furniture = source.Furnitures
            .FirstOrDefault(rec => rec.FurnitureName == model.FurnitureName || rec.Id
           == model.Id);
            return furniture != null ? CreateModel(furniture) : null;
        }
    

        public void Insert(FurnitureBindingModel model)
        {
            int maxId = source.Furnitures.Count > 0 ? source.Components.Max(rec => rec.Id)
            : 0;
            var element = new Furniture
            {
                Id = maxId + 1,
                FurnitureComponents = new
                    Dictionary<int, int>()
            };
            source.Furnitures.Add(CreateModel(model, element));
        }

        public void Update(FurnitureBindingModel model)
        {
            var element = source.Furnitures.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);

        }

        public void Delete(FurnitureBindingModel model)
        {
            Furniture element = source.Furnitures.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Furnitures.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        private Furniture CreateModel(FurnitureBindingModel model, Furniture Furniture)
        {
            Furniture.FurnitureName = model.FurnitureName;
            Furniture.Price = model.Price;
            // удаляем убранные
            foreach (var key in Furniture.FurnitureComponents.Keys.ToList())
            {
                if (!model.FurnitureComponents.ContainsKey(key))
                {
                    Furniture.FurnitureComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.FurnitureComponents)
            {
                if (Furniture.FurnitureComponents.ContainsKey(component.Key))
                {
                    Furniture.FurnitureComponents[component.Key] =
                    model.FurnitureComponents[component.Key].Item2;
                }
                else
                {
                    Furniture.FurnitureComponents.Add(component.Key,
                    model.FurnitureComponents[component.Key].Item2);
                }
            }
            return Furniture;
        }
        private FurnitureViewModel CreateModel(Furniture furniture)
        {
            return new FurnitureViewModel
            {
                Id = furniture.Id,
                FurnitureName = furniture.FurnitureName,
                Price = furniture.Price,
                FurnitureComponents = furniture.FurnitureComponents
                    .ToDictionary(recPC => recPC.Key, recPC =>
                        (source.Components.FirstOrDefault(recC => recC.Id ==
                    recPC.Key)?.ComponentName, recPC.Value))
            };
        }
    }
}
