﻿using ChangeClothes.Builders;
using System.IO;

namespace ChangeClothes.ConcreteBuilders
{
    /// <summary>
    /// Concrete character builder
    /// </summary>
    class SexyGirl : CharacterBuilder
    {
        public SexyGirl()
        {
            _imagesRootPath = @"D:\study\mau thiet ke\builder pattern\BuilderPattern\ChangeClothes\Images\SexyGirls";
        }

        public override void PaintLips()
        {
            _character.LipsPath = Path.Combine(_imagesRootPath, "lips.png");
        }

        public override void WearGlasses()
        {
            _character.GlassesPath = Path.Combine(_imagesRootPath, "glasses.png");
        }

        public override void WearHat()
        {
            _character.HatPath = Path.Combine(_imagesRootPath, "hat.png");
        }

        public override void WearNecklace()
        {
            _character.NecklacePath = Path.Combine(_imagesRootPath, "necklace.png");
        }

        public override void WearShirt()
        {
            _character.ShirtPath = Path.Combine(_imagesRootPath, "shirt.png");
        }

        public override void WearShoes()
        {
            _character.ShoesPath = Path.Combine(_imagesRootPath, "sandals.png");
        }

        public override void WearTrousers()
        {
            _character.TrousersPath = Path.Combine(_imagesRootPath, "skirt.png");
        }
    }
}
