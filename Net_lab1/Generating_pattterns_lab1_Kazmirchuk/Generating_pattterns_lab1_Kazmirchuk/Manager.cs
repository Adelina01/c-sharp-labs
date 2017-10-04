using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_pattterns_lab1_Kazmirchuk
{
    //manager, который руководит процесом построения фигур
    class Manager
    {
        //ф-я для построения фигуры с помощью "строителя", который является параметром данной ф-и
        public Shape Draw(ShapeBuilder shapeBuilder)
        {
            shapeBuilder.CreateShape(); //создать фигуру
            shapeBuilder.SetColor(); //установить цыет
            shapeBuilder.SetSide1(); // задать сторону 1
            shapeBuilder.SetSide2();//задать сторону 2
            shapeBuilder.SetSide3();//задать сторону 3
            shapeBuilder.SetRadius();//задать радиус

            return shapeBuilder.shape; //возвращаем фигуру
        }
    }
}
