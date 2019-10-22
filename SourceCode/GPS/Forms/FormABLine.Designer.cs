﻿namespace AgOpenGPS
{
    partial class FormABLine
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFixHeading = new System.Windows.Forms.Label();
            this.lblKeepGoing = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBasedOnPass = new System.Windows.Forms.NumericUpDown();
            this.nudTramRepeats = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxHeading = new System.Windows.Forms.TextBox();
            this.btnDnABHeadingBy1 = new System.Windows.Forms.Button();
            this.btnUpABHeadingBy1 = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.tboxABLineName = new System.Windows.Forms.TextBox();
            this.lvLines = new System.Windows.Forms.ListView();
            this.chField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAndGo = new System.Windows.Forms.Button();
            this.btnNewABLine = new System.Windows.Forms.Button();
            this.btnListUse = new System.Windows.Forms.Button();
            this.btnListDelete = new System.Windows.Forms.Button();
            this.btnAddToFile = new System.Windows.Forms.Button();
            this.btnTurnOffAB = new System.Windows.Forms.Button();
            this.btnBPoint = new System.Windows.Forms.Button();
            this.btnAPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFixHeading
            // 
            this.lblFixHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFixHeading.AutoSize = true;
            this.lblFixHeading.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblFixHeading.Location = new System.Drawing.Point(379, 3);
            this.lblFixHeading.Name = "lblFixHeading";
            this.lblFixHeading.Size = new System.Drawing.Size(32, 33);
            this.lblFixHeading.TabIndex = 64;
            this.lblFixHeading.Text = "0";
            // 
            // lblKeepGoing
            // 
            this.lblKeepGoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeepGoing.AutoSize = true;
            this.lblKeepGoing.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblKeepGoing.Location = new System.Drawing.Point(533, 6);
            this.lblKeepGoing.Name = "lblKeepGoing";
            this.lblKeepGoing.Size = new System.Drawing.Size(22, 25);
            this.lblKeepGoing.TabIndex = 74;
            this.lblKeepGoing.Text = "?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(154, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Repeats";
            // 
            // nudBasedOnPass
            // 
            this.nudBasedOnPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudBasedOnPass.BackColor = System.Drawing.Color.MediumOrchid;
            this.nudBasedOnPass.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBasedOnPass.Location = new System.Drawing.Point(70, 389);
            this.nudBasedOnPass.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBasedOnPass.Name = "nudBasedOnPass";
            this.nudBasedOnPass.Size = new System.Drawing.Size(67, 52);
            this.nudBasedOnPass.TabIndex = 77;
            this.nudBasedOnPass.ValueChanged += new System.EventHandler(this.nudBasedOnPass_ValueChanged);
            // 
            // nudTramRepeats
            // 
            this.nudTramRepeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudTramRepeats.BackColor = System.Drawing.Color.Lime;
            this.nudTramRepeats.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTramRepeats.Location = new System.Drawing.Point(224, 389);
            this.nudTramRepeats.Name = "nudTramRepeats";
            this.nudTramRepeats.Size = new System.Drawing.Size(67, 52);
            this.nudTramRepeats.TabIndex = 75;
            this.nudTramRepeats.ValueChanged += new System.EventHandler(this.nudTramRepeats_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(-67, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Start";
            // 
            // tboxHeading
            // 
            this.tboxHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxHeading.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxHeading.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.tboxHeading.Location = new System.Drawing.Point(379, 142);
            this.tboxHeading.MaxLength = 10;
            this.tboxHeading.Name = "tboxHeading";
            this.tboxHeading.Size = new System.Drawing.Size(185, 43);
            this.tboxHeading.TabIndex = 83;
            this.tboxHeading.Text = "359.123456";
            this.tboxHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxHeading.TextChanged += new System.EventHandler(this.tboxHeading_TextChanged);
            this.tboxHeading.Enter += new System.EventHandler(this.TboxHeading_Enter);
            // 
            // btnDnABHeadingBy1
            // 
            this.btnDnABHeadingBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDnABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDnABHeadingBy1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDnABHeadingBy1.Location = new System.Drawing.Point(484, 202);
            this.btnDnABHeadingBy1.Name = "btnDnABHeadingBy1";
            this.btnDnABHeadingBy1.Size = new System.Drawing.Size(80, 51);
            this.btnDnABHeadingBy1.TabIndex = 73;
            this.btnDnABHeadingBy1.Text = "+0.1";
            this.btnDnABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnDnABHeadingBy1.Click += new System.EventHandler(this.BtnDnABHeadingBy1_Click);
            // 
            // btnUpABHeadingBy1
            // 
            this.btnUpABHeadingBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpABHeadingBy1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpABHeadingBy1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpABHeadingBy1.Location = new System.Drawing.Point(377, 202);
            this.btnUpABHeadingBy1.Name = "btnUpABHeadingBy1";
            this.btnUpABHeadingBy1.Size = new System.Drawing.Size(80, 51);
            this.btnUpABHeadingBy1.TabIndex = 72;
            this.btnUpABHeadingBy1.Text = "-0.1";
            this.btnUpABHeadingBy1.UseVisualStyleBackColor = true;
            this.btnUpABHeadingBy1.Click += new System.EventHandler(this.BtnUpABHeadingBy1_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(108, 8);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(246, 61);
            this.lblEnterName.TabIndex = 151;
            this.lblEnterName.Text = "Enter Line Name";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterName.Visible = false;
            // 
            // tboxABLineName
            // 
            this.tboxABLineName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxABLineName.Location = new System.Drawing.Point(104, 72);
            this.tboxABLineName.Name = "tboxABLineName";
            this.tboxABLineName.Size = new System.Drawing.Size(255, 33);
            this.tboxABLineName.TabIndex = 152;
            this.tboxABLineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxABLineName.Enter += new System.EventHandler(this.tboxABLineName_Enter);
            // 
            // lvLines
            // 
            this.lvLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chField});
            this.lvLines.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLines.FullRowSelect = true;
            this.lvLines.GridLines = true;
            this.lvLines.HideSelection = false;
            this.lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvLines.LabelWrap = false;
            this.lvLines.Location = new System.Drawing.Point(104, 117);
            this.lvLines.Margin = new System.Windows.Forms.Padding(0);
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Size = new System.Drawing.Size(255, 245);
            this.lvLines.TabIndex = 153;
            this.lvLines.TileSize = new System.Drawing.Size(240, 40);
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Tile;
            this.lvLines.Visible = false;
            this.lvLines.SelectedIndexChanged += new System.EventHandler(this.lvLines_SelectedIndexChanged);
            // 
            // chField
            // 
            this.chField.Text = "CurveLines";
            this.chField.Width = 239;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(13, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 154;
            this.label1.Text = "Skips";
            // 
            // btnAddAndGo
            // 
            this.btnAddAndGo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAndGo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAndGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAndGo.Image = global::AgOpenGPS.Properties.Resources.FileNewAndGo;
            this.btnAddAndGo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAndGo.Location = new System.Drawing.Point(7, 6);
            this.btnAddAndGo.Name = "btnAddAndGo";
            this.btnAddAndGo.Size = new System.Drawing.Size(78, 74);
            this.btnAddAndGo.TabIndex = 155;
            this.btnAddAndGo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAndGo.UseVisualStyleBackColor = false;
            this.btnAddAndGo.Click += new System.EventHandler(this.btnAddAndGo_Click);
            // 
            // btnNewABLine
            // 
            this.btnNewABLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewABLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewABLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewABLine.Image = global::AgOpenGPS.Properties.Resources.AddNew;
            this.btnNewABLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewABLine.Location = new System.Drawing.Point(484, 282);
            this.btnNewABLine.Name = "btnNewABLine";
            this.btnNewABLine.Size = new System.Drawing.Size(80, 80);
            this.btnNewABLine.TabIndex = 149;
            this.btnNewABLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewABLine.UseVisualStyleBackColor = false;
            this.btnNewABLine.Click += new System.EventHandler(this.BtnNewABLine_Click);
            // 
            // btnListUse
            // 
            this.btnListUse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnListUse.Image = global::AgOpenGPS.Properties.Resources.FileUse;
            this.btnListUse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListUse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnListUse.Location = new System.Drawing.Point(7, 291);
            this.btnListUse.Name = "btnListUse";
            this.btnListUse.Size = new System.Drawing.Size(78, 74);
            this.btnListUse.TabIndex = 86;
            this.btnListUse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListUse.UseVisualStyleBackColor = true;
            this.btnListUse.Click += new System.EventHandler(this.btnListUse_Click);
            // 
            // btnListDelete
            // 
            this.btnListDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnListDelete.Image = global::AgOpenGPS.Properties.Resources.FileDelete;
            this.btnListDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListDelete.Location = new System.Drawing.Point(7, 187);
            this.btnListDelete.Name = "btnListDelete";
            this.btnListDelete.Size = new System.Drawing.Size(78, 74);
            this.btnListDelete.TabIndex = 85;
            this.btnListDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListDelete.UseVisualStyleBackColor = true;
            this.btnListDelete.Click += new System.EventHandler(this.btnListDelete_Click);
            // 
            // btnAddToFile
            // 
            this.btnAddToFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToFile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddToFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToFile.Image = global::AgOpenGPS.Properties.Resources.FileNew;
            this.btnAddToFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddToFile.Location = new System.Drawing.Point(7, 82);
            this.btnAddToFile.Name = "btnAddToFile";
            this.btnAddToFile.Size = new System.Drawing.Size(78, 74);
            this.btnAddToFile.TabIndex = 82;
            this.btnAddToFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToFile.UseVisualStyleBackColor = false;
            this.btnAddToFile.Click += new System.EventHandler(this.btnAddToFile_Click);
            // 
            // btnTurnOffAB
            // 
            this.btnTurnOffAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurnOffAB.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnOffAB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTurnOffAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTurnOffAB.Image = global::AgOpenGPS.Properties.Resources.SwitchOff;
            this.btnTurnOffAB.Location = new System.Drawing.Point(377, 282);
            this.btnTurnOffAB.Name = "btnTurnOffAB";
            this.btnTurnOffAB.Size = new System.Drawing.Size(80, 80);
            this.btnTurnOffAB.TabIndex = 0;
            this.btnTurnOffAB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurnOffAB.UseVisualStyleBackColor = false;
            this.btnTurnOffAB.Click += new System.EventHandler(this.btnTurnOffAB_Click);
            // 
            // btnBPoint
            // 
            this.btnBPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBPoint.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnBPoint.Image = global::AgOpenGPS.Properties.Resources.LetterBBlue;
            this.btnBPoint.Location = new System.Drawing.Point(484, 38);
            this.btnBPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBPoint.Name = "btnBPoint";
            this.btnBPoint.Size = new System.Drawing.Size(80, 80);
            this.btnBPoint.TabIndex = 58;
            this.btnBPoint.UseVisualStyleBackColor = true;
            this.btnBPoint.Click += new System.EventHandler(this.btnBPoint_Click);
            // 
            // btnAPoint
            // 
            this.btnAPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAPoint.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAPoint.Image = global::AgOpenGPS.Properties.Resources.LetterABlue;
            this.btnAPoint.Location = new System.Drawing.Point(377, 38);
            this.btnAPoint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAPoint.Name = "btnAPoint";
            this.btnAPoint.Size = new System.Drawing.Size(80, 80);
            this.btnAPoint.TabIndex = 57;
            this.btnAPoint.UseVisualStyleBackColor = true;
            this.btnAPoint.Click += new System.EventHandler(this.btnAPoint_Click);
            // 
            // FormABLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(572, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddAndGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLines);
            this.Controls.Add(this.tboxABLineName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.btnNewABLine);
            this.Controls.Add(this.lblFixHeading);
            this.Controls.Add(this.btnListUse);
            this.Controls.Add(this.btnListDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTramRepeats);
            this.Controls.Add(this.tboxHeading);
            this.Controls.Add(this.nudBasedOnPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToFile);
            this.Controls.Add(this.lblKeepGoing);
            this.Controls.Add(this.btnDnABHeadingBy1);
            this.Controls.Add(this.btnUpABHeadingBy1);
            this.Controls.Add(this.btnTurnOffAB);
            this.Controls.Add(this.btnBPoint);
            this.Controls.Add(this.btnAPoint);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormABLine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AB Line";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormABLine_FormClosing);
            this.Load += new System.EventHandler(this.FormABLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBasedOnPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRepeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnOffAB;
        private System.Windows.Forms.Button btnBPoint;
        private System.Windows.Forms.Button btnAPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFixHeading;
        private System.Windows.Forms.Label lblKeepGoing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBasedOnPass;
        private System.Windows.Forms.NumericUpDown nudTramRepeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddToFile;
        private System.Windows.Forms.TextBox tboxHeading;
        private System.Windows.Forms.Button btnListDelete;
        private System.Windows.Forms.Button btnListUse;
        private System.Windows.Forms.Button btnDnABHeadingBy1;
        private System.Windows.Forms.Button btnUpABHeadingBy1;
        private System.Windows.Forms.Button btnNewABLine;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox tboxABLineName;
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAndGo;
    }
}