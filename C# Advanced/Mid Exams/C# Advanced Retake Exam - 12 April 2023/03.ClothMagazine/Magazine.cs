using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
		private string _type;
        private int _capacity;
        private List<Cloth> _clothes;

        public Magazine(string type, int capacity)
        {
			Type = type;
            Clothes = new List<Cloth>();
			Capacity = capacity;
        }

        public string Type
		{	
			get { return _type; }
			set { _type = value; }
		}

		public int Capacity
		{
			get { return _capacity; }
			set { _capacity = value; }
		}

		public List<Cloth> Clothes
		{
			get { return _clothes; }
			set { _clothes = value; }
		}

		public void AddCloth(Cloth cloth)
		{
			if (Capacity > 0)
			{
				Clothes.Add(cloth);
				Capacity--;
			}
		}

		public bool RemoveCloth(string color)
		{
			Cloth currentCloth = Clothes.FirstOrDefault(c => c.Color == color);

			if (currentCloth != null)
			{
				Clothes.Remove(currentCloth);
				Capacity--;
				return true;
			}

			return false;
		}

		public Cloth GetSmallestCloth()
		{
			return Clothes.OrderBy(c => c.Size).FirstOrDefault();
		}

		public Cloth GetCloth(string color)
		{
			return Clothes.FirstOrDefault(c => c.Color == color);
		}

		public int GetClothCount()
		{
			return Clothes.Count;
		}

		public string Report()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{this.Type} magazine contains:");

			foreach (Cloth cloth in Clothes.OrderBy(s => s.Size))
			{
				sb.AppendLine($"{cloth}");
			}

			return sb.ToString().TrimEnd();
		}
	}
}
