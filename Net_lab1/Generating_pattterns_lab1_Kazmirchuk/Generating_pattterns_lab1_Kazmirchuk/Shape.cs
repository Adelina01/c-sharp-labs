using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    // класс геометрической фигуры
    class Shape
    {
        public Color color { get; set; } //цвет
        public Side side1 { get; set; } //сторона 1
        public Side side2 { get; set; }//сторона 2
        public Side side3 { get; set; }//сторона3
        public Radius radius { get; set; }//радиус

        public override string ToString() //переопределение метода "ToString"
        {
            StringBuilder sb = new StringBuilder();

            if (color != null) //если создан объект цвет
                sb.Append("Color: " + color.name + "\n");
            if (side1 != null) //если создан объект сторона1
                sb.Append("Length of side 1: " + side1.Length + " \n");
            if (side2 != null)//если создан объект сторона2
                sb.Append("Length of side 2: " + side2.Length + " \n");
            if (side3 != null)//если создан объект сторона3
                sb.Append("Length of side 3: " + side3.Length + " \n");
            if (radius != null)//если создан объект радиус
                sb.Append("Radius: " + radius.radius + " \n");
            return sb.ToString();
        }
    }
}

