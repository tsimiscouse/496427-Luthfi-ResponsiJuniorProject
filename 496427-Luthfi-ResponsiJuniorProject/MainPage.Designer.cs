namespace _496427_Luthfi_ResponsiJuniorProject
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblJabatan = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.cbJabatan = new System.Windows.Forms.ComboBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.gbDep = new System.Windows.Forms.GroupBox();
            this.lblGbDep = new System.Windows.Forms.Label();
            this.gbJabatan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.gbDep.SuspendLayout();
            this.gbJabatan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(52, 149);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(104, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Karyawan";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(34, 223);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(119, 17);
            this.lblDep.TabIndex = 1;
            this.lblDep.Text = "Nama Departemen";
            // 
            // lblJabatan
            // 
            this.lblJabatan.AutoSize = true;
            this.lblJabatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJabatan.Location = new System.Drawing.Point(358, 149);
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Size = new System.Drawing.Size(114, 17);
            this.lblJabatan.TabIndex = 2;
            this.lblJabatan.Text = "Jabatan Karyawan";
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(168, 146);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(146, 25);
            this.tbNama.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Management App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cbDep
            // 
            this.cbDep.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Items.AddRange(new object[] {
            "HR",
            "FIN",
            "ENG",
            "DEV",
            "PM"});
            this.cbDep.Location = new System.Drawing.Point(168, 220);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(146, 25);
            this.cbDep.TabIndex = 9;
            // 
            // cbJabatan
            // 
            this.cbJabatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJabatan.FormattingEnabled = true;
            this.cbJabatan.Items.AddRange(new object[] {
            "MGR",
            "ASS",
            "EXP",
            "SEN",
            "JUN",
            "INT",
            "",
            ""});
            this.cbJabatan.Location = new System.Drawing.Point(478, 146);
            this.cbJabatan.Name = "cbJabatan";
            this.cbJabatan.Size = new System.Drawing.Size(146, 25);
            this.cbJabatan.TabIndex = 10;
            // 
            // dgData
            // 
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(37, 347);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(1080, 158);
            this.dgData.TabIndex = 11;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            // 
            // gbDep
            // 
            this.gbDep.Controls.Add(this.lblGbDep);
            this.gbDep.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDep.Location = new System.Drawing.Point(682, 137);
            this.gbDep.Name = "gbDep";
            this.gbDep.Size = new System.Drawing.Size(200, 121);
            this.gbDep.TabIndex = 12;
            this.gbDep.TabStop = false;
            this.gbDep.Text = "ID Departemen";
            // 
            // lblGbDep
            // 
            this.lblGbDep.AutoSize = true;
            this.lblGbDep.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGbDep.Location = new System.Drawing.Point(17, 28);
            this.lblGbDep.Name = "lblGbDep";
            this.lblGbDep.Size = new System.Drawing.Size(126, 75);
            this.lblGbDep.TabIndex = 0;
            this.lblGbDep.Text = "HR : Human Resource\r\nFIN : Finance\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product" +
    " Manager";
            // 
            // gbJabatan
            // 
            this.gbJabatan.Controls.Add(this.label1);
            this.gbJabatan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJabatan.Location = new System.Drawing.Point(917, 137);
            this.gbJabatan.Name = "gbJabatan";
            this.gbJabatan.Size = new System.Drawing.Size(200, 121);
            this.gbJabatan.TabIndex = 13;
            this.gbJabatan.TabStop = false;
            this.gbJabatan.Text = "Jabatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "MGR : Manager\r\nASS : Assistant Manager\r\nEXP : Expert\r\nSEN : Senior\r\nJUN : Junior\r" +
    "\nINT : Intern";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(517, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(196, 47);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(719, 283);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 47);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(921, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 47);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(921, 520);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(196, 47);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "LOAD DATA";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 588);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gbJabatan);
            this.Controls.Add(this.gbDep);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.cbJabatan);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lblJabatan);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblNama);
            this.Name = "MainPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.gbDep.ResumeLayout(false);
            this.gbDep.PerformLayout();
            this.gbJabatan.ResumeLayout(false);
            this.gbJabatan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblJabatan;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.ComboBox cbJabatan;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.GroupBox gbDep;
        private System.Windows.Forms.GroupBox gbJabatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGbDep;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
    }
}

