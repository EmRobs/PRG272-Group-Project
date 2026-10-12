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
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblControls = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.pnlInformation.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlInformation.Size = new System.Drawing.Size(205, 357);
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
            this.lblAnimalID.Size = new System.Drawing.Size(83, 13);
            this.lblAnimalID.TabIndex = 1;
            this.lblAnimalID.Text = "Enter Animal ID:";
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
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(15, 151);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(76, 13);
            this.lblSpecies.TabIndex = 4;
            this.lblSpecies.Text = "Enter Species:";
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
            this.lblAge.Size = new System.Drawing.Size(99, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Enter Age In Years:";
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
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Recovery Score:";
            // 
            // pnlDGV
            // 
            this.pnlDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDGV.Controls.Add(this.dataGridView1);
            this.pnlDGV.Location = new System.Drawing.Point(268, 57);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(463, 188);
            this.pnlDGV.TabIndex = 2;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(475, 46);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(72, 18);
            this.lblRecords.TabIndex = 3;
            this.lblRecords.Text = "Records";
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControls.Controls.Add(this.btnSummary);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnViewAll);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Location = new System.Drawing.Point(268, 264);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(462, 150);
            this.pnlControls.TabIndex = 4;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.Location = new System.Drawing.Point(470, 254);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(73, 18);
            this.lblControls.TabIndex = 5;
            this.lblControls.Text = "Controls";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(187, 62);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(98, 26);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All Animals";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Animal";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Animal";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(187, 102);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(98, 26);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // RehabilitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(747, 443);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.pnlDGV);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlInformation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RehabilitationForm";
            this.Text = "Rehabilitation Records System";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlDGV.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnDelete;
    }
}

