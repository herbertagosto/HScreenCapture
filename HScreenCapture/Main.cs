using HScreenCapture.Libs;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace HScreenCapture
{
    public class Main
    {
        /// <summary>
        /// Screen capture the screen
        /// </summary>
        /// <returns></returns>
        public Image GetImage()
        {
            return new ScreenCapture().CaptureScreen();
        }
        /// <summary>
        /// Screen capture a window
        /// </summary>
        /// <param name="windowClassName">Use the Microsoft Spy++ app to get the window class name</param>
        /// <param name="windowMainTitle">Use the Microsoft Spy++ app to get the window class name</param>
        /// <returns></returns>
        public Image GetImage(string windowClassName, string windowMainTitle)
        {
            var windowHandle = WindowHandle.GetHandle(windowClassName, windowMainTitle);
            return new ScreenCapture().CaptureWindow(windowHandle);
        }
        /// <summary>
        /// Save image to clipboard
        /// </summary>
        /// <param name="image"></param>
        public void SaveToClipboard(Image image)
        {
            Clipboard.SetImage(image);
        }
        /// <summary>
        /// Save image to PNG file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="image"></param>
        public void SaveToPNG(string path, Image image)
        {
            SaveToFile(path, image, ImageFormat.Png);
        }
        /// <summary>
        /// Save image to file
        /// Must add reference to System.Drawing.dll
        /// </summary>
        /// <param name="path"></param>
        /// <param name="image"></param>
        /// <param name="imageFormat"></param>
        public void SaveToFile(string path, Image image, ImageFormat imageFormat)
        {
            ScreenCapture sc = new ScreenCapture();
            image.Save(path, imageFormat);
        }
    }
}
