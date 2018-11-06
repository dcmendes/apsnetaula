using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.Photo;

namespace WebApplicationCS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProcessarButton_Click(object sender, EventArgs e)
        {
            byte[] inputFile = FileUpload1.FileBytes;
            MemoryStream imgMemoryStream = new MemoryStream(inputFile);
            FileStream outputFileStream = new FileStream(Server.MapPath(@"image.jpg"), FileMode.OpenOrCreate);

            ImageFactory image = new ImageFactory();
            image.Load(imgMemoryStream);
            image.Filter(MatrixFilters.Invert);
            image.Save(outputFileStream);
            outputFileStream.Close();

        }
    }
}