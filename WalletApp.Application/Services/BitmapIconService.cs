using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletApp.Application.Services
{
    public class BitmapIconService : IBitmapIconService
    {
        public Bitmap GetRandomBitmapIcon()
        {
            Icon icon = new Icon(SystemIcons.Shield, 48, 48);
            Color backgroundColor = Color.Black;

            Bitmap bitmap = new Bitmap(icon.Width, icon.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(backgroundColor);
                graphics.DrawIcon(icon, new Rectangle(0, 0, icon.Width, icon.Height));
            }

            return bitmap;
        }
    }
}
