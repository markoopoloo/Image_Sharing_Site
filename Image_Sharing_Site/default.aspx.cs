using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Image_Sharing_Site
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btUpload_Click(object sender, EventArgs e)
        {
            if(fileUpload.HasFile)
            {
                if ((fileUpload.PostedFile.ContentType == "image/jpeg") || 
                    (fileUpload.PostedFile.ContentType == "image/png") ||
                    (fileUpload.PostedFile.ContentType == "image/bmp") ||
                    (fileUpload.PostedFile.ContentType == "image/gif"))
                {
                    if (fileUpload.PostedFile.ContentLength == 5000000 )
                    {
                        string uploadedImagesFolder = Path.Combine("/uploaded_images/");
                        if (!Directory.Exists(uploadedImagesFolder))
                        {
                            Directory.CreateDirectory(uploadedImagesFolder);
                            string extension = Path.GetExtension(fileUpload.FileName);
                            string uniqueFileName = Path.ChangeExtension(fileUpload.FileName,DateTime.Now.Ticks.ToString());
                            fileUpload.SaveAs(Path.Combine(uploadedImagesFolder, uniqueFileName + extension));
                        }
                        else
                        {
                             
                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    
                }  
            }
            else
            {
                
            }
        }
    }
}