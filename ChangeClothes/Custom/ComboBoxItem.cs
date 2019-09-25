namespace ChangeClothes.Custom
{
    class ComboBoxItem<T> where T: class
    {
        public T Value { get; set; }

        public ComboBoxItem(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.GetType().Name;
        }
    }
}
