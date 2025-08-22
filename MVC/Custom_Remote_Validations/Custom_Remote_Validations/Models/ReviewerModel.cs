using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom_Remote_Validations.Models
{
    public class ReviewerModel
    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public string StarRating { get; set; }
        public string CommentsTitle { get; set; }
        public string Comments { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}