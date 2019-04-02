using System;
using System.Net.Mime;

namespace SCCR_App.Api.Models
{
    public class FeedItemModel
    {
        public string Name { get; set; }
        public string Image { get; set; } // I have no idea what format to store images in yet
        public string Description { get; set; }
        public DateTime TimeEntered { get; set; } //just incase we wanna make something to do with time
    }
}