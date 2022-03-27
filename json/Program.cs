using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace json
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Hotels LoadJson()
        {
            string path = "новый 1.txt";
            //return JsonConvert.DeserializeObject<Hotels>(File.ReadAllText(path));
            try
            {
                return JsonConvert.DeserializeObject<Hotels>(File.ReadAllText(path));
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка десериализации", "Error");
                return null;
            }
        }

        //public static void GetFile()
        //{
        //    Hotel motel = new Hotel();
        //    motel.name = "Motel";
        //    motel.rooms = new Rooms();


        //    motel.buns = new Buns();

        //    var hotel_array = new Hotels();
        //    hotel_array.hotels = new HotelArray();
        //    hotel_array.hotels.Hotel_Array = new Hotel[] { motel };

        //    string jsonData = JsonConvert.SerializeObject(hotel_array);

        //    var h2 = JsonConvert.DeserializeObject<Hotels>(jsonData);
        //}

    }
}
