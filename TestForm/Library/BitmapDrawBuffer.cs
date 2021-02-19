using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Library
{
    class BitmapDrawBuffer
    {
        Bitmap buffer;
        Graphics bufferGraphics;
        Rectangle bufferArea;

        Graphics destGraphics;

        public BitmapDrawBuffer(Graphics destGraphics, Rectangle rect)
        {
            bufferArea = rect;
            buffer = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            bufferGraphics = Graphics.FromImage(buffer);

            this.destGraphics = destGraphics;
        }
        public Rectangle BufferArea
        {
            get => bufferArea;
            set
            {
                bufferGraphics.Dispose();
                buffer.Dispose();
                bufferArea = value;
                buffer = new Bitmap(value.Width, value.Height, PixelFormat.Format24bppRgb);
                bufferGraphics = Graphics.FromImage(buffer);
            }
        }
        public Graphics DestGraphics
        {
            get => destGraphics;
            set
            {
                destGraphics = value;
            }
        }
        public Graphics BufferGraphics { get => bufferGraphics; }
        public void DrawBuffer()
        {
            destGraphics.DrawImage(buffer, bufferArea.Location);
        }
        public void Clear(Color color)
        {
            bufferGraphics.Clear(color);
        }
    }
}
