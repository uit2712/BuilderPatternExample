using ChangeClothes.Builders;
using ChangeClothes.Products;

namespace ChangeClothes.Directors
{
    /// <summary>
    /// Director
    /// </summary>
    class Stylist
    {
        private CharacterBuilder _characterBuilder;

        public void SetCharacterBuilder(CharacterBuilder characterBuilder)
        {
            _characterBuilder = characterBuilder;
        }

        public Character GetCharacter()
        {
            return _characterBuilder.GetCharacter();
        }

        public void ConstructCharacter()
        {
            _characterBuilder.PaintLips();
            _characterBuilder.WearGlasses();
            _characterBuilder.WearHat();
            _characterBuilder.WearNecklace();
            _characterBuilder.WearShirt();
            _characterBuilder.WearTrousers();
            _characterBuilder.WearShoes();
        }
    }
}
