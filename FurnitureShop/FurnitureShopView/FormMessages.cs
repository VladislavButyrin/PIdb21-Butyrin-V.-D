using FurnitureShopBusinessLogic.BindingModels;
using FurnitureShopBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;

namespace FurnitureShopView
{
    public partial class FormMessages : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly MailLogic logic;

        public FormMessages(MailLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormMessages_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(logic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
