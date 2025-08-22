using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Remote_Validations.Models;

namespace Custom_Remote_Validations.Controllers
{
    public class ItemReviewController : Controller
    {
        // GET: ItemReview
        public ActionResult Index()
        {
            var reviewdisplay = new Tuple<ItemModel, List<ReviewerModel>>(GetItemDetails(), GetReviewList());
            return View(reviewdisplay);
        }

        public ItemModel GetItemDetails()
        {
            ItemModel imodel = new ItemModel()
            {
                ID = 1,
                Name = "HP Printer",
                Category = "Computer Accessory",
                Price = 9850
            };
            return imodel;
        }

        public List<ReviewerModel> GetReviewList()
        {
            List<ReviewerModel> RList = new List<ReviewerModel>();

            RList.Add(new ReviewerModel()
            {
                ReviewId = 1,
                ReviewerName = "Ashok",
                StarRating = "4",
                CommentsTitle = "Nice Product",
                Comments = "We Purchased this item 2weeks ago and it is good",
                ReviewDate = Convert.ToDateTime("2 August 25")
            });

            RList.Add(new ReviewerModel()
            {
                ReviewId = 2,
                ReviewerName = "Sandhya",
                StarRating = "2",
                CommentsTitle = "Worst Product",
                Comments = "Worst Product. Do not Buy It. Received a Damaged one.",
                ReviewDate = Convert.ToDateTime("11 August 25")
            });

            RList.Add(new ReviewerModel()
            {
                ReviewId = 3,
                ReviewerName = "Bharath",
                StarRating = "3.5",
                CommentsTitle = "Satisfactory",
                Comments = "OK Product. Can go for It.",
                ReviewDate = Convert.ToDateTime("2 June 25")
            });

            RList.Add(new ReviewerModel()
            {
                ReviewId = 4,
                ReviewerName = "Usha",
                StarRating = "4.5",
                CommentsTitle = "Super Product",
                Comments = "Damm Good Buy. Do not Think twice, go for it.",
                ReviewDate = Convert.ToDateTime("20 August 25")
            });
            return RList;
        }

        public ActionResult ItemReviewDisplay()
        {
            Session["Item"] = GetItemDetails();
            Session["Reviews"] = GetReviewList();
            return View();
        }
    }
}