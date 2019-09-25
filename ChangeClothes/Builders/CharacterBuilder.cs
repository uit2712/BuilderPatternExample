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

            _character.CharacterPath = character.CharacterPath;
            _character.TopHead = character.TopHead;
            _character.Eyes = character.Eyes;
            _character.Lips = character.Lips;
            _character.Neck = character.Neck;
            _character.UpperBody = character.UpperBody;
            _character.LowerBody = character.LowerBody;
            _character.Foot = character.Foot;
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
