using System;
using System.Collections.Generic;
using System.Linq;

namespace WeaponsReport
{
    internal class Database
    {
        private List<Soldier> _soldiers = new List<Soldier>();

        public Database()
        {
            AddSoldiers();
        }

        public void GetDataSoldiers()
        {
            var sortDataList = from data in _soldiers select new { name = data.Name, militaryRank = data.MilitaryRank };

            foreach (var data in sortDataList)
            {
                Console.WriteLine($"{data.name} - {data.militaryRank}");
            }
        }

        private void AddSoldiers()
        {
            _soldiers.Add(new Soldier("Солдат1", "Автомат", "Сержант", 12));
            _soldiers.Add(new Soldier("Солдат2", "Винтовка", "Старший - Сержант", 10));
            _soldiers.Add(new Soldier("Солдат3", "Пулимет", "Младший - Сержант", 5));
            _soldiers.Add(new Soldier("Солдат4", "Гранотамет", "Рядовой", 8));
            _soldiers.Add(new Soldier("Солдат5", "Пистолет", "Ефрейтор", 12));
        }
    }
}