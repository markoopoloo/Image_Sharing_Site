using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Image_Sharing_Site.App_Code.BusinessLayer
{
    public class Comment
    {
        int commentId;
        string commentText;

        public Comment ()
        {
            
        }

        public int CommentId
        {
            get { return commentId; }
            set { commentId = value; }
        }

        public String CommentText
        {
            get { return commentText; }
            set { commentText = value; }
        }
    }
}