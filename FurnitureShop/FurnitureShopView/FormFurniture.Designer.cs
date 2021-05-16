namespace FurnitureShopView
{
    partial class FormFurniture
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonRef = new System.Windows.Forms.Button();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonUpd = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ComponentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Цена:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(79, 10);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(180, 20);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(79, 36);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(102, 20);
			this.textBoxPrice.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonRef);
			this.groupBox1.Controls.Add(this.buttonDel);
			this.groupBox1.Controls.Add(this.buttonUpd);
			this.groupBox1.Controls.Add(this.buttonAdd);
			this.groupBox1.Controls.Add(this.dataGridView);
			this.groupBox1.Location = new System.Drawing.Point(16, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(494, 324);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Компоненты";
			// 
			// buttonRef
			// 
			this.buttonRef.Location = new System.Drawing.Point(402, 120);
			this.buttonRef.Name = "buttonRef";
			this.buttonRef.Size = new System.Drawing.Size(75, 23);
			this.buttonRef.TabIndex = 4;
			this.buttonRef.Text = "Обновить";
			this.buttonRef.UseVisualStyleBackColor = true;
			this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
			// 
			// buttonDel
			// 
			this.buttonDel.Location = new System.Drawing.Point(402, 91);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(75, 23);
			this.buttonDel.TabIndex = 3;
			this.buttonDel.Text = "Удалить";
			this.buttonDel.UseVisualStyleBackColor = true;
			this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
			// 
			// buttonUpd
			// 
			this.buttonUpd.Location = new System.Drawing.Point(402, 62);
			this.buttonUpd.Name = "buttonUpd";
			this.buttonUpd.Size = new System.Drawing.Size(75, 23);
			this.buttonUpd.TabIndex = 2;
			this.buttonUpd.Text = "Изменить";
			this.buttonUpd.UseVisualStyleBackColor = true;
			this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(402, 33);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentID,
            this.ComponentName,
            this.ComponentCount});
			this.dataGridView.Location = new System.Drawing.Point(7, 20);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(378, 298);
			this.dataGridView.TabIndex = 0;
			// 
			// ComponentID
			// 
			this.ComponentID.HeaderText = "ID";
			this.ComponentID.Name = "ComponentID";
			this.ComponentID.Visible = false;
			// 
			// ComponentName
			// 
			this.ComponentName.HeaderText = "Компонент";
			this.ComponentName.Name = "ComponentName";
			// 
			// ComponentCount
			// 
			this.ComponentCount.HeaderText = "Количество";
			this.ComponentCount.Name = "ComponentCount";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(418, 415);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(337, 415);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormFurniture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 450);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormFurniture";
			this.Text = "Мебель";
			this.Load += new System.EventHandler(this.FormFurniture_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentCount;
    }
}