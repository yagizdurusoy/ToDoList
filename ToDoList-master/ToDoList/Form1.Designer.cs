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
            lableTitle = new Label();
            textTaskPlace = new TextBox();
            Adder = new Button();
            TaskingListPlace = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            TOTAL = new Label();
            SuspendLayout();
            // 
            // lableTitle
            // 
            lableTitle.AutoSize = true;
            lableTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lableTitle.ForeColor = Color.DarkMagenta;
            lableTitle.Location = new Point(11, 9);
            lableTitle.Name = "lableTitle";
            lableTitle.Size = new Size(408, 38);
            lableTitle.TabIndex = 0;
            lableTitle.Text = "TO DO LIST GENERATOR 2025";
            lableTitle.Click += label1_Click;
            // 
            // textTaskPlace
            // 
            textTaskPlace.BackColor = Color.White;
            textTaskPlace.Font = new Font("Segoe UI", 12F);
            textTaskPlace.Location = new Point(12, 86);
            textTaskPlace.Name = "textTaskPlace";
            textTaskPlace.Size = new Size(784, 34);
            textTaskPlace.TabIndex = 1;
            // 
            // Adder
            // 
            Adder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Adder.ForeColor = Color.DarkMagenta;
            Adder.Location = new Point(11, 50);
            Adder.Name = "Adder";
            Adder.Size = new Size(195, 30);
            Adder.TabIndex = 2;
            Adder.Text = "Add Task";
            Adder.UseVisualStyleBackColor = true;
            // 
            // TaskingListPlace
            // 
            TaskingListPlace.BackColor = Color.White;
            TaskingListPlace.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TaskingListPlace.ForeColor = SystemColors.WindowText;
            TaskingListPlace.FormattingEnabled = true;
            TaskingListPlace.ItemHeight = 28;
            TaskingListPlace.Location = new Point(12, 140);
            TaskingListPlace.Name = "TaskingListPlace";
            TaskingListPlace.Size = new Size(422, 396);
            TaskingListPlace.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.ForeColor = Color.LightBlue;
            btnEdit.Location = new Point(455, 178);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(341, 120);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.LightCoral;
            btnDelete.Location = new Point(455, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(341, 120);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // TOTAL
            // 
            TOTAL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL.Location = new Point(12, 551);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(502, 84);
            TOTAL.TabIndex = 7;
            TOTAL.Text = "TOTAL:";
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(808, 644);
            Controls.Add(TOTAL);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(TaskingListPlace);
            Controls.Add(Adder);
            Controls.Add(textTaskPlace);
            Controls.Add(lableTitle);
            Name = "frmToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List 2025";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lableTitle;
        private TextBox textTaskPlace;
        private Button Adder;
        private ListBox TaskingListPlace;
        private Button btnEdit;
        private Button btnDelete;
        private Label TOTAL;
    }
}
