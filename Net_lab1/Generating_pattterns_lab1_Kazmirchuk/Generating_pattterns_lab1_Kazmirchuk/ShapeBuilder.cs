using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    //абстрактный класс строителя фигур
    abstract class ShapeBuilder
    {
        public Shape shape { get; private set; } 
        public void CreateShape()
        { //создаем фигуру
            shape = new Shape();
        }
      //абстрактные методы для установки параметров фигуры
        public abstract void SetColor();
        public abstract void SetSide1();
        public abstract void SetSide2();
        public abstract void SetSide3();
        public abstract void SetRadius();

    }
}
