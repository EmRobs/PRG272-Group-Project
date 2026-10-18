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
            pnlInformation = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtScore = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            txtSpecies = new System.Windows.Forms.TextBox();
            lblSpecies = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblAnimalID = new System.Windows.Forms.Label();
            txtAnimalID = new System.Windows.Forms.TextBox();
            lblInfo = new System.Windows.Forms.Label();
            pnlDGV = new System.Windows.Forms.Panel();
            dgvAnimals = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            txtSearchID = new System.Windows.Forms.TextBox();
            lblSearchID = new System.Windows.Forms.Label();
            lblRecords = new System.Windows.Forms.Label();
            pnlControls = new System.Windows.Forms.Panel();
            btnSummary = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnViewAll = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            lblControls = new System.Windows.Forms.Label();
            pnlInformation.SuspendLayout();
            pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(txtScore);
            pnlInformation.Controls.Add(lblAge);
            pnlInformation.Controls.Add(txtAge);
            pnlInformation.Controls.Add(txtSpecies);
            pnlInformation.Controls.Add(lblSpecies);
            pnlInformation.Controls.Add(lblName);
            pnlInformation.Controls.Add(txtName);
            pnlInformation.Controls.Add(lblAnimalID);
            pnlInformation.Controls.Add(txtAnimalID);
            pnlInformation.Location = new System.Drawing.Point(36, 66);
            pnlInformation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new System.Drawing.Size(238, 411);
            pnlInformation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 333);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 15);
            label1.TabIndex = 9;
            label1.Text = "Enter Recovery Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new System.Drawing.Point(21, 352);
            txtScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtScore.Name = "txtScore";
            txtScore.Size = new System.Drawing.Size(136, 23);
            txtScore.TabIndex = 8;
            txtScore.Text = "Example: 0-100";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(18, 256);
            lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(104, 15);
            lblAge.TabIndex = 7;
            lblAge.Text = "Enter Age In Years:";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(21, 275);
            txtAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(136, 23);
            txtAge.TabIndex = 6;
            txtAge.Text = "Example: 2";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new System.Drawing.Point(20, 201);
            txtSpecies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new System.Drawing.Size(136, 23);
            txtSpecies.TabIndex = 5;
            txtSpecies.Text = "Example: Dog";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new System.Drawing.Point(18, 182);
            lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new System.Drawing.Size(79, 15);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Enter Species:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(18, 107);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(72, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Enter Name:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(20, 126);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(136, 23);
            txtName.TabIndex = 2;
            txtName.Text = "Example: Fluffy";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new System.Drawing.Point(19, 35);
            lblAnimalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new System.Drawing.Size(92, 15);
            lblAnimalID.TabIndex = 1;
            lblAnimalID.Text = "Enter Animal ID:";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new System.Drawing.Point(19, 53);
            txtAnimalID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new System.Drawing.Size(136, 23);
            txtAnimalID.TabIndex = 0;
            txtAnimalID.Text = "Example: WR-0000";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblInfo.Location = new System.Drawing.Point(97, 53);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(93, 18);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Information";
            // 
            // pnlDGV
            // 
            pnlDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlDGV.Controls.Add(dgvAnimals);
            pnlDGV.Controls.Add(btnSearch);
            pnlDGV.Controls.Add(txtSearchID);
            pnlDGV.Controls.Add(lblSearchID);
            pnlDGV.Location = new System.Drawing.Point(313, 66);
            pnlDGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDGV.Name = "pnlDGV";
            pnlDGV.Size = new System.Drawing.Size(540, 216);
            pnlDGV.TabIndex = 2;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AllowUserToOrderColumns = true;
            dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new System.Drawing.Point(20, 48);
            dgvAnimals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new System.Drawing.Size(504, 144);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellClick += dataGridView1_CellClick;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(309, 12);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(88, 28);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new System.Drawing.Point(122, 14);
            txtSearchID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new System.Drawing.Size(174, 23);
            txtSearchID.TabIndex = 2;
            // 
            // lblSearchID
            // 
            lblSearchID.AutoSize = true;
            lblSearchID.Location = new System.Drawing.Point(16, 17);
            lblSearchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearchID.Name = "lblSearchID";
            lblSearchID.Size = new System.Drawing.Size(100, 15);
            lblSearchID.TabIndex = 1;
            lblSearchID.Text = "Search Animal ID:";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblRecords.Location = new System.Drawing.Point(554, 53);
            lblRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new System.Drawing.Size(72, 18);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "Records";
            // 
            // pnlControls
            // 
            pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlControls.Controls.Add(btnSummary);
            pnlControls.Controls.Add(btnDelete);
            pnlControls.Controls.Add(btnUpdate);
            pnlControls.Controls.Add(btnViewAll);
            pnlControls.Controls.Add(btnAdd);
            pnlControls.Controls.Add(btnClear);
            pnlControls.Location = new System.Drawing.Point(313, 305);
            pnlControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new System.Drawing.Size(538, 172);
            pnlControls.TabIndex = 4;
            // 
            // btnSummary
            // 
            btnSummary.Location = new System.Drawing.Point(218, 118);
            btnSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new System.Drawing.Size(114, 30);
            btnSummary.TabIndex = 4;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(218, 21);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(114, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new System.Drawing.Point(376, 72);
            btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(114, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Save Changes";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new System.Drawing.Point(218, 72);
            btnViewAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new System.Drawing.Size(114, 30);
            btnViewAll.TabIndex = 1;
            btnViewAll.Text = "View All Animals";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(62, 72);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(114, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(376, 21);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(114, 30);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblControls
            // 
            lblControls.AutoSize = true;
            lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblControls.Location = new System.Drawing.Point(548, 293);
            lblControls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblControls.Name = "lblControls";
            lblControls.Size = new System.Drawing.Size(73, 18);
            lblControls.TabIndex = 5;
            lblControls.Text = "Controls";
            // 
            // RehabilitationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(887, 524);
            Controls.Add(lblControls);
            Controls.Add(pnlControls);
            Controls.Add(lblRecords);
            Controls.Add(pnlDGV);
            Controls.Add(lblInfo);
            Controls.Add(pnlInformation);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RehabilitationForm";
            Text = "Rehabilitation Records System";
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            pnlDGV.ResumeLayout(false);
            pnlDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            pnlControls.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.DataGridView dgvAnimals;
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

