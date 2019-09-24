using System.Drawing;

namespace ChangeClothes.Products
{
    /// <summary>
    /// base product
    /// </summary>
    class Character
    {
        public string CharacterPath { get; set; }
        public Rectangle TopHead { get; set; }
        public Rectangle Eyes { get; set; }
        public Rectangle Lips { get; set; }
        public Rectangle Neck { get; set; }
        public Rectangle UpperBody { get; set; }
        public Rectangle LowerBody { get; set; }
        public Rectangle Foot { get; set; }

        public string HatPath { get; set; }
        public string GlassesPath { get; set; }
        public string LipsPath { get; set; }
        public string NecklacePath { get; set; }
        public string ShirtPath { get; set; }
        public string TrousersPath { get; set; }
        public string ShoesPath { get; set; }
    }
}
