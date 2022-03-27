using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace json
{
    public partial class Form1 : Form
    {
        Hotels hotel_array = Program.LoadJson();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            if (!hotel_array.Equals(null))
            {
                foreach (Hotel hotel in hotel_array.hotels.Hotel_Array)
                {
                    dataGridView1.Rows.Add(hotel.name);
                }
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Program.GetFile();
        }
    }
}
