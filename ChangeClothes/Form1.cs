using ChangeClothes.Builders;
using ChangeClothes.ConcreteBuilders;
using ChangeClothes.ConcreteProducts;
using ChangeClothes.Directors;
using ChangeClothes.Products;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeClothes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _character = new Doraemon();
            _characterBuilder = new SexyGirl();
            _characterBuilder.SetCharacter(_character);
            _stylist.SetCharacterBuilder(_characterBuilder);
            _stylist.ConstructCharacter();
        }

        private Stylist _stylist = new Stylist();
        private CharacterBuilder _characterBuilder;
        private Character _character;

        private void pnlCharacter_Paint(object sender, PaintEventArgs e)
        {
            if (_stylist == null)
                return;

            Character character = _stylist.GetCharacter();
            if (character == null)
                return;

            using (var src = Image.FromFile(character.CharacterPath))
            {
                using (var gr = pnlCharacter.CreateGraphics())
                {
                    gr.DrawImage(src, new Rectangle(0, 0, src.Width, src.Height));
                    gr.DrawImage(Image.FromFile(character.HatPath), character.TopHead);
                    gr.DrawImage(Image.FromFile(character.GlassesPath), character.Eyes);
                    gr.DrawImage(Image.FromFile(character.LipsPath), character.Lips);
                    gr.DrawImage(Image.FromFile(character.ShirtPath), character.UpperBody);
                    gr.DrawImage(Image.FromFile(character.TrousersPath), character.LowerBody);
                    gr.DrawImage(Image.FromFile(character.NecklacePath), character.Neck);
                    gr.DrawImage(Image.FromFile(character.ShoesPath), character.Foot);
                }
            }
        }

        private void cbbCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
