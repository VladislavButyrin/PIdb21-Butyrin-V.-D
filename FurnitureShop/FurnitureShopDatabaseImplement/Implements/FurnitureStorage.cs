using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.Interfaces;
using FurnitureShopBusinessLogic.ViewModels;
using FurnitureShopDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FurnitureShopDatabaseImplement.Implements
{
    public class FurnitureStorage : IFurnitureStorage
    {
        public List<FurnitureViewModel> GetFullList()
        {
            using (var context = new FurnitureShopDatabase())
            {
                return context.Furnitures
                    .Include(rec => rec.FurnitureComponents)
                    .ThenInclude(rec => rec.Component)
                    .ToList()
                    .Select(rec => new FurnitureViewModel
                    {
                        Id = rec.Id,
                        FurnitureName = rec.FurnitureName,
                        Price = rec.Price,
                        FurnitureComponents = rec.FurnitureComponents
                            .ToDictionary(recFurnitureComponents => recFurnitureComponents.ComponentId,
                            recFurnitureComponents => (recFurnitureComponents.Component?.ComponentName,
                            recFurnitureComponents.Count))
                    })
                    .ToList();
            }
        }
        public List<FurnitureViewModel> GetFilteredList(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new FurnitureShopDatabase())
            {
                return context.Furnitures
                    .Include(rec => rec.FurnitureComponents)
                    .ThenInclude(rec => rec.Component)
                    .Where(rec => rec.FurnitureName.Contains(model.FurnitureName))
                    .ToList()
                    .Select(rec => new FurnitureViewModel
                    {
                        Id = rec.Id,
                        FurnitureName = rec.FurnitureName,
                        Price = rec.Price,
                        FurnitureComponents = rec.FurnitureComponents
                            .ToDictionary(recFurnitureComponents => recFurnitureComponents.ComponentId,
                            recFurnitureComponents => (recFurnitureComponents.Component?.ComponentName,
                            recFurnitureComponents.Count))
                    })
                    .ToList();
            }
        }
        public FurnitureViewModel GetElement(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new FurnitureShopDatabase())
            {
                var Furniture = context.Furnitures
                    .Include(rec => rec.FurnitureComponents)
                    .ThenInclude(rec => rec.Component)
                    .FirstOrDefault(rec => rec.FurnitureName == model.FurnitureName ||
                    rec.Id == model.Id);

                return Furniture != null ?
                    new FurnitureViewModel
                    {
                        Id = Furniture.Id,
                        FurnitureName = Furniture.FurnitureName,
                        Price = Furniture.Price,
                        FurnitureComponents = Furniture.FurnitureComponents
                            .ToDictionary(recFurnitureComponent => recFurnitureComponent.ComponentId,
                            recFurnitureComponent => (recFurnitureComponent.Component?.ComponentName,
                            recFurnitureComponent.Count))
                    } :
                    null;
            }
        }
        public void Insert(FurnitureBindingModel model)
        {
            using (var context = new FurnitureShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        CreateModel(model, new Furniture(), context);
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Update(FurnitureBindingModel model)
        {
            using (var context = new FurnitureShopDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var Furniture = context.Furnitures.FirstOrDefault(rec => rec.Id == model.Id);

                        if (Furniture == null)
                        {
                            throw new Exception("Подарок не найден");
                        }

                        CreateModel(model, Furniture, context);
                        context.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(FurnitureBindingModel model)
        {
            using (var context = new FurnitureShopDatabase())
            {
                var Component = context.Furnitures.FirstOrDefault(rec => rec.Id == model.Id);

                if (Component == null)
                {
                    throw new Exception("Материал не найден");
                }

                context.Furnitures.Remove(Component);
                context.SaveChanges();
            }
        }
        private Furniture CreateModel(FurnitureBindingModel model, Furniture Furniture, FurnitureShopDatabase context)
        {
            Furniture.FurnitureName = model.FurnitureName;
            Furniture.Price = model.Price;
            if (Furniture.Id == 0)
            {
                context.Furnitures.Add(Furniture);
                context.SaveChanges();
            }

            if (model.Id.HasValue)
            {
                var FurnitureComponent = context.FurnitureComponents
                    .Where(rec => rec.FurnitureId == model.Id.Value)
                    .ToList();

                context.FurnitureComponents.RemoveRange(FurnitureComponent
                    .Where(rec => !model.FurnitureComponents.ContainsKey(rec.FurnitureId))
                    .ToList());
                context.SaveChanges();

                foreach (var updateComponent in FurnitureComponent)
                {
                    updateComponent.Count = model.FurnitureComponents[updateComponent.ComponentId].Item2;
                    model.FurnitureComponents.Remove(updateComponent.FurnitureId);
                }
                context.SaveChanges();
            }
            foreach (var FurnitureComponent in model.FurnitureComponents)
            {
                context.FurnitureComponents.Add(new FurnitureComponent
                {
                    FurnitureId = Furniture.Id,
                    ComponentId = FurnitureComponent.Key,
                    Count = FurnitureComponent.Value.Item2
                });
                context.SaveChanges();
            }
            return Furniture;
        }
    }
}
