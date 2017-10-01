using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BryanMcNeil
{
    class Desk
    {
        private int weight;
        private int height;
        private int drawers;

        public const double BASE_PRICE = 200.00;

        public Desk()
        {
            weight = 0;
            height = 0;
            drawers = 0;
        }

        public int GetWeight() { return weight; }
        public void SetWeight(int w) { weight = w; }
        public int GetHeight() { return height; }
        public void SetHeight(int h) { height = h; }
        public int GetDrawers() { return drawers; }
        public void SetDrawers(int d) { drawers = d; }

        public enum Materials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}
