using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace json
{
    class Hotels
    {
        [JsonProperty("HotelArray")]
        public HotelArray hotels { get; set; }
    }

    public class Rooms
    {
        [JsonProperty("room")]
        public Room[] RoomArray { get; set; }
    }

    public class Room
    {
        [JsonProperty("number")]
        public int number { get; set; }

        [JsonProperty("bed")]
        public int bed { get; set; }

        [JsonProperty("beautiful_view")]
        public bool beautiful_view { get; set; }

        [JsonProperty("fridge")]
        public bool fridge { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }

        [JsonProperty("bun")]
        public Bun bun { get; set; }
    }

    public class Buns
    {
        [JsonProperty("bun")]
        public Bun[] BunArray { get; set; }
    }

    public class Bun
    {
        [JsonProperty("number")]
        public int number { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("add_price")]
        public bool add_price { get; set; }

    }

    public class HotelArray
    {
        //[JsonExtensionData("Hotel", Hotel)]
        [JsonProperty("Hotel")]
        public Hotel[] Hotel_Array { get; set; }
    }

    public class Hotel
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("Rooms")]
        public Rooms rooms { get; set; }

        [JsonProperty("Buns")]
        public Buns buns { get; set; }
    }
}
