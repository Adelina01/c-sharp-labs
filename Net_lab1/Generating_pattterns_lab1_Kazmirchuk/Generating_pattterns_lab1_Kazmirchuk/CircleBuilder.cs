using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    // строитель для кругов
    class CircleBuilder: ShapeBuilder
    {
        public override void SetColor()
        {
            this.shape.color = new Color { name = " red" };
        }
        public override void SetRadius()
        {
            this.shape.radius = new Radius { radius = 10 };
        }
        public override void SetSide1()
        {
            //круг не имеет стороны
        }
        public override void SetSide2()
        {
         
        }
        public override void SetSide3()
        {

        }
    }
}
