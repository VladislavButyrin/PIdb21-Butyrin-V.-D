﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FurnitureShopBusinessLogic.ViewModels
{
    [DataContract]
    public class FurnitureViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("Название мебели")]
        public string FurnitureName { get; set; }

        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
