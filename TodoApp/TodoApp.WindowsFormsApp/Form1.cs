using System;
using System.Windows.Forms;
using TodoApp.Models;

namespace TodoApp.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ITodoRepository _repository;
       
        public Form1()
        {
             
            InitializeComponent();
            _repository = new TodoRepositoryJson(@"C:\TodoApp\Todos.json");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = _repository.GetAll();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {

        }
    }
}
