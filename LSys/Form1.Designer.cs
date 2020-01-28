namespace LSys
{
    partial class frmMain
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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.pnlProps = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTurtleTest = new System.Windows.Forms.TextBox();
            this.txtAxiom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFRepl = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.pnlProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.Location = new System.Drawing.Point(12, 12);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(510, 510);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // pnlProps
            // 
            this.pnlProps.Controls.Add(this.label6);
            this.pnlProps.Controls.Add(this.label5);
            this.pnlProps.Controls.Add(this.numIterations);
            this.pnlProps.Controls.Add(this.label4);
            this.pnlProps.Controls.Add(this.numAngle);
            this.pnlProps.Controls.Add(this.label3);
            this.pnlProps.Controls.Add(this.numLength);
            this.pnlProps.Controls.Add(this.label2);
            this.pnlProps.Controls.Add(this.txtFRepl);
            this.pnlProps.Controls.Add(this.label1);
            this.pnlProps.Controls.Add(this.txtAxiom);
            this.pnlProps.Controls.Add(this.txtTurtleTest);
            this.pnlProps.Location = new System.Drawing.Point(528, 12);
            this.pnlProps.Name = "pnlProps";
            this.pnlProps.Size = new System.Drawing.Size(228, 472);
            this.pnlProps.TabIndex = 1;
            this.pnlProps.TabStop = false;
            this.pnlProps.Text = "Properties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTurtleTest
            // 
            this.txtTurtleTest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurtleTest.Location = new System.Drawing.Point(6, 386);
            this.txtTurtleTest.Multiline = true;
            this.txtTurtleTest.Name = "txtTurtleTest";
            this.txtTurtleTest.Size = new System.Drawing.Size(216, 80);
            this.txtTurtleTest.TabIndex = 0;
            // 
            // txtAxiom
            // 
            this.txtAxiom.Location = new System.Drawing.Point(6, 37);
            this.txtAxiom.Name = "txtAxiom";
            this.txtAxiom.Size = new System.Drawing.Size(216, 20);
            this.txtAxiom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Axiom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "F-Replacement (temporary):";
            // 
            // txtFRepl
            // 
            this.txtFRepl.Location = new System.Drawing.Point(6, 81);
            this.txtFRepl.Name = "txtFRepl";
            this.txtFRepl.Size = new System.Drawing.Size(216, 20);
            this.txtFRepl.TabIndex = 3;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(6, 322);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(65, 20);
            this.numLength.TabIndex = 5;
            this.numLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Angle:";
            // 
            // numAngle
            // 
            this.numAngle.Location = new System.Drawing.Point(77, 322);
            this.numAngle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(65, 20);
            this.numAngle.TabIndex = 7;
            this.numAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Iterations:";
            // 
            // numIterations
            // 
            this.numIterations.Location = new System.Drawing.Point(148, 322);
            this.numIterations.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(65, 20);
            this.numIterations.TabIndex = 9;
            this.numIterations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Turtle instructions (test):";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlProps);
            this.Controls.Add(this.picResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Simple L-System Test";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.pnlProps.ResumeLayout(false);
            this.pnlProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.GroupBox pnlProps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTurtleTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFRepl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAxiom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIterations;
    }
}

