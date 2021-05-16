using FurnitureShopBusinessLogic.Interfaces;
using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.ViewModels;
using FurnitureShopListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureShopListImplement.Implements
{
    public class FurnitureStorage : IFurnitureStorage
    {
        private readonly DataListSingleton source;

        public FurnitureStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<FurnitureViewModel> GetFullList()
        {
            List<FurnitureViewModel> result = new List<FurnitureViewModel>();
            foreach (var component in source.Furnitures)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }

        public List<FurnitureViewModel> GetFilteredList(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<FurnitureViewModel> result = new List<FurnitureViewModel>();
            foreach (var Furniture in source.Furnitures)
            {
                if (Furniture.FurnitureName.Contains(model.FurnitureName))
                {
                    result.Add(CreateModel(Furniture));
                }
            }
            return result;
        }

        public FurnitureViewModel GetElement(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var Furniture in source.Furnitures)
            {
                if (Furniture.Id == model.Id || Furniture.FurnitureName ==
                model.FurnitureName)
                {
                    return CreateModel(Furniture);
                }
            }
            return null;
        }

        public void Insert(FurnitureBindingModel model)
        {
            Furniture tempFurniture = new Furniture
            {
                Id = 1,
                FurnitureComponents = new
            Dictionary<int, int>()
            };
            foreach (var Furniture in source.Furnitures)
            {
                if (Furniture.Id >= tempFurniture.Id)
                {
                    tempFurniture.Id = Furniture.Id + 1;
                }
            }
            source.Furnitures.Add(CreateModel(model, tempFurniture));
        }

        public void Update(FurnitureBindingModel model)
        {
            Furniture tempFurniture = null;
            foreach (var Furniture in source.Furnitures)
            {
                if (Furniture.Id == model.Id)
                {
                    tempFurniture = Furniture;
                }
            }
            if (tempFurniture == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempFurniture);
        }

        public void Delete(FurnitureBindingModel model)
        {
            for (int i = 0; i < source.Furnitures.Count; ++i)
            {
                if (source.Furnitures[i].Id == model.Id)
                {
                    source.Furnitures.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
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
        private FurnitureViewModel CreateModel(Furniture Furniture)
        {
            // требуется дополнительно получить список компонентов для изделия с названиями и их количество
            Dictionary<int, (string, int)> FurnitureComponents = new
            Dictionary<int, (string, int)>();
            foreach (var pc in Furniture.FurnitureComponents)
            {
                string componentName = string.Empty;
                foreach (var component in source.Components)
                {
                    if (pc.Key == component.Id)
                    {
                        componentName = component.ComponentName;
                        break;
                    }
                }
                FurnitureComponents.Add(pc.Key, (componentName, pc.Value));
            }
            return new FurnitureViewModel
            {
                Id = Furniture.Id,
                FurnitureName = Furniture.FurnitureName,
                Price = Furniture.Price,
                FurnitureComponents = FurnitureComponents
            };
        }
    }
}
