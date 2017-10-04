using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    //строитель для треугольников
    class TriangleBuilder: ShapeBuilder
    {
        public override void SetColor()
        {
            this.shape.color = new Color { name = " orange" };
        }
        public override void SetRadius()
        {
            // треугольник не имеет радиуса
        }
        public override void SetSide1()
        {
            this.shape.side1= new Side { Length=3 };
        }
        public override void SetSide2()
        {
            this.shape.side2 = new Side { Length = 4 };
        }
        public override void SetSide3()
        {
            this.shape.side3 = new Side { Length = 5 };
        }
    }
}
