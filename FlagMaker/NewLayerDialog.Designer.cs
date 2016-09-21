namespace FlagMaker
{
    partial class NewLayerDialog
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
            this.btnHorizontalStripe = new System.Windows.Forms.Button();
            this.btnVerticalStripes = new System.Windows.Forms.Button();
            this.btnOval = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.btnDiagonalStripe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHorizontalStripe
            // 
            this.btnHorizontalStripe.Image = global::FlagMaker.Properties.Resources.HStripe;
            this.btnHorizontalStripe.Location = new System.Drawing.Point(12, 12);
            this.btnHorizontalStripe.Name = "btnHorizontalStripe";
            this.btnHorizontalStripe.Size = new System.Drawing.Size(160, 160);
            this.btnHorizontalStripe.TabIndex = 0;
            this.btnHorizontalStripe.Text = "Horizontal Stripes";
            this.btnHorizontalStripe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHorizontalStripe.UseVisualStyleBackColor = true;
            this.btnHorizontalStripe.Click += new System.EventHandler(this.btnHorizontalStripe_Click);
            // 
            // btnVerticalStripes
            // 
            this.btnVerticalStripes.Image = global::FlagMaker.Properties.Resources.VStripe;
            this.btnVerticalStripes.Location = new System.Drawing.Point(178, 12);
            this.btnVerticalStripes.Name = "btnVerticalStripes";
            this.btnVerticalStripes.Size = new System.Drawing.Size(160, 160);
            this.btnVerticalStripes.TabIndex = 1;
            this.btnVerticalStripes.Text = "Vertical Stripes";
            this.btnVerticalStripes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerticalStripes.UseVisualStyleBackColor = true;
            this.btnVerticalStripes.Click += new System.EventHandler(this.btnVerticalStripes_Click);
            // 
            // btnOval
            // 
            this.btnOval.Image = global::FlagMaker.Properties.Resources.Oval;
            this.btnOval.Location = new System.Drawing.Point(178, 178);
            this.btnOval.Name = "btnOval";
            this.btnOval.Size = new System.Drawing.Size(160, 160);
            this.btnOval.TabIndex = 3;
            this.btnOval.Text = "Oval";
            this.btnOval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOval.UseVisualStyleBackColor = true;
            this.btnOval.Click += new System.EventHandler(this.btnOval_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::FlagMaker.Properties.Resources.Rect;
            this.btnRectangle.Location = new System.Drawing.Point(12, 178);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(160, 160);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnDiamond
            // 
            this.btnDiamond.Image = global::FlagMaker.Properties.Resources.Diamond;
            this.btnDiamond.Location = new System.Drawing.Point(344, 178);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(160, 160);
            this.btnDiamond.TabIndex = 5;
            this.btnDiamond.Text = "Diamond";
            this.btnDiamond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiamond.UseVisualStyleBackColor = true;
            this.btnDiamond.Click += new System.EventHandler(this.btnDiamond_Click);
            // 
            // btnDiagonalStripe
            // 
            this.btnDiagonalStripe.Image = global::FlagMaker.Properties.Resources.DStripe;
            this.btnDiagonalStripe.Location = new System.Drawing.Point(344, 12);
            this.btnDiagonalStripe.Name = "btnDiagonalStripe";
            this.btnDiagonalStripe.Size = new System.Drawing.Size(160, 160);
            this.btnDiagonalStripe.TabIndex = 4;
            this.btnDiagonalStripe.Text = "Diagonal Stripe";
            this.btnDiagonalStripe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDiagonalStripe.UseVisualStyleBackColor = true;
            this.btnDiagonalStripe.Click += new System.EventHandler(this.btnDiagonalStripe_Click);
            // 
            // NewLayerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 350);
            this.Controls.Add(this.btnDiamond);
            this.Controls.Add(this.btnDiagonalStripe);
            this.Controls.Add(this.btnOval);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnVerticalStripes);
            this.Controls.Add(this.btnHorizontalStripe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewLayerDialog";
            this.Text = "Add New Layer";
            this.Load += new System.EventHandler(this.NewLayerDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHorizontalStripe;
        private System.Windows.Forms.Button btnVerticalStripes;
        private System.Windows.Forms.Button btnOval;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnDiamond;
        private System.Windows.Forms.Button btnDiagonalStripe;
    }
}