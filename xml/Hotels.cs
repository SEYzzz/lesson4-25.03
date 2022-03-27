using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;

namespace xml
{
    [System.Xml.Serialization.XmlRoot("Hotels")]
    public class Hotels
    {
        [System.Xml.Serialization.XmlElement("HotelArray")]
        public HotelArray hotels { get; set; }
    }
    
    public class Rooms
    {
        [System.Xml.Serialization.XmlElement("room")]
        public Room[] RoomArray { get; set; }
    }

    public class Room
    {
        [System.Xml.Serialization.XmlAttribute("number", Namespace = "")]
        public int number { get; set; }

        [System.Xml.Serialization.XmlElement("bed", Namespace = "")]
        public int bed { get; set; }

        [System.Xml.Serialization.XmlElement("beatiful_view", Namespace = "")]
        public bool beautiful_view { get; set; }

        [System.Xml.Serialization.XmlElement("fridge", Namespace = "")]
        public bool fridge { get; set; }

        [System.Xml.Serialization.XmlElement("price", Namespace = "")]
        public int price { get; set; }

        [System.Xml.Serialization.XmlElement("bun", Namespace = "")]
        public Bun bun { get; set; }
    }

    public class Buns 
    {
        [System.Xml.Serialization.XmlElement("bun")]
        public Bun[] BunArray { get; set; } 
    }

    public class Bun
    {
        [System.Xml.Serialization.XmlAttribute("number", Namespace = "")]
        public int number { get; set; }

        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string name { get; set; }

        [System.Xml.Serialization.XmlElement("add_price", Namespace = "")]
        public bool add_price { get; set; }

    }

    public class HotelArray 
    {
        [System.Xml.Serialization.XmlElement("Hotel")]
        public Hotel[] Hotel_Array { get; set; }
    }

    public class Hotel
    {
        [System.Xml.Serialization.XmlAttribute("name", Namespace = "")]
        public string name { get; set; }

        [System.Xml.Serialization.XmlElement("Rooms", Namespace = "")]
        public Rooms rooms { get; set; }

        [System.Xml.Serialization.XmlElement("Buns", Namespace = "")]
        public Buns buns { get; set; }
    }

}
