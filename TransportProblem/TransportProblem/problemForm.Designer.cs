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
            this.info = new System.Windows.Forms.TextBox();
            this.methodPanel = new System.Windows.Forms.GroupBox();
            this.nsMethod = new System.Windows.Forms.RadioButton();
            this.smallMethod = new System.Windows.Forms.RadioButton();
            this.doMethod = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.size = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stocksValue = new System.Windows.Forms.NumericUpDown();
            this.shopsValue = new System.Windows.Forms.NumericUpDown();
            this.methodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsValue)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(426, 12);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(316, 109);
            this.info.TabIndex = 11;
            this.info.Text = resources.GetString("info.Text");
            // 
            // methodPanel
            // 
            this.methodPanel.Controls.Add(this.doMethod);
            this.methodPanel.Controls.Add(this.smallMethod);
            this.methodPanel.Controls.Add(this.nsMethod);
            this.methodPanel.Location = new System.Drawing.Point(229, 12);
            this.methodPanel.Name = "methodPanel";
            this.methodPanel.Size = new System.Drawing.Size(191, 109);
            this.methodPanel.TabIndex = 10;
            this.methodPanel.TabStop = false;
            this.methodPanel.Text = "Метод решения";
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
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Location = new System.Drawing.Point(12, 145);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 60;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.Size = new System.Drawing.Size(730, 319);
            this.data.TabIndex = 14;
            // 
            // size
            // 
            this.size.Controls.Add(this.shopsValue);
            this.size.Controls.Add(this.stocksValue);
            this.size.Controls.Add(this.label2);
            this.size.Controls.Add(this.label3);
            this.size.Location = new System.Drawing.Point(12, 12);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(211, 109);
            this.size.TabIndex = 9;
            this.size.TabStop = false;
            this.size.Text = "Размер таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Магазинов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Складов:";
            // 
            // stocksValue
            // 
            this.stocksValue.Location = new System.Drawing.Point(79, 27);
            this.stocksValue.Name = "stocksValue";
            this.stocksValue.Size = new System.Drawing.Size(120, 20);
            this.stocksValue.TabIndex = 14;
            this.stocksValue.ValueChanged += new System.EventHandler(this.stocksValue_ValueChanged);
            // 
            // shopsValue
            // 
            this.shopsValue.Location = new System.Drawing.Point(79, 52);
            this.shopsValue.Name = "shopsValue";
            this.shopsValue.Size = new System.Drawing.Size(120, 20);
            this.shopsValue.TabIndex = 15;
            this.shopsValue.ValueChanged += new System.EventHandler(this.shopsValue_ValueChanged);
            // 
            // problemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 476);
            this.Controls.Add(this.data);
            this.Controls.Add(this.size);
            this.Controls.Add(this.info);
            this.Controls.Add(this.methodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "problemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транспортная задача By Deamond";
            this.methodPanel.ResumeLayout(false);
            this.methodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.size.ResumeLayout(false);
            this.size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.GroupBox methodPanel;
        private System.Windows.Forms.Button doMethod;
        private System.Windows.Forms.RadioButton smallMethod;
        private System.Windows.Forms.RadioButton nsMethod;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.GroupBox size;
        private System.Windows.Forms.NumericUpDown shopsValue;
        private System.Windows.Forms.NumericUpDown stocksValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}

