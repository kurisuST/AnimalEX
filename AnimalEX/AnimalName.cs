namespace AnimalEX
{
    internal class AnimalName
        {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
        public AnimalName(string name)
        {
            Name = name;
        }
    }
}
