using ChangeClothes.Products;

namespace ChangeClothes.Builders
{
    /// <summary>
    /// abstract character builder
    /// </summary>
    abstract class CharacterBuilder
    {
        protected Character _character;
        protected string _imagesRootPath;

        public Character GetCharacter()
        {
            return _character;
        }

        public void SetCharacter(Character character)
        {
            if (_character == null)
                _character = new Character();

            _character.CopyProperties(character);
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
