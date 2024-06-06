namespace WeaponsReport
{
    internal class Soldier
    {
        public Soldier(string name, string weapon, string militaryRank, int servicePeriod)
        {
            Name = name;

            Weapon = weapon;

            MilitaryRank = militaryRank;

            ServicePeriod = servicePeriod;
        }

        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string MilitaryRank { get; private set; }

        public int ServicePeriod { get; private set; }
    }
}