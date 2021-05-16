namespace FurnitureShopView
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.buttonCreateOrder = new System.Windows.Forms.Button();
			this.buttonTakeOrderInWork = new System.Windows.Forms.Button();
			this.buttonnOrderReady = new System.Windows.Forms.Button();
			this.buttonPayOrder = new System.Windows.Forms.Button();
			this.buttonRef = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// компонентыToolStripMenuItem
			// 
			this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
			this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.компонентыToolStripMenuItem.Text = "Компоненты";
			this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.КомпонентыToolStripMenuItem_Click);
			// 
			// изделияToolStripMenuItem
			// 
			this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
			this.изделияToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.изделияToolStripMenuItem.Text = "Мебель";
			this.изделияToolStripMenuItem.Click += new System.EventHandler(this.ИзделияToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 28);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(605, 410);
			this.dataGridView.TabIndex = 1;
			// 
			// buttonCreateOrder
			// 
			this.buttonCreateOrder.Location = new System.Drawing.Point(624, 49);
			this.buttonCreateOrder.Name = "buttonCreateOrder";
			this.buttonCreateOrder.Size = new System.Drawing.Size(164, 23);
			this.buttonCreateOrder.TabIndex = 2;
			this.buttonCreateOrder.Text = "Создать заказ";
			this.buttonCreateOrder.UseVisualStyleBackColor = true;
			this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
			// 
			// buttonTakeOrderInWork
			// 
			this.buttonTakeOrderInWork.Location = new System.Drawing.Point(624, 78);
			this.buttonTakeOrderInWork.Name = "buttonTakeOrderInWork";
			this.buttonTakeOrderInWork.Size = new System.Drawing.Size(164, 23);
			this.buttonTakeOrderInWork.TabIndex = 3;
			this.buttonTakeOrderInWork.Text = "Отдать на выполнение";
			this.buttonTakeOrderInWork.UseVisualStyleBackColor = true;
			this.buttonTakeOrderInWork.Click += new System.EventHandler(this.buttonTakeOrderInWork_Click);
			// 
			// buttonnOrderReady
			// 
			this.buttonnOrderReady.Location = new System.Drawing.Point(624, 107);
			this.buttonnOrderReady.Name = "buttonnOrderReady";
			this.buttonnOrderReady.Size = new System.Drawing.Size(164, 23);
			this.buttonnOrderReady.TabIndex = 4;
			this.buttonnOrderReady.Text = "Заказ готов";
			this.buttonnOrderReady.UseVisualStyleBackColor = true;
			this.buttonnOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
			// 
			// buttonPayOrder
			// 
			this.buttonPayOrder.Location = new System.Drawing.Point(624, 136);
			this.buttonPayOrder.Name = "buttonPayOrder";
			this.buttonPayOrder.Size = new System.Drawing.Size(164, 23);
			this.buttonPayOrder.TabIndex = 5;
			this.buttonPayOrder.Text = "Заказ оплачен";
			this.buttonPayOrder.UseVisualStyleBackColor = true;
			this.buttonPayOrder.Click += new System.EventHandler(this.buttonPayOrder_Click);
			// 
			// buttonRef
			// 
			this.buttonRef.Location = new System.Drawing.Point(624, 165);
			this.buttonRef.Name = "buttonRef";
			this.buttonRef.Size = new System.Drawing.Size(164, 23);
			this.buttonRef.TabIndex = 6;
			this.buttonRef.Text = "Обновить список";
			this.buttonRef.UseVisualStyleBackColor = true;
			this.buttonRef.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRef);
			this.Controls.Add(this.buttonPayOrder);
			this.Controls.Add(this.buttonnOrderReady);
			this.Controls.Add(this.buttonTakeOrderInWork);
			this.Controls.Add(this.buttonCreateOrder);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Магазин мебели";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonTakeOrderInWork;
        private System.Windows.Forms.Button buttonnOrderReady;
        private System.Windows.Forms.Button buttonPayOrder;
        private System.Windows.Forms.Button buttonRef;
    }
}