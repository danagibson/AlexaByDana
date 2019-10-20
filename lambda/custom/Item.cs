using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace songQuiz
{
    public class Item
    {
        const string SONGNAME = "SongName";
        const string SONG_NAME = "Song Name";
        const string SONGALBUM = "Song Album";
        const string SONGWRITER = "Song Writer";
        const string RESPONSE = "response";
        const string QUIZITEM = "quizitem";
        const string QUIZPROPERTY = "quizproperty";
        const string QUIZSCORE = "quizscore";
        const string COUNTER = "counter";


        public string SongWriter { get; set; }
        public string SongName { get; set; }
        public string SongAlbum { get; set; }

        public Item( string _songname, string _songwriter, string _songalbum)
        {
            SongName = _songname;
            SongWriter = _songwriter;
            SongAlbum = _songalbum;
            }

        /// <summary>
        /// return the string value of the specific property
        /// </summary>
        /// <param name="property"></param>
        /// <returns>string</returns>
        public string PropertyValue(string property)
        {
            string ret = "";
            switch(property)
            {
                case SONGNAME: ret = this.SongName;  break;
                case SONGWRITER: ret = this.SongWriter; break;
                case SONGALBUM: ret = this.SongAlbum; break;
            }
            return ret;
        }

        public static string[] PropertyNames = new string[3] { SONGNAME, SONGWRITER, SONGALBUM };

        /// <summary>
        /// return the names and values of the properties as newline separated string
        /// </summary>
        /// <param name="property"></param>
        /// <returns>string</returns>
        public static string GetFormatedText (Item item)
        {
            string text = SONG_NAME +": " + item.SongName +"\n";
            foreach(string name in Item.PropertyNames)
            {
                text += name + ": " +  item.PropertyValue(name) + "\n";
            }
            return text;
        }
        /// <summary>
        /// return the list of states
        /// </summary>
        /// <param name="property"></param>
        /// <returns>List<Item> </returns>
        public static List<Item> ItemsArray()
        {
            List<Item> theItems =  new List<Item>();
            theItems = new List<Item>();
            theItems.Add(new Item("Levon", "Elton John", "Madman Across the Water"));
            theItems.Add(new Item("Rose of Cimarron", "Rusty Young", "Rose of Cimarron"));
            theItems.Add(new Item("Legend", "Paul Cotton", "Legend"));
            theItems.Add(new Item("After the Gold Rush", "Neil Young", "After the Gold Rush"));
            theItems.Add(new Item("Black Queen", "Stephen Stills", "Stephen Stills"));
            return theItems;
        }
    }
}
