namespace TransportProblem
{
    partial class resultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data = new System.Windows.Forms.DataGridView();
            this.results = new System.Windows.Forms.TabControl();
            this.firstResult = new System.Windows.Forms.TabPage();
            this.cost = new System.Windows.Forms.Label();
            this.optimalResult = new System.Windows.Forms.TabPage();
            this.optimizeCost = new System.Windows.Forms.Label();
            this.optimize = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.results.SuspendLayout();
            this.firstResult.SuspendLayout();
            this.optimalResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optimize)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.Location = new System.Drawing.Point(3, 6);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowHeadersWidth = 60;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.Size = new System.Drawing.Size(738, 326);
            this.data.TabIndex = 0;
            // 
            // results
            // 
            this.results.Controls.Add(this.firstResult);
            this.results.Controls.Add(this.optimalResult);
            this.results.Location = new System.Drawing.Point(12, 12);
            this.results.Name = "results";
            this.results.SelectedIndex = 0;
            this.results.Size = new System.Drawing.Size(755, 403);
            this.results.TabIndex = 1;
            // 
            // firstResult
            // 
            this.firstResult.Controls.Add(this.cost);
            this.firstResult.Controls.Add(this.data);
            this.firstResult.Location = new System.Drawing.Point(4, 22);
            this.firstResult.Name = "firstResult";
            this.firstResult.Padding = new System.Windows.Forms.Padding(3);
            this.firstResult.Size = new System.Drawing.Size(747, 377);
            this.firstResult.TabIndex = 0;
            this.firstResult.Text = "Предварительное решение";
            this.firstResult.UseVisualStyleBackColor = true;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(6, 347);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(303, 24);
            this.cost.TabIndex = 1;
            this.cost.Text = "Общая стоимость: ^[0-9]{1-5}$";
            // 
            // optimalResult
            // 
            this.optimalResult.Controls.Add(this.optimizeCost);
            this.optimalResult.Controls.Add(this.optimize);
            this.optimalResult.Location = new System.Drawing.Point(4, 22);
            this.optimalResult.Name = "optimalResult";
            this.optimalResult.Padding = new System.Windows.Forms.Padding(3);
            this.optimalResult.Size = new System.Drawing.Size(747, 377);
            this.optimalResult.TabIndex = 1;
            this.optimalResult.Text = "Оптимизация";
            this.optimalResult.UseVisualStyleBackColor = true;
            // 
            // optimizeCost
            // 
            this.optimizeCost.AutoSize = true;
            this.optimizeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optimizeCost.Location = new System.Drawing.Point(7, 347);
            this.optimizeCost.Name = "optimizeCost";
            this.optimizeCost.Size = new System.Drawing.Size(303, 24);
            this.optimizeCost.TabIndex = 3;
            this.optimizeCost.Text = "Общая стоимость: ^[0-9]{1-5}$";
            // 
            // optimize
            // 
            this.optimize.AllowUserToAddRows = false;
            this.optimize.AllowUserToDeleteRows = false;
            this.optimize.AllowUserToResizeColumns = false;
            this.optimize.AllowUserToResizeRows = false;
            this.optimize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.optimize.Location = new System.Drawing.Point(4, 6);
            this.optimize.Name = "optimize";
            this.optimize.ReadOnly = true;
            this.optimize.RowHeadersWidth = 60;
            this.optimize.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.optimize.Size = new System.Drawing.Size(738, 326);
            this.optimize.TabIndex = 2;
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 427);
            this.Controls.Add(this.results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "resultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.results.ResumeLayout(false);
            this.firstResult.ResumeLayout(false);
            this.firstResult.PerformLayout();
            this.optimalResult.ResumeLayout(false);
            this.optimalResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TabControl results;
        private System.Windows.Forms.TabPage firstResult;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.TabPage optimalResult;
        private System.Windows.Forms.Label optimizeCost;
        private System.Windows.Forms.DataGridView optimize;
    }
}