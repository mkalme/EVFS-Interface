using System;
using System.Reflection;
using System.Drawing;

namespace EVFS.OS {
    class AssemblyHelper {
        public static void Launch(Assembly assembly, object[] arguments) {
            Type type = assembly.GetType("Program.Program");
            if (type == null) return;

            MethodInfo methodInfo = type.GetMethod("Invoke");
            if (methodInfo == null) return;

            object[] parametersArray = arguments;
            methodInfo.Invoke(null, parametersArray);
        }
    }

    class ImageHelper {
        public static readonly int Width = 64, Height = 64;

        public static Image Resize(Image image) {
            Bitmap result = new Bitmap(Width, Height);

            using (Graphics g = Graphics.FromImage(result)) {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, Width, Height);
            }

            return result;
        }
    }
}
