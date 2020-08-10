using System;
using System.Collections.Generic;
using TravelApp.Entities;

namespace TravelApp.Data.Models
{
    public partial class Articles : IEntity
    {
        public int ArticlesId { get; set; }
        public string ArticleTitle { get; set; }
        public string Article { get; set; }
        public string Image { get; set; }
    }
}
