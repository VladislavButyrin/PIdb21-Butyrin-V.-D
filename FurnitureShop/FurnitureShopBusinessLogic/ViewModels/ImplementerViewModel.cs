using FurnitureShopBusinessLogic.Attributes;
using System.Runtime.Serialization;
using System.ComponentModel;


namespace FurnitureShopBusinessLogic.ViewModels
{
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public int Id { get; set; }

        [Column(title: "ФИО исполнителя", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("ФИО исполнителя")]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время на заказ", width: 100)]
        [DataMember]
        [DisplayName("Время на заказ")]
        public int WorkingTime { get; set; }

        [Column(title: "Время на перерыв", width: 100)]
        [DataMember]
        [DisplayName("Время на перерыв")]
        public int PauseTime { get; set; }
    }
}
