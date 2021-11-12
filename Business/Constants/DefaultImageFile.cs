using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Constant
{
   public static class DefaultImageFile
    {
        public static string WorkingDirectory = Directory.GetCurrentDirectory() + @"\wwwroot";

        public static string DocumentPath = @"\doc\";

        public static string DefaultProfileImagePath = @"\img\DefaultImages\default-profile-img.jpg";
    }
}
