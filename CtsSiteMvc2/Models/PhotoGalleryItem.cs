using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CtsSiteMvc2.Models
{
    public class PhotoGalleryItem
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public System.Drawing.Image Image { get
            {
                if (this.Content == null)
                    return null;
                else
                    return byteArrayToImage(Content);
            }
            set
            {
                if (value == null)
                    this.Content = null;
                else
                    this.Content = imageToByteArray(value);
            }
        }

        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}