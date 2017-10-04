using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    //строитель для прямоугольников
    class RectangleBuilder: ShapeBuilder
    {
        public override void SetColor()
        {
            this.shape.color = new Color { name = "green" };
        }
        public override void SetRadius()
        {
            //прямоугольник не имеет радиуса
        }
        public override void SetSide1()
        {
            this.shape.side1 = new Side { Length = 15 };
        }
        public override void SetSide2()
        {
            this.shape.side2 = new Side { Length = 30};
        }
        public override void SetSide3()
        {
            //прямоугольник не имеет третей отличной стороны
        }
    }
}
