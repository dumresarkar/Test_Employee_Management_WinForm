namespace WinFormsApp1
{
    partial class List_of_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Emp_key_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EMP_KEY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAPTOP_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCKER_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFICIAL_MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFICIAL_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIT_USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIT_PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Details of employee:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_key_id1,
            this.FNAME,
            this.EMAIL,
            this.GENDER,
            this.CONTACT,
            this.USERNAME,
            this.PASSWORD,
            this.Column1,
            this.Delete});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(954, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Emp_key_id1
            // 
            this.Emp_key_id1.DataPropertyName = "EMP_KEY_ID";
            this.Emp_key_id1.HeaderText = "Employee ID";
            this.Emp_key_id1.Name = "Emp_key_id1";
            // 
            // FNAME
            // 
            this.FNAME.DataPropertyName = "NAME";
            this.FNAME.HeaderText = "Full Name";
            this.FNAME.Name = "FNAME";
            this.FNAME.Width = 150;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 120;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "Gender";
            this.GENDER.Name = "GENDER";
            // 
            // CONTACT
            // 
            this.CONTACT.DataPropertyName = "CONTACT";
            this.CONTACT.HeaderText = "Contact No.";
            this.CONTACT.Name = "CONTACT";
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "User Name";
            this.USERNAME.Name = "USERNAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "Password";
            this.PASSWORD.Name = "PASSWORD";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Deletion";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Official Details of employee:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMP_KEY_ID,
            this.NAME,
            this.LAPTOP_NUMBER,
            this.LOCKER_NUMBER,
            this.OFFICIAL_MAIL,
            this.OFFICIAL_PASSWORD,
            this.GIT_USERNAME,
            this.GIT_PASSWORD});
            this.dataGridView2.Location = new System.Drawing.Point(13, 394);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(954, 240);
            this.dataGridView2.TabIndex = 3;
            // 
            // EMP_KEY_ID
            // 
            this.EMP_KEY_ID.DataPropertyName = "EMP_KEY_ID";
            this.EMP_KEY_ID.HeaderText = "Employee ID";
            this.EMP_KEY_ID.Name = "EMP_KEY_ID";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Full Name";
            this.NAME.MinimumWidth = 8;
            this.NAME.Name = "NAME";
            this.NAME.Width = 150;
            // 
            // LAPTOP_NUMBER
            // 
            this.LAPTOP_NUMBER.DataPropertyName = "LAPTOP_NUMBER";
            this.LAPTOP_NUMBER.HeaderText = "Laptop No.";
            this.LAPTOP_NUMBER.Name = "LAPTOP_NUMBER";
            // 
            // LOCKER_NUMBER
            // 
            this.LOCKER_NUMBER.DataPropertyName = "LOCKER_NUMBER";
            this.LOCKER_NUMBER.HeaderText = "Locker No.";
            this.LOCKER_NUMBER.Name = "LOCKER_NUMBER";
            // 
            // OFFICIAL_MAIL
            // 
            this.OFFICIAL_MAIL.DataPropertyName = "OFFICIAL_MAIL";
            this.OFFICIAL_MAIL.HeaderText = "Official Mail";
            this.OFFICIAL_MAIL.Name = "OFFICIAL_MAIL";
            this.OFFICIAL_MAIL.Width = 150;
            // 
            // OFFICIAL_PASSWORD
            // 
            this.OFFICIAL_PASSWORD.DataPropertyName = "OFFICIAL_PASSWORD";
            this.OFFICIAL_PASSWORD.HeaderText = "Official Password";
            this.OFFICIAL_PASSWORD.Name = "OFFICIAL_PASSWORD";
            // 
            // GIT_USERNAME
            // 
            this.GIT_USERNAME.DataPropertyName = "GIT_USERNAME";
            this.GIT_USERNAME.HeaderText = "Git mail/ Username";
            this.GIT_USERNAME.Name = "GIT_USERNAME";
            this.GIT_USERNAME.Width = 110;
            // 
            // GIT_PASSWORD
            // 
            this.GIT_PASSWORD.DataPropertyName = "GIT_PASSWORD";
            this.GIT_PASSWORD.HeaderText = "Git Password";
            this.GIT_PASSWORD.Name = "GIT_PASSWORD";
            // 
            // List_of_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "List_of_Employee";
            this.Size = new System.Drawing.Size(1020, 661);
            this.Load += new System.EventHandler(this.List_of_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn EMP_KEY_ID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn LAPTOP_NUMBER;
        private DataGridViewTextBoxColumn LOCKER_NUMBER;
        private DataGridViewTextBoxColumn OFFICIAL_MAIL;
        private DataGridViewTextBoxColumn OFFICIAL_PASSWORD;
        private DataGridViewTextBoxColumn GIT_USERNAME;
        private DataGridViewTextBoxColumn GIT_PASSWORD;
        private DataGridViewTextBoxColumn Emp_key_id1;
        private DataGridViewTextBoxColumn FNAME;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn GENDER;
        private DataGridViewTextBoxColumn CONTACT;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn PASSWORD;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Delete;
    }
}
