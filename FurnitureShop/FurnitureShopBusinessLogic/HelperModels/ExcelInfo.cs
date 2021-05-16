using FurnitureShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureShopBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportFurnitureComponentViewModel> FurnitureComponents { get; set; }
    }
}
