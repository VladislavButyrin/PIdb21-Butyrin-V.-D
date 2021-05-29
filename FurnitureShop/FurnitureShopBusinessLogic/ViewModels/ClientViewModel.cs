using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using FurnitureShopBusinessLogic.Attributes;

namespace FurnitureShopBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public int Id { get; set; }

        [Column(title: "ФИО клиента", width: 100)]
        [DataMember]
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }

        [Column(title: "Email", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Column(title: "Пароль", width: 100)]
        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
