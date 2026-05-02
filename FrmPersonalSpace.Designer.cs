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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonalSpace));
            this.dgvPizzaOrders = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearchOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzaOrders)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPizzaOrders
            // 
            this.dgvPizzaOrders.AllowUserToAddRows = false;
            this.dgvPizzaOrders.AllowUserToDeleteRows = false;
            this.dgvPizzaOrders.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzaOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPizzaOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizzaOrders.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPizzaOrders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPizzaOrders.Location = new System.Drawing.Point(12, 92);
            this.dgvPizzaOrders.Name = "dgvPizzaOrders";
            this.dgvPizzaOrders.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPizzaOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPizzaOrders.RowHeadersWidth = 51;
            this.dgvPizzaOrders.RowTemplate.Height = 24;
            this.dgvPizzaOrders.Size = new System.Drawing.Size(1090, 400);
            this.dgvPizzaOrders.TabIndex = 0;
            this.dgvPizzaOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPizzaOrders_CellContentClick);
            this.dgvPizzaOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPizzaOrders_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditOrder_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteOrder_Click);
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
            this.BackgroundImage = global::CommandPizzaApp.Properties.Resources.Pizza_app_Main_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1114, 573);
            this.Controls.Add(this.tbSearchOrder);
            this.Controls.Add(this.dgvPizzaOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonalSpace";
            this.Text = "FrmPersonalSpace";
            this.Load += new System.EventHandler(this.FrmPersonalSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizzaOrders)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPizzaOrders;
        private System.Windows.Forms.TextBox tbSearchOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}