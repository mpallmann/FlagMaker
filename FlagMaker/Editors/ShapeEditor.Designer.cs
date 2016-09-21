namespace FlagMaker
{
    partial class ShapeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sldX = new System.Windows.Forms.TrackBar();
            this.sldY = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddPoint = new System.Windows.Forms.ToolStripButton();
            this.btnRemovePoint = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOrder = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sldX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldY)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Location = new System.Drawing.Point(3, 231);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(189, 43);
            this.btnColor.TabIndex = 11;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lstPoints
            // 
            this.lstPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.IntegralHeight = false;
            this.lstPoints.ItemHeight = 16;
            this.lstPoints.Location = new System.Drawing.Point(3, 30);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(189, 113);
            this.lstPoints.TabIndex = 13;
            this.lstPoints.SelectedIndexChanged += new System.EventHandler(this.lstPoints_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sldX
            // 
            this.sldX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sldX.AutoSize = false;
            this.sldX.Location = new System.Drawing.Point(26, 149);
            this.sldX.Maximum = 1000;
            this.sldX.Name = "sldX";
            this.sldX.Size = new System.Drawing.Size(166, 31);
            this.sldX.TabIndex = 15;
            this.sldX.TickFrequency = 100;
            this.sldX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldX.ValueChanged += new System.EventHandler(this.sldX_ValueChanged);
            this.sldX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sldX_MouseUp);
            // 
            // sldY
            // 
            this.sldY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sldY.AutoSize = false;
            this.sldY.Location = new System.Drawing.Point(26, 177);
            this.sldY.Maximum = 1000;
            this.sldY.Name = "sldY";
            this.sldY.Size = new System.Drawing.Size(166, 31);
            this.sldY.TabIndex = 16;
            this.sldY.TickFrequency = 100;
            this.sldY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sldY.ValueChanged += new System.EventHandler(this.sldY_ValueChanged);
            this.sldY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sldY_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.mnuOrder,
            this.sep1,
            this.btnRemovePoint,
            this.btnAddPoint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(195, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 24);
            this.toolStripLabel1.Text = "Points";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPoint.Image")));
            this.btnAddPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(23, 24);
            this.btnAddPoint.Text = "+";
            this.btnAddPoint.Visible = false;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRemovePoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemovePoint.Font = new System.Drawing.Font("Marlett", 9F);
            this.btnRemovePoint.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePoint.Image")));
            this.btnRemovePoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(26, 24);
            this.btnRemovePoint.Text = "r";
            this.btnRemovePoint.Visible = false;
            this.btnRemovePoint.Click += new System.EventHandler(this.btnRemovePoint_Click);
            // 
            // sep1
            // 
            this.sep1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 27);
            this.sep1.Visible = false;
            // 
            // mnuOrder
            // 
            this.mnuOrder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveUp,
            this.btnMoveDown});
            this.mnuOrder.Font = new System.Drawing.Font("Marlett", 9F);
            this.mnuOrder.Image = ((System.Drawing.Image)(resources.GetObject("mnuOrder.Image")));
            this.mnuOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(36, 24);
            this.mnuOrder.Text = "v";
            this.mnuOrder.Visible = false;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(181, 26);
            this.btnMoveUp.Text = "t";
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(181, 26);
            this.btnMoveDown.Text = "u";
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // ShapeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sldY);
            this.Controls.Add(this.sldX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPoints);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ShapeEditor";
            this.Size = new System.Drawing.Size(195, 279);
            this.Load += new System.EventHandler(this.ShapeEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sldX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sldY)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar sldX;
        private System.Windows.Forms.TrackBar sldY;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnAddPoint;
        private System.Windows.Forms.ToolStripButton btnRemovePoint;
        private System.Windows.Forms.ToolStripDropDownButton mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem btnMoveUp;
        private System.Windows.Forms.ToolStripMenuItem btnMoveDown;
        private System.Windows.Forms.ToolStripSeparator sep1;
    }
}
