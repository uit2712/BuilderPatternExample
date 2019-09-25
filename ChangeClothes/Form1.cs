using ChangeClothes.Builders;
using ChangeClothes.ConcreteBuilders;
using ChangeClothes.ConcreteProducts;
using ChangeClothes.Custom;
using ChangeClothes.Directors;
using ChangeClothes.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ChangeClothes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitStylist();
            InitComboBox<Character>(cbbCharacter);
            InitComboBox<CharacterBuilder>(cbbStylist);
            InitPanelCharacter();
        }

        private Stylist _stylist = new Stylist();
        private CharacterBuilder _characterBuilder;
        private Graphics _graphics;

        private void InitComboBox<T>(ComboBox comboBox) where T : class
        {
            // create instances of every subclass of Character
            IEnumerable<T> exporters = typeof(T)
                    .Assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(T)) && !t.IsAbstract)
                    .Select(t => (T)Activator.CreateInstance(t));

            foreach(T instance in exporters)
                comboBox.Items.Add(new ComboBoxItem<T>(instance));

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }

        private void InitStylist()
        {
            _characterBuilder = new SexyGirl();
            _characterBuilder.SetCharacter(new Doraemon());
            _stylist.SetCharacterBuilder(_characterBuilder);
            _stylist.ConstructCharacter();
        }

        private void InitPanelCharacter()
        {
            _graphics = pnlCharacter.CreateGraphics();
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void pnlCharacter_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            if (_stylist == null || _graphics == null)
                return;

            _graphics.Clear(Color.White);
            Character character = _stylist.GetCharacter();
            if (character == null)
                return;

            using (var image = Image.FromFile(character.CharacterPath))
                _graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            using (var image = Image.FromFile(character.HatPath))
                _graphics.DrawImage(image, character.TopHead);
            using (var image = Image.FromFile(character.GlassesPath))
                _graphics.DrawImage(image, character.Eyes);
            using (var image = Image.FromFile(character.LipsPath))
                _graphics.DrawImage(image, character.Lips);
            using (var image = Image.FromFile(character.ShirtPath))
                _graphics.DrawImage(image, character.UpperBody);
            using (var image = Image.FromFile(character.TrousersPath))
                _graphics.DrawImage(image, character.LowerBody);
            using (var image = Image.FromFile(character.NecklacePath))
                _graphics.DrawImage(image, character.Neck);
            using (var image = Image.FromFile(character.ShoesPath))
                _graphics.DrawImage(image, character.Foot);
        }

        private void cbbCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem<Character> selectedItem = comboBox.SelectedItem as ComboBoxItem<Character>;
            _characterBuilder.SetCharacter(selectedItem.Value);
            Draw();
        }

        private void cbbStylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem<CharacterBuilder> selectedItem = comboBox.SelectedItem as ComboBoxItem<CharacterBuilder>;
            if(_stylist == null)
                return;

            Character character = _stylist.GetCharacter();
            if (character == null)
                return;

            _characterBuilder = selectedItem.Value;
            _characterBuilder.SetCharacter(character);
            _stylist.SetCharacterBuilder(_characterBuilder);
            _stylist.ConstructCharacter();
            Draw();
        }
    }
}
