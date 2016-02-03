using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image_Sharing_Site.App_Code.BusinessLayer
{
    public class uploadedImage
    {
        private int imageID;
        private string imagePath;
        private int commentID;

        public uploadedImage()
        {
            
        }

        public int ImageID
        {
            get { return imageID; }
            set { imageID = value; }
        }

        public String ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }

    }
}