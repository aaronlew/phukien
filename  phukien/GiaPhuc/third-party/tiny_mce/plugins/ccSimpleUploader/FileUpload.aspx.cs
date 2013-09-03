using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TinyMCEeditor.tiny_mce.plugins.ccSimpleUploader
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string path = Server.MapPath("/Upload/" + FileUpload1.FileName);
                    path = path.Replace('\\', '/');

                    using (Stream outFile = System.IO.File.OpenWrite(path))
                    {
                        CopyStream(FileUpload1.FileContent, outFile);
                    }

                    // FileUpload1.SaveAs(path);

                    image.ImageUrl = "/Upload/" + FileUpload1.FileName;

                    Label1.Text = "File name: " +
                         FileUpload1.PostedFile.FileName + "<br>" +
                         FileUpload1.PostedFile.ContentLength + " kb<br>" +
                         "Content type: " +
                         FileUpload1.PostedFile.ContentType;

                    // Successful
                    ClientScriptManager script = Page.ClientScript;
                    if (!script.IsClientScriptBlockRegistered(this.GetType(), "alert"))
                    {
                        //script.RegisterStartupScript(this.GetType(), "alert", "tinyMCE.activeEditor.execCommand('mceInsertContent', false, '<img src=\"/Upload/" + FileUpload1.FileName + "\" alt=\"phu kien ipad, pin du phong, bao da YOOBAO\" />');", true);
                        script.RegisterStartupScript(this.GetType(), "alert", "ClosePluginPopup('/Upload/" + FileUpload1.FileName + "');", true);
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "ERROR: " + ex.Message.ToString();
                }
            }
            else
            {
                Label1.Text = "You have not specified a file.";
            }
        }


        protected bool ProcessFile(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            switch (fileInfo.Extension)
            {
                case ".JPG":
                    
                default:
                    return false;
            }
        }
        //if(strpos($ActualFileName, ".jpg")==TRUE)
        //    $src = imagecreatefromjpeg($uploadedfile);																// Create an image object
        //else if(strpos($ActualFileName, ".gif")==TRUE)
        //    $src = imagecreatefromgif($uploadedfile);
        //else if(strpos($ActualFileName, ".png")==TRUE)
        //    $src = imagecreatefrompng($uploadedfile);
        //else
        //    return FALSE;
        //list($Originalwidth, $Originalheight) = getimagesize($uploadedfile);										// get current image size
        //if($ResizeSizeY==0 && $ResizeSizeX!=0)																		// if only the width was specified
        //    $ResizeSizeY = ($Originalheight/$Originalwidth) * $ResizeSizeX;
        //else if($ResizeSizeX==0 && $ResizeSizeY!=0)																	// if only the height was specified
        //    $ResizeSizeX = ($Originalwidth/$Originalheight) * $ResizeSizeY;
        //$tmp = imagecreatetruecolor($ResizeSizeX, $ResizeSizeY);													// create new image with calculated dimensions	
        //imagecopyresampled($tmp, $src, 0, 0, 0, 0, $ResizeSizeX, $ResizeSizeY, $Originalwidth, $Originalheight);	// resize the image and copy it into $tmp image		
        //if(strpos($ActualFileName, ".jpg")==TRUE)
        //    imagejpeg($tmp, $ActualFileName, 100);
        //else if(strpos($ActualFileName, ".gif")==TRUE)
        //    imagegif($tmp, $ActualFileName);
        //else if(strpos($ActualFileName, ".png")==TRUE)
        //    imagepng($tmp, $ActualFileName, 100);		
        //imagedestroy($src);
        //imagedestroy($tmp); // NOTE: PHP will clean up the temp file it created when the request has completed.		

        /// <summary> 
        /// Copies the contents of input to output. Doesn't close either stream. 
        /// </summary> 
        private void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
    }
}