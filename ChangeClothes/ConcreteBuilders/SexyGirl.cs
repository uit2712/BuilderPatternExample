using ChangeClothes.Builders;
using System.IO;

namespace ChangeClothes.ConcreteBuilders
{
    /// <summary>
    /// Concrete character builder
    /// </summary>
    class SexyGirl : CharacterBuilder
    {
        private string _relativePath = @"D:\study\mau thiet ke\builder pattern\BuilderPattern\ChangeClothes\Images\SexyGirls";

        public override void PaintLips()
        {
            _character.LipsPath = Path.Combine(_relativePath, "lips.png");
        }

        public override void WearGlasses()
        {
            _character.GlassesPath = Path.Combine(_relativePath, "glasses.png");
        }

        public override void WearHat()
        {
            _character.HatPath = Path.Combine(_relativePath, "hat.png");
        }

        public override void WearNecklace()
        {
            _character.NecklacePath = Path.Combine(_relativePath, "necklace.png");
        }

        public override void WearShirt()
        {
            _character.ShirtPath = Path.Combine(_relativePath, "shirt.png");
        }

        public override void WearShoes()
        {
            _character.ShoesPath = Path.Combine(_relativePath, "sandals.png");
        }

        public override void WearTrousers()
        {
            _character.TrousersPath = Path.Combine(_relativePath, "skirt.png");
        }
    }
}
