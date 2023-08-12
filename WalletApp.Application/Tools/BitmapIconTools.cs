using System.Drawing;
using System.Runtime.Versioning;

namespace WalletApp.Application.Tools
{
    [SupportedOSPlatform("windows")]
    public static class BitmapIconUtils
    {
        private readonly static Random _random = new Random();
        private readonly static List<Icon> _icons = new List<Icon>
        {
            SystemIcons.Application,
            SystemIcons.Asterisk,
            SystemIcons.Error,
            SystemIcons.Exclamation,
            SystemIcons.Hand,
            SystemIcons.Information,
            SystemIcons.Question,
            SystemIcons.Shield,
            SystemIcons.Warning,
            SystemIcons.WinLogo
        };

        public static Bitmap GetRandomBitmapIcon()
        {
            var randomIcon = _icons[_random.Next(_icons.Count)];
            Icon icon = new Icon(randomIcon, 48, 48);
            Color backgroundColor = Color.FromArgb(_random.Next(100), _random.Next(100), _random.Next(100));

            Bitmap bitmap = new Bitmap(icon.Width, icon.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backgroundColor);
                graphics.DrawIcon(icon, new Rectangle(0, 0, icon.Width, icon.Height));
            }

            return bitmap;
        }

        public static byte[] ConvertIconToBytes(Bitmap icon)
        {
            using var memoryStream = new MemoryStream();
            icon.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }
    }
}
