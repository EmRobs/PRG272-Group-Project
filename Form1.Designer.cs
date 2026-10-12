namespace Rehabilitation_Records_System
{
    partial class RehabilitationForm
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformation.Controls.Add(this.label1);
            this.pnlInformation.Controls.Add(this.txtScore);
            this.pnlInformation.Controls.Add(this.lblAge);
            this.pnlInformation.Controls.Add(this.txtAge);
            this.pnlInformation.Controls.Add(this.txtSpecies);
            this.pnlInformation.Controls.Add(this.lblSpecies);
            this.pnlInformation.Controls.Add(this.lblName);
            this.pnlInformation.Controls.Add(this.txtName);
            this.pnlInformation.Controls.Add(this.lblAnimalID);
            this.pnlInformation.Controls.Add(this.txtAnimalID);
            this.pnlInformation.Location = new System.Drawing.Point(31, 57);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(205, 343);
            this.pnlInformation.TabIndex = 0;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(16, 39);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(117, 20);
            this.txtAnimalID.TabIndex = 0;
            this.txtAnimalID.Text = "Example: WR-0000";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(16, 23);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(80, 13);
            this.lblAnimalID.TabIndex = 1;
            this.lblAnimalID.Text = "Enter Animal ID";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(83, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(93, 18);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Example: Fluffy";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(15, 151);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(73, 13);
            this.lblSpecies.TabIndex = 4;
            this.lblSpecies.Text = "Enter Species";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(17, 167);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(117, 20);
            this.txtSpecies.TabIndex = 5;
            this.txtSpecies.Text = "Example: Dog";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(18, 231);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(117, 20);
            this.txtAge.TabIndex = 6;
            this.txtAge.Text = "Example: 2";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 215);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(96, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Enter Age In Years";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(18, 298);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(117, 20);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Example: 0-100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Recovery Score";
            // 
            // RehabilitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 465);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlInformation);
            this.Name = "RehabilitationForm";
            this.Text = "Rehabilitation Records System";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label1;
    }
}

