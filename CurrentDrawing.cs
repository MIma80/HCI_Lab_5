using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Lab_5
{
    public class CurrentDrawing
    {
        public static int currentShape;
        public static int currentTool;
        public static Color currentColour;

        public static void SetDrawing(int currentShape_, int currentTool_, Color currentColour_)
        {
            currentShape = currentShape_;
            currentTool = currentTool_;
            currentColour = currentColour_;
        }
    }
}
