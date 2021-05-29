using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using FurnitureShopBusinessLogic.Attributes;

namespace FurnitureShopBusinessLogic.ViewModels
{
    [DataContract]
    public class MessageInfoViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public string MessageId { get; set; }

        [Column(title: "Отправитель", width: 100)]
        [DisplayName("Отправитель")]
        [DataMember]
        public string SenderName { get; set; }

        [Column(title: "Дата письма", width: 100)]
        [DisplayName("Дата письма")]
        [DataMember]
        public DateTime DateDelivery { get; set; }

        [Column(title: "Заголовок", width: 100)]
        [DisplayName("Заголовок")]
        [DataMember]
        public string Subject { get; set; }

        [Column(title: "Текст", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DisplayName("Текст")]
        [DataMember]
        public string Body { get; set; }

    }
}
