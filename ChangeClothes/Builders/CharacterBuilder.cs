using ChangeClothes.Products;

namespace ChangeClothes.Builders
{
    /// <summary>
    /// abstract character builder
    /// </summary>
    abstract class CharacterBuilder
    {
        protected Character _character;

        public Character GetCharacter()
        {
            return _character;
        }

        public void SetCharacter(Character character)
        {
            _character = character;
        }

        public abstract void WearHat();
        public abstract void WearGlasses();
        public abstract void PaintLips();
        public abstract void WearNecklace();
        public abstract void WearShirt();
        public abstract void WearTrousers();
        public abstract void WearShoes();
    }
}
