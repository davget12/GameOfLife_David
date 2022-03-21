
using System.Windows.Forms;

namespace GameOfLife
{
    public class GraphicsPanel : Panel
    {
        public GraphicsPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}

