using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletApp.Application.Services
{
    public interface IBitmapIconService
    {
        Bitmap GetRandomBitmapIcon();
    }
}
