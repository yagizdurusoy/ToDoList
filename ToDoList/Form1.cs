namespace ToDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
            LoadTasks();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            btnMarkComplete.Click += new EventHandler(btnMarkComplete_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private List<string> tasks = new List<string>();
        private static string filePath = Path.Combine(Application.StartupPath, "tasks.txt");



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                tasks.Add(txtTask.Text);
                UpdateTaskList();
                txtTask.Clear();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                string editedTask = txtTask.Text;
                if (!string.IsNullOrWhiteSpace(editedTask))
                {
                    tasks[lstTasks.SelectedIndex] = editedTask;
                    UpdateTaskList();
                    txtTask.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                tasks.RemoveAt(lstTasks.SelectedIndex);
                UpdateTaskList();
            }
        }


        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int index = lstTasks.SelectedIndex;
                string currentTask = tasks[index];

                if (!currentTask.StartsWith("✔ "))
                {
                    tasks[index] = "✔ " + currentTask;
                    UpdateTaskList();
                }
                else
                {
                    MessageBox.Show("Task is already marked as completed!");
                }
            }
            
        }


        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            lstTasks.Items.AddRange(tasks.ToArray()); 
            lblTotalTasks.Text = "Total Tasks: " + tasks.Count;

            SaveTasks();
        }



        private void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks);
        }


        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                tasks = File.ReadAllLines(filePath).ToList();
                UpdateTaskList();
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                this.ForeColor = Color.White;
                lstTasks.BackColor = Color.DimGray;
                lstTasks.ForeColor = Color.White;
                txtTask.BackColor = Color.DimGray;
                txtTask.ForeColor = Color.White;
                lblTotalTasks.ForeColor = Color.White;
                lblTitle.ForeColor = SystemColors.Control;

                btnAdd.BackColor = Color.Gray;
                btnDelete.BackColor = Color.Gray;
                btnEdit.BackColor = Color.Gray;
                btnMarkComplete.BackColor = Color.Gray;

                btnAdd.ForeColor = Color.LightGreen;
                btnDelete.ForeColor = Color.LightCoral;
                btnEdit.ForeColor = Color.LightBlue;
                btnMarkComplete.ForeColor = Color.Orange;
            }
            else
            {
                this.BackColor = Color.LightSteelBlue;
                this.ForeColor = SystemColors.ControlText;
                lstTasks.BackColor = Color.White;
                lstTasks.ForeColor = SystemColors.WindowText;
                txtTask.BackColor = Color.White;
                txtTask.ForeColor = SystemColors.WindowText;
                lblTotalTasks.ForeColor = SystemColors.ControlText;
                lblTitle.ForeColor = Color.Navy;

                btnAdd.BackColor = SystemColors.Control;
                btnDelete.BackColor = SystemColors.Control;
                btnEdit.BackColor = SystemColors.Control;
                btnMarkComplete.BackColor = SystemColors.Control;

                btnAdd.ForeColor = Color.LightGreen;
                btnDelete.ForeColor = Color.LightCoral;
                btnEdit.ForeColor = Color.LightBlue;
                btnMarkComplete.ForeColor = Color.Orange;
            }

        }
    }
}
