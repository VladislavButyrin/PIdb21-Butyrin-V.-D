using System.ComponentModel;
using FurnitureShopBusinessLogic.Attributes;
using System.Runtime.Serialization;


namespace FurnitureShopBusinessLogic.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 50)]
        [DataMember]
        public int Id { get; set; }

        [Column(title: "Название", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }
}
