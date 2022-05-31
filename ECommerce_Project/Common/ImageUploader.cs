using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class ImageUploader
    {

        /*
        0=> dosya bos

        1=> bu görsel zaten eklenmis

        2=> uymayan format

        3=>ekleme başarılı
         */
        public static string UploadImage(string imagepath, HttpPostedFileBase file)
        {
            string filename = "";

            if(file!= null)
            {
                var uniqueName = Guid.NewGuid();
                imagepath = imagepath.Replace("~", ""); //tildayı kaldırmak gerek bize sıkıntı yaratır

                var fileArray = file.FileName.Split('.');
                string extention = fileArray[fileArray.Length - 1].ToLower(); //png
                filename = uniqueName +"."+ extention;

                //png,jpg,jpeg,gif

                if (extention=="png" || extention== "jpeg" || extention== "jpg" || extention == "gif")
                {
                    try
                    {
                        var filePath = HttpContext.Current.Server.MapPath(imagepath + filename);
                        file.SaveAs(filePath);
                        return filename;
                    }
                    catch (Exception ex)
                    {

                       return ex.Message;
                    }
                }

                return "";
            }

            else
            {
                return "0";
            }
        }

    }
}
