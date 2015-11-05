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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.info = new System.Windows.Forms.TextBox();
            this.methodPanel = new System.Windows.Forms.GroupBox();
            this.doMethod = new System.Windows.Forms.Button();
            this.smallMethod = new System.Windows.Forms.RadioButton();
            this.nsMethod = new System.Windows.Forms.RadioButton();
            this.data = new System.Windows.Forms.DataGridView();
            this.size = new System.Windows.Forms.GroupBox();
            this.shopsValue = new System.Windows.Forms.NumericUpDown();
            this.stocksValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.methodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksValue)).BeginInit();
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
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.Location = new System.Drawing.Point(12, 145);
            this.data.Name = "data";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowHeadersWidth = 70;
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
            // shopsValue
            // 
            this.shopsValue.Location = new System.Drawing.Point(79, 52);
            this.shopsValue.Name = "shopsValue";
            this.shopsValue.Size = new System.Drawing.Size(120, 20);
            this.shopsValue.TabIndex = 15;
            this.shopsValue.ValueChanged += new System.EventHandler(this.shopsValue_ValueChanged);
            // 
            // stocksValue
            // 
            this.stocksValue.Location = new System.Drawing.Point(79, 27);
            this.stocksValue.Name = "stocksValue";
            this.stocksValue.Size = new System.Drawing.Size(120, 20);
            this.stocksValue.TabIndex = 14;
            this.stocksValue.ValueChanged += new System.EventHandler(this.stocksValue_ValueChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Магазинов:";
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
            ((System.ComponentModel.ISupportInitialize)(this.shopsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksValue)).EndInit();
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

