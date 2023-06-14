namespace ClothesMagazine
{
    public class Cloth
    {
		private string _color;
        private int _size;
        private string _type;

        public Cloth(string color, int size, string type)
        {
            Color = color;
			Size = size;
			Type = type;
        }

        public string Color
		{
			get { return _color; }
			set { _color = value; }
		}

		public int  Size
		{
			get { return _size; }
			set { _size = value; }
		}

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public override string ToString()
		{
			return $"Product: {Type} with size {Size}, color {Color}";
		}
	}
}
