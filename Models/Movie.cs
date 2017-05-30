using System;
using System.ComponentModel.DataAnnotations;

namespace movieAPI
{
    public class Book
    {
   
        public int Id { get; set; }
       
        public string title { get; set; }

        public string year { get; set; }
        public string genre { get; set; }
        public string rating { get; set; }
        public bool viewed { get; set; }
        }
}