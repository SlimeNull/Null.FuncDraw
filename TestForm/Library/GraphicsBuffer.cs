using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Library
{
    public class GraphicsBuffer
    {
        BufferedGraphics buffer;
        Rectangle bufferArea;
        BufferedGraphicsContext context;

        Graphics targetGraphics;

        public GraphicsBuffer(Graphics targetGraphics, Rectangle bufferArea)
        {
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate(targetGraphics, bufferArea);

            this.targetGraphics = targetGraphics;
            this.bufferArea = bufferArea;
        }

        public BufferedGraphics BufferGraphics { get => buffer; }
        public Rectangle BufferArea
        { 
            get => bufferArea;
            set
            {
                bufferArea = value;

                buffer.Dispose();
                buffer = context.Allocate(targetGraphics, BufferArea);
            }
        }
        public Graphics TargetGraphics
        {
            get => targetGraphics;
            set
            {
                targetGraphics = value;

                buffer = context.Allocate(targetGraphics, BufferArea);
            }
        }
    }
}
