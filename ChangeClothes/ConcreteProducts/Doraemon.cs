using ChangeClothes.Products;
using System.Drawing;

namespace ChangeClothes.ConcreteProducts
{
    class Doraemon : Character
    {
        public Doraemon()
        {
            CharacterPath = @"D:\study\mau thiet ke\builder pattern\BuilderPattern\ChangeClothes\Images\doraemon.png";
            TopHead = new Rectangle(0, 0, 345, 20);
            Eyes = new Rectangle(113, 21, 145, 89);
            Lips = new Rectangle(70, 155, 220, 122);
            Neck = new Rectangle(65, 288, 220, 55);
            UpperBody = new Rectangle(0, 310, 340, 110);
            LowerBody = new Rectangle(0, 420, 340, 65);
            Foot = new Rectangle(40, 493, 265, 47);
        }
    }
}
