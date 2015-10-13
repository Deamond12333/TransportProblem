namespace TransportProblem
{
    partial class problemForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(problemForm));
            this.data = new System.Windows.Forms.DataGridView();
            this.sizeY = new System.Windows.Forms.TextBox();
            this.sizeX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createData = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.GroupBox();
            this.methodPanel = new System.Windows.Forms.GroupBox();
            this.doMethod = new System.Windows.Forms.Button();
            this.smallMethod = new System.Windows.Forms.RadioButton();
            this.nsMethod = new System.Windows.Forms.RadioButton();
            this.info = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.size.SuspendLayout();
            this.methodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.ColumnHeadersVisible = false;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Location = new System.Drawing.Point(12, 153);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 43;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.Size = new System.Drawing.Size(355, 226);
            this.data.TabIndex = 0;
            // 
            // sizeY
            // 
            this.sizeY.Location = new System.Drawing.Point(85, 26);
            this.sizeY.Name = "sizeY";
            this.sizeY.Size = new System.Drawing.Size(49, 20);
            this.sizeY.TabIndex = 2;
            // 
            // sizeX
            // 
            this.sizeX.Location = new System.Drawing.Point(85, 52);
            this.sizeX.Name = "sizeX";
            this.sizeX.Size = new System.Drawing.Size(49, 20);
            this.sizeX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Складов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Магазинов:";
            // 
            // createData
            // 
            this.createData.Location = new System.Drawing.Point(21, 78);
            this.createData.Name = "createData";
            this.createData.Size = new System.Drawing.Size(113, 23);
            this.createData.TabIndex = 8;
            this.createData.Text = "Создать таблицу";
            this.createData.UseVisualStyleBackColor = true;
            this.createData.Click += new System.EventHandler(this.createData_Click);
            // 
            // size
            // 
            this.size.Controls.Add(this.createData);
            this.size.Controls.Add(this.label2);
            this.size.Controls.Add(this.sizeX);
            this.size.Controls.Add(this.label3);
            this.size.Controls.Add(this.sizeY);
            this.size.Location = new System.Drawing.Point(12, 12);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(158, 109);
            this.size.TabIndex = 9;
            this.size.TabStop = false;
            this.size.Text = "Размер таблицы";
            // 
            // methodPanel
            // 
            this.methodPanel.Controls.Add(this.doMethod);
            this.methodPanel.Controls.Add(this.smallMethod);
            this.methodPanel.Controls.Add(this.nsMethod);
            this.methodPanel.Location = new System.Drawing.Point(176, 12);
            this.methodPanel.Name = "methodPanel";
            this.methodPanel.Size = new System.Drawing.Size(191, 109);
            this.methodPanel.TabIndex = 10;
            this.methodPanel.TabStop = false;
            this.methodPanel.Text = "Метод решения";
            // 
            // doMethod
            // 
            this.doMethod.Location = new System.Drawing.Point(6, 78);
            this.doMethod.Name = "doMethod";
            this.doMethod.Size = new System.Drawing.Size(177, 23);
            this.doMethod.TabIndex = 2;
            this.doMethod.Text = "Решить";
            this.doMethod.UseVisualStyleBackColor = true;
            this.doMethod.Click += new System.EventHandler(this.doMethod_Click);
            // 
            // smallMethod
            // 
            this.smallMethod.AutoSize = true;
            this.smallMethod.Location = new System.Drawing.Point(6, 52);
            this.smallMethod.Name = "smallMethod";
            this.smallMethod.Size = new System.Drawing.Size(181, 17);
            this.smallMethod.TabIndex = 1;
            this.smallMethod.TabStop = true;
            this.smallMethod.Text = "Метод наименьшей стоимости";
            this.smallMethod.UseVisualStyleBackColor = true;
            this.smallMethod.CheckedChanged += new System.EventHandler(this.Methods_CheckedChanged);
            // 
            // nsMethod
            // 
            this.nsMethod.AutoSize = true;
            this.nsMethod.Location = new System.Drawing.Point(6, 27);
            this.nsMethod.Name = "nsMethod";
            this.nsMethod.Size = new System.Drawing.Size(177, 17);
            this.nsMethod.TabIndex = 0;
            this.nsMethod.TabStop = true;
            this.nsMethod.Text = "Метод северо-западного угла";
            this.nsMethod.UseVisualStyleBackColor = true;
            this.nsMethod.CheckedChanged += new System.EventHandler(this.Methods_CheckedChanged);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(387, 12);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(355, 109);
            this.info.TabIndex = 11;
            this.info.Text = resources.GetString("info.Text");
            // 
            // result
            // 
            this.result.AllowUserToAddRows = false;
            this.result.AllowUserToDeleteRows = false;
            this.result.AllowUserToResizeColumns = false;
            this.result.AllowUserToResizeRows = false;
            this.result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.result.ColumnHeadersVisible = false;
            this.result.EnableHeadersVisualStyles = false;
            this.result.Location = new System.Drawing.Point(387, 153);
            this.result.MultiSelect = false;
            this.result.Name = "result";
            this.result.RowHeadersVisible = false;
            this.result.RowHeadersWidth = 43;
            this.result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.result.Size = new System.Drawing.Size(355, 226);
            this.result.TabIndex = 12;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.Location = new System.Drawing.Point(12, 385);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(730, 33);
            this.clear.TabIndex = 13;
            this.clear.Text = "Очистить всё";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // problemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 424);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.info);
            this.Controls.Add(this.methodPanel);
            this.Controls.Add(this.size);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "problemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транспортная задача By Deamond";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.size.ResumeLayout(false);
            this.size.PerformLayout();
            this.methodPanel.ResumeLayout(false);
            this.methodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox sizeY;
        private System.Windows.Forms.TextBox sizeX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createData;
        private System.Windows.Forms.GroupBox size;
        private System.Windows.Forms.GroupBox methodPanel;
        private System.Windows.Forms.RadioButton smallMethod;
        private System.Windows.Forms.RadioButton nsMethod;
        private System.Windows.Forms.Button doMethod;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.DataGridView result;
        private System.Windows.Forms.Button clear;

    }
}

