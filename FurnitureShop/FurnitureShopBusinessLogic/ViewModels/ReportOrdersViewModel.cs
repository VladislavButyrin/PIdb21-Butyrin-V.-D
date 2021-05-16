using FurnitureShopBusinessLogic.Enums;
using System;
using System.ComponentModel;

namespace FurnitureShopBusinessLogic.ViewModels
{
    public class ReportOrdersViewModel
    {
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Имя мебели")]
        public string FurnitureName { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }

    }
}
