using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIapp31
{
    public partial class Form1 : Form
    {
        static private List<Food> foodList = new List<Food>()
        {
            new Food(){Name = "떡볶이", Price = 3500},
            new Food(){Name = "순대", Price = 3000},
            new Food(){Name = "튀김", Price = 2500},
            new Food(){Name = "어묵", Price = 1000},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
