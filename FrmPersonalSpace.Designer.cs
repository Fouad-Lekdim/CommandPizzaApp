namespace CommandPizzaApp
{
    partial class FrmPersonalSpace
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPizzaOrders = new System.Windows.Forms.DataGridView();
            this.tbSearchOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzaOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPizzaOrders
            // 
            this.dgvPizzaOrders.AllowUserToAddRows = false;
            this.dgvPizzaOrders.AllowUserToDeleteRows = false;
            this.dgvPizzaOrders.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzaOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPizzaOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPizzaOrders.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPizzaOrders.Location = new System.Drawing.Point(12, 92);
            this.dgvPizzaOrders.Name = "dgvPizzaOrders";
            this.dgvPizzaOrders.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzaOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPizzaOrders.RowHeadersWidth = 51;
            this.dgvPizzaOrders.RowTemplate.Height = 24;
            this.dgvPizzaOrders.Size = new System.Drawing.Size(1090, 400);
            this.dgvPizzaOrders.TabIndex = 0;
            // 
            // tbSearchOrder
            // 
            this.tbSearchOrder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbSearchOrder.Location = new System.Drawing.Point(938, 54);
            this.tbSearchOrder.Name = "tbSearchOrder";
            this.tbSearchOrder.Size = new System.Drawing.Size(164, 22);
            this.tbSearchOrder.TabIndex = 1;
            this.tbSearchOrder.Text = "Search order";
            this.tbSearchOrder.TextChanged += new System.EventHandler(this.tbSearchOrder_TextChanged);
            this.tbSearchOrder.Enter += new System.EventHandler(this.tbSearchOrder_Enter);
            this.tbSearchOrder.Leave += new System.EventHandler(this.tbSearchOrder_Leave);
            // 
            // FrmPersonalSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 573);
            this.Controls.Add(this.tbSearchOrder);
            this.Controls.Add(this.dgvPizzaOrders);
            this.Name = "FrmPersonalSpace";
            this.Text = "FrmPersonalSpace";
            this.Load += new System.EventHandler(this.FrmPersonalSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzaOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPizzaOrders;
        private System.Windows.Forms.TextBox tbSearchOrder;
    }
}