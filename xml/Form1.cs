using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xml
{
    public partial class Form1 : Form
    {
        Hotels hotel_array = Program.LoadXml();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Hotel hotel in hotel_array.hotels.Hotel_Array)
            {
                if (hotel.name.Equals(dataGridView1.CurrentCell.Value))
                {
                    foreach(Room room in hotel.rooms.RoomArray)
                    {
                        if(dataGridView2.Rows.Count > 3)
                        {
                            dataGridView2.Rows.Clear();
                            dataGridView3.Rows.Clear();
                        }
                        dataGridView2.Rows.Add(room.number, room.bed, room.beautiful_view, room.fridge, room.price, room.bun.number);
                    }
                }
            }

            foreach (Hotel hotel in hotel_array.hotels.Hotel_Array)
            {
                if (hotel.name.Equals(dataGridView1.CurrentCell.Value))
                {
                    foreach (Bun bun in hotel.buns.BunArray)
                    {
                        dataGridView3.Rows.Add(bun.name, bun.add_price);
                    }
                }
            }

        }

        private void btnSerialize_Click(object sender, EventArgs e)
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
    }
}
