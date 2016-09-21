namespace FlagMaker
{
    partial class StripeEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numStripes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkStartStripe = new System.Windows.Forms.CheckBox();
            this.chkEndStripe = new System.Windows.Forms.CheckBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.slStripeSpacing = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStripePercent = new System.Windows.Forms.TextBox();
            this.txtSpacePercent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStripes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slStripeSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // numStripes
            // 
            this.numStripes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numStripes.Location = new System.Drawing.Point(164, 3);
            this.numStripes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numStripes.Name = "numStripes";
            this.numStripes.Size = new System.Drawing.Size(51, 22);
            this.numStripes.TabIndex = 0;
            this.numStripes.ValueChanged += new System.EventHandler(this.numStripes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Stripes";
            // 
            // chkStartStripe
            // 
            this.chkStartStripe.AutoSize = true;
            this.chkStartStripe.Checked = true;
            this.chkStartStripe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartStripe.Location = new System.Drawing.Point(6, 38);
            this.chkStartStripe.Name = "chkStartStripe";
            this.chkStartStripe.Size = new System.Drawing.Size(124, 21);
            this.chkStartStripe.TabIndex = 2;
            this.chkStartStripe.Text = "Start On Stripe";
            this.chkStartStripe.UseVisualStyleBackColor = true;
            this.chkStartStripe.CheckedChanged += new System.EventHandler(this.chkStartStripe_CheckedChanged);
            // 
            // chkEndStripe
            // 
            this.chkEndStripe.AutoSize = true;
            this.chkEndStripe.Checked = true;
            this.chkEndStripe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEndStripe.Location = new System.Drawing.Point(6, 65);
            this.chkEndStripe.Name = "chkEndStripe";
            this.chkEndStripe.Size = new System.Drawing.Size(119, 21);
            this.chkEndStripe.TabIndex = 3;
            this.chkEndStripe.Text = "End On Stripe";
            this.chkEndStripe.UseVisualStyleBackColor = true;
            this.chkEndStripe.CheckedChanged += new System.EventHandler(this.chkEndStripe_CheckedChanged);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(3, 127);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(212, 37);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // slStripeSpacing
            // 
            this.slStripeSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slStripeSpacing.LargeChange = 10;
            this.slStripeSpacing.Location = new System.Drawing.Point(6, 187);
            this.slStripeSpacing.Maximum = 1000;
            this.slStripeSpacing.Name = "slStripeSpacing";
            this.slStripeSpacing.Size = new System.Drawing.Size(209, 56);
            this.slStripeSpacing.TabIndex = 6;
            this.slStripeSpacing.TickFrequency = 100;
            this.slStripeSpacing.Value = 500;
            this.slStripeSpacing.Scroll += new System.EventHandler(this.slStripeSpacing_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stripe/Space Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stripe";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Space";
            // 
            // txtStripePercent
            // 
            this.txtStripePercent.Location = new System.Drawing.Point(6, 249);
            this.txtStripePercent.Name = "txtStripePercent";
            this.txtStripePercent.Size = new System.Drawing.Size(50, 22);
            this.txtStripePercent.TabIndex = 10;
            this.txtStripePercent.Text = "50";
            this.txtStripePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStripePercent.TextChanged += new System.EventHandler(this.txtStripePercent_TextChanged);
            // 
            // txtSpacePercent
            // 
            this.txtSpacePercent.Location = new System.Drawing.Point(164, 249);
            this.txtSpacePercent.Name = "txtSpacePercent";
            this.txtSpacePercent.Size = new System.Drawing.Size(50, 22);
            this.txtSpacePercent.TabIndex = 11;
            this.txtSpacePercent.Text = "50";
            this.txtSpacePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpacePercent.TextChanged += new System.EventHandler(this.txtSpacePercent_TextChanged);
            // 
            // StripeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSpacePercent);
            this.Controls.Add(this.txtStripePercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slStripeSpacing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.chkEndStripe);
            this.Controls.Add(this.chkStartStripe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numStripes);
            this.Name = "StripeEditor";
            this.Size = new System.Drawing.Size(218, 281);
            this.Load += new System.EventHandler(this.StripeEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStripes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slStripeSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStripes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStartStripe;
        private System.Windows.Forms.CheckBox chkEndStripe;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slStripeSpacing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStripePercent;
        private System.Windows.Forms.TextBox txtSpacePercent;
    }
}
