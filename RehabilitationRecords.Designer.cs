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
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblControls = new System.Windows.Forms.Label();
            this.pnlInformation.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlControls.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Recovery Score:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(18, 305);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(117, 20);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Example: 0-100";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 222);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(99, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Enter Age In Years:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(18, 238);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(117, 20);
            this.txtAge.TabIndex = 6;
            this.txtAge.Text = "Example: 2";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(17, 174);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(117, 20);
            this.txtSpecies.TabIndex = 5;
            this.txtSpecies.Text = "Example: Dog";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(15, 158);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(76, 13);
            this.lblSpecies.TabIndex = 4;
            this.lblSpecies.Text = "Enter Species:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Example: Fluffy";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(16, 30);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(83, 13);
            this.lblAnimalID.TabIndex = 1;
            this.lblAnimalID.Text = "Enter Animal ID:";
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(16, 46);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(117, 20);
            this.txtAnimalID.TabIndex = 0;
            this.txtAnimalID.Text = "Example: WR-0000";
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
            // pnlDGV
            // 
            this.pnlDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDGV.Controls.Add(this.dataGridView1);
            this.pnlDGV.Controls.Add(this.btnSearch);
            this.pnlDGV.Controls.Add(this.txtSearchID);
            this.pnlDGV.Controls.Add(this.lblSearchID);
            this.pnlDGV.Location = new System.Drawing.Point(268, 57);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(463, 188);
            this.pnlDGV.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(265, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(105, 12);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(150, 20);
            this.txtSearchID.TabIndex = 2;
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Location = new System.Drawing.Point(14, 15);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(92, 13);
            this.lblSearchID.TabIndex = 1;
            this.lblSearchID.Text = "Search Animal ID:";
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
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Location = new System.Drawing.Point(268, 264);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(462, 150);
            this.pnlControls.TabIndex = 4;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(187, 102);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(98, 26);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(322, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // RehabilitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 454);
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
            this.pnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlControls.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.Button btnClear;
    }
}

