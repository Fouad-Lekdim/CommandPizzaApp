using System.Drawing;

namespace CommandPizzaApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.chbExtraCheese = new System.Windows.Forms.CheckBox();
            this.chbMashrooms = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbtnThick = new System.Windows.Forms.RadioButton();
            this.rbtnThin = new System.Windows.Forms.RadioButton();
            this.chbGreenPepper = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbtnTakeAway = new System.Windows.Forms.RadioButton();
            this.rbtnEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonalSpace = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Name = "label1";
            // 
            // chbExtraCheese
            // 
            resources.ApplyResources(this.chbExtraCheese, "chbExtraCheese");
            this.chbExtraCheese.ForeColor = System.Drawing.Color.White;
            this.chbExtraCheese.Name = "chbExtraCheese";
            this.chbExtraCheese.UseVisualStyleBackColor = true;
            this.chbExtraCheese.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // chbMashrooms
            // 
            resources.ApplyResources(this.chbMashrooms, "chbMashrooms");
            this.chbMashrooms.ForeColor = System.Drawing.Color.White;
            this.chbMashrooms.Name = "chbMashrooms";
            this.chbMashrooms.UseVisualStyleBackColor = true;
            this.chbMashrooms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // chbTomatoes
            // 
            resources.ApplyResources(this.chbTomatoes, "chbTomatoes");
            this.chbTomatoes.ForeColor = System.Drawing.Color.White;
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // rbtnSmall
            // 
            resources.ApplyResources(this.rbtnSmall, "rbtnSmall");
            this.rbtnSmall.Checked = true;
            this.rbtnSmall.ForeColor = System.Drawing.Color.White;
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.TabStop = true;
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSize_checkedChanged);
            // 
            // rbtnMedium
            // 
            resources.ApplyResources(this.rbtnMedium, "rbtnMedium");
            this.rbtnMedium.ForeColor = System.Drawing.Color.White;
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSize_checkedChanged);
            // 
            // rbtnLarge
            // 
            resources.ApplyResources(this.rbtnLarge, "rbtnLarge");
            this.rbtnLarge.ForeColor = System.Drawing.Color.White;
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.TabStop = true;
            this.rbtnLarge.UseVisualStyleBackColor = true;
            this.rbtnLarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSize_checkedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbtnMedium);
            this.gbSize.Controls.Add(this.rbtnLarge);
            this.gbSize.Controls.Add(this.rbtnSmall);
            resources.ApplyResources(this.gbSize, "gbSize");
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Name = "gbSize";
            this.gbSize.TabStop = false;
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rbtnThick);
            this.gbCrustType.Controls.Add(this.rbtnThin);
            resources.ApplyResources(this.gbCrustType, "gbCrustType");
            this.gbCrustType.ForeColor = System.Drawing.Color.White;
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.TabStop = false;
            // 
            // rbtnThick
            // 
            resources.ApplyResources(this.rbtnThick, "rbtnThick");
            this.rbtnThick.ForeColor = System.Drawing.Color.White;
            this.rbtnThick.Name = "rbtnThick";
            this.rbtnThick.TabStop = true;
            this.rbtnThick.UseVisualStyleBackColor = true;
            this.rbtnThick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCrustType_checkedChanged);
            // 
            // rbtnThin
            // 
            resources.ApplyResources(this.rbtnThin, "rbtnThin");
            this.rbtnThin.Checked = true;
            this.rbtnThin.ForeColor = System.Drawing.Color.White;
            this.rbtnThin.Name = "rbtnThin";
            this.rbtnThin.TabStop = true;
            this.rbtnThin.UseVisualStyleBackColor = true;
            this.rbtnThin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCrustType_checkedChanged);
            // 
            // chbGreenPepper
            // 
            resources.ApplyResources(this.chbGreenPepper, "chbGreenPepper");
            this.chbGreenPepper.ForeColor = System.Drawing.Color.White;
            this.chbGreenPepper.Name = "chbGreenPepper";
            this.chbGreenPepper.UseVisualStyleBackColor = true;
            this.chbGreenPepper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // chbOlives
            // 
            resources.ApplyResources(this.chbOlives, "chbOlives");
            this.chbOlives.ForeColor = System.Drawing.Color.White;
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // chbOnion
            // 
            resources.ApplyResources(this.chbOnion, "chbOnion");
            this.chbOnion.ForeColor = System.Drawing.Color.White;
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkToppings_ClickChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chbTomatoes);
            this.gbToppings.Controls.Add(this.chbGreenPepper);
            this.gbToppings.Controls.Add(this.chbExtraCheese);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbMashrooms);
            this.gbToppings.Controls.Add(this.chbOnion);
            resources.ApplyResources(this.gbToppings, "gbToppings");
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.TabStop = false;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbtnTakeAway);
            this.gbWhereToEat.Controls.Add(this.rbtnEatIn);
            resources.ApplyResources(this.gbWhereToEat, "gbWhereToEat");
            this.gbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.TabStop = false;
            // 
            // rbtnTakeAway
            // 
            resources.ApplyResources(this.rbtnTakeAway, "rbtnTakeAway");
            this.rbtnTakeAway.ForeColor = System.Drawing.Color.White;
            this.rbtnTakeAway.Name = "rbtnTakeAway";
            this.rbtnTakeAway.TabStop = true;
            this.rbtnTakeAway.UseVisualStyleBackColor = true;
            this.rbtnTakeAway.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbWhereToEat_checkedChanged);
            // 
            // rbtnEatIn
            // 
            resources.ApplyResources(this.rbtnEatIn, "rbtnEatIn");
            this.rbtnEatIn.Checked = true;
            this.rbtnEatIn.ForeColor = System.Drawing.Color.White;
            this.rbtnEatIn.Name = "rbtnEatIn";
            this.rbtnEatIn.TabStop = true;
            this.rbtnEatIn.UseVisualStyleBackColor = true;
            this.rbtnEatIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbWhereToEat_checkedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.btnOrderPizza, "btnOrderPizza");
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.btnResetForm, "btnResetForm");
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.lblOrderNum);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label7);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            resources.ApplyResources(this.gbOrderSummary, "gbOrderSummary");
            this.gbOrderSummary.ForeColor = System.Drawing.Color.White;
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.TabStop = false;
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblToppings, "lblToppings");
            this.lblToppings.Name = "lblToppings";
            // 
            // lblWhereToEat
            // 
            resources.ApplyResources(this.lblWhereToEat, "lblWhereToEat");
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.lblWhereToEat.Name = "lblWhereToEat";
            // 
            // lblCrustType
            // 
            resources.ApplyResources(this.lblCrustType, "lblCrustType");
            this.lblCrustType.ForeColor = System.Drawing.Color.Black;
            this.lblCrustType.Name = "lblCrustType";
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Name = "lblSize";
            // 
            // lblOrderNum
            // 
            resources.ApplyResources(this.lblOrderNum, "lblOrderNum");
            this.lblOrderNum.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNum.Name = "lblOrderNum";
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // btnPersonalSpace
            // 
            this.btnPersonalSpace.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.btnPersonalSpace, "btnPersonalSpace");
            this.btnPersonalSpace.Name = "btnPersonalSpace";
            this.btnPersonalSpace.UseVisualStyleBackColor = false;
            this.btnPersonalSpace.Click += new System.EventHandler(this.btnPersonalSpace_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CommandPizzaApp.Properties.Resources.ai_generated_delicious_pizza_on_black_stone_top_view_fresh_ingredients_space_for_text_on_left_side_free_photo;
            this.Controls.Add(this.btnPersonalSpace);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbExtraCheese;
        private System.Windows.Forms.CheckBox chbMashrooms;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbtnThick;
        private System.Windows.Forms.RadioButton rbtnThin;
        private System.Windows.Forms.CheckBox chbGreenPepper;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbtnTakeAway;
        private System.Windows.Forms.RadioButton rbtnEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Button btnPersonalSpace;
        private System.Windows.Forms.Label lblToppings;
    }
}

