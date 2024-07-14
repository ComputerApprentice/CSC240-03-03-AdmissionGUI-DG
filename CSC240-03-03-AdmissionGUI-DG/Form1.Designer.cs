namespace CSC240_03_03_AdmissionGUI_DG
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

            this.lblGradePoint = new System.Windows.Forms.Label();

            this.txtGradeAverage = new System.Windows.Forms.TextBox();

            this.txtTestScore = new System.Windows.Forms.TextBox();

            this.lblTestScore = new System.Windows.Forms.Label();

            this.lblTotalAccepted = new System.Windows.Forms.Label();

            this.lblTotalRejected = new System.Windows.Forms.Label();

            this.btnSubmit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            //

            // lblGradePoint

            //

            this.lblGradePoint.AutoSize = true;

            this.lblGradePoint.Location = new System.Drawing.Point(126, 79);

            this.lblGradePoint.Name = "lblGradePoint";

            this.lblGradePoint.Size = new System.Drawing.Size(157, 20);

            this.lblGradePoint.TabIndex = 0;

            this.lblGradePoint.Text = "Grade Point Average";

            //

            // txtGradeAverage

            //

            this.txtGradeAverage.Location = new System.Drawing.Point(323, 79);

            this.txtGradeAverage.Name = "txtGradeAverage";

            this.txtGradeAverage.Size = new System.Drawing.Size(204, 26);

            this.txtGradeAverage.TabIndex = 1;

            //

            // txtTestScore

            //

            this.txtTestScore.Location = new System.Drawing.Point(323, 155);

            this.txtTestScore.Name = "txtTestScore";

            this.txtTestScore.Size = new System.Drawing.Size(204, 26);

            this.txtTestScore.TabIndex = 3;

            //

            // lblTestScore

            //

            this.lblTestScore.AutoSize = true;

            this.lblTestScore.Location = new System.Drawing.Point(197, 155);

            this.lblTestScore.Name = "lblTestScore";

            this.lblTestScore.Size = new System.Drawing.Size(86, 20);

            this.lblTestScore.TabIndex = 2;

            this.lblTestScore.Text = "Test Score";

            //

            // lblTotalAccepted

            //

            this.lblTotalAccepted.AutoSize = true;

            this.lblTotalAccepted.Location = new System.Drawing.Point(130, 233);

            this.lblTotalAccepted.Name = "lblTotalAccepted";

            this.lblTotalAccepted.Size = new System.Drawing.Size(133, 20);

            this.lblTotalAccepted.TabIndex = 4;

            this.lblTotalAccepted.Text = "Total Accepted: 0";

            //

            // lblTotalRejected

            //

            this.lblTotalRejected.AutoSize = true;

            this.lblTotalRejected.Location = new System.Drawing.Point(384, 233);

            this.lblTotalRejected.Name = "lblTotalRejected";

            this.lblTotalRejected.Size = new System.Drawing.Size(129, 20);

            this.lblTotalRejected.TabIndex = 5;

            this.lblTotalRejected.Text = "Total Rejected: 0";

            //

            // btnSubmit

            //

            this.btnSubmit.Location = new System.Drawing.Point(388, 305);

            this.btnSubmit.Name = "btnSubmit";

            this.btnSubmit.Size = new System.Drawing.Size(139, 37);

            this.btnSubmit.TabIndex = 6;

            this.btnSubmit.Text = "Submit";

            this.btnSubmit.UseVisualStyleBackColor = true;

            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            //

            // Form1

            //

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(573, 385);

            this.Controls.Add(this.btnSubmit);

            this.Controls.Add(this.lblTotalRejected);

            this.Controls.Add(this.lblTotalAccepted);

            this.Controls.Add(this.txtTestScore);

            this.Controls.Add(this.lblTestScore);

            this.Controls.Add(this.txtGradeAverage);

            this.Controls.Add(this.lblGradePoint);

            this.MaximizeBox = false;

            this.MinimizeBox = false;

            this.Name = "Form1";

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Admission Decider";

            this.ResumeLayout(false);

            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradePoint;

        private System.Windows.Forms.TextBox txtGradeAverage;

        private System.Windows.Forms.TextBox txtTestScore;

        private System.Windows.Forms.Label lblTestScore;

        private System.Windows.Forms.Label lblTotalAccepted;

        private System.Windows.Forms.Label lblTotalRejected;

        private System.Windows.Forms.Button btnSubmit;

    }

}
