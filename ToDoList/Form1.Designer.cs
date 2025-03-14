namespace ToDoList
{
    partial class frmToDoList
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
            lblTitle = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            lstTasks = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMarkComplete = new Button();
            lblTotalTasks = new Label();
            chkDarkMode = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Violet;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.DarkMagenta;
            lblTitle.Location = new Point(125, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "To-Do List 2025";
            lblTitle.Click += label1_Click;
            // 
            // txtTask
            // 
            txtTask.BackColor = Color.White;
            txtTask.Font = new Font("Segoe UI", 12F);
            txtTask.Location = new Point(20, 50);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(320, 34);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkMagenta;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(350, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = Color.White;
            lstTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstTasks.ForeColor = SystemColors.WindowText;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 28;
            lstTasks.Location = new Point(20, 90);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(450, 200);
            lstTasks.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkMagenta;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(20, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkMagenta;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(180, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.BackColor = Color.DarkMagenta;
            btnMarkComplete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMarkComplete.ForeColor = Color.Black;
            btnMarkComplete.Location = new Point(340, 300);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(140, 30);
            btnMarkComplete.TabIndex = 6;
            btnMarkComplete.Text = "Mark Comple";
            btnMarkComplete.UseVisualStyleBackColor = false;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalTasks.Location = new Point(20, 340);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(250, 30);
            lblTotalTasks.TabIndex = 7;
            lblTotalTasks.Text = "Total Tasks:";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkDarkMode.Location = new Point(330, 340);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(139, 32);
            chkDarkMode.TabIndex = 8;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(482, 403);
            Controls.Add(chkDarkMode);
            Controls.Add(lblTotalTasks);
            Controls.Add(btnMarkComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lstTasks);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(lblTitle);
            Name = "frmToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTask;
        private Button btnAdd;
        private ListBox lstTasks;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMarkComplete;
        private Label lblTotalTasks;
        private CheckBox chkDarkMode;
    }
}
