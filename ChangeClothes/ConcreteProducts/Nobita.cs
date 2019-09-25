using ChangeClothes.Products;
using System.Drawing;

namespace ChangeClothes.ConcreteProducts
{
    class Nobita : Character
    {
        public Nobita()
        {
            CharacterPath = @"D:\study\mau thiet ke\builder pattern\BuilderPattern\ChangeClothes\Images\nobita.png";
            TopHead = new Rectangle(70, 12, 180, 53);
            Eyes = new Rectangle(108, 68, 76, 48);
            Lips = new Rectangle(125, 120, 54, 30);
            Neck = new Rectangle(141, 156, 47, 25);
            UpperBody = new Rectangle(100, 161, 128, 94);
            LowerBody = new Rectangle(94, 245, 129, 75);
            Foot = new Rectangle(120, 451, 94, 64);
        }
    }
}
