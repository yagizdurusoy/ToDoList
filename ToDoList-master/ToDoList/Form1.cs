namespace ToDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
            LoadTasks();
            Adder.Click += new EventHandler(btnAdd_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            

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
            if (!string.IsNullOrWhiteSpace(textTaskPlace.Text))
            {
                tasks.Add(textTaskPlace.Text);
                UpdateTaskList();
                textTaskPlace.Clear();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TaskingListPlace.SelectedIndex != -1)
            {
                string editedTask = textTaskPlace.Text;
                if (!string.IsNullOrWhiteSpace(editedTask))
                {
                    tasks[TaskingListPlace.SelectedIndex] = editedTask;
                    UpdateTaskList();
                    textTaskPlace.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TaskingListPlace.SelectedIndex != -1)
            {
                tasks.RemoveAt(TaskingListPlace.SelectedIndex);
                UpdateTaskList();
            }
        }


        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (TaskingListPlace.SelectedIndex != -1)
            {
                int index = TaskingListPlace.SelectedIndex;
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
            TaskingListPlace.Items.Clear();
            TaskingListPlace.Items.AddRange(tasks.ToArray()); 
            TOTAL.Text = "Total Tasks: " + tasks.Count;

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


        }
    }

