namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            btnInsert = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvKaryawan = new DataGridView();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            cbDep = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 79);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 108);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan : ";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(131, 76);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 23);
            tbNama.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(31, 145);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(177, 145);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(297, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(12, 193);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowTemplate.Height = 25;
            dgvKaryawan.Size = new Size(374, 245);
            dgvKaryawan.TabIndex = 7;
            dgvKaryawan.CellContentClick += dgvKaryawan_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 30);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "logo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 38);
            label4.Name = "label4";
            label4.Size = new Size(89, 90);
            label4.TabIndex = 10;
            label4.Text = "ID Departemen:\r\nHR: HR\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product M\r\nFIN: Finance\r\n";
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(131, 105);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(121, 23);
            cbDep.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(cbDep);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private Button btnInsert;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvKaryawan;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private ComboBox cbDep;
    }
}