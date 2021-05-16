namespace FurnitureShopView
{
    partial class FormReportProductComponents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentName,
            this.FurnitureName,
            this.Count});
            this.dataGridView.Location = new System.Drawing.Point(12, 29);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(485, 458);
            this.dataGridView.TabIndex = 0;
            // 
            // ComponentName
            // 
            this.ComponentName.HeaderText = "Компоненет";
            this.ComponentName.Name = "ComponentName";
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Мебель";
            this.FurnitureName.Name = "FurnitureName";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // buttonSaveToExcel
            // 
            this.buttonSaveToExcel.Location = new System.Drawing.Point(13, 0);
            this.buttonSaveToExcel.Name = "buttonSaveToExcel";
            this.buttonSaveToExcel.Size = new System.Drawing.Size(174, 23);
            this.buttonSaveToExcel.TabIndex = 1;
            this.buttonSaveToExcel.Text = "Сохранить в Excel";
            this.buttonSaveToExcel.UseVisualStyleBackColor = true;
            this.buttonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // FormReportProductComponents
            // 
            this.ClientSize = new System.Drawing.Size(509, 499);
            this.Controls.Add(this.buttonSaveToExcel);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormReportProductComponents";
            this.Load += new System.EventHandler(this.FormReportProductComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSaveToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

