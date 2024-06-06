using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsReport
{
    internal class Database
    {
        private List<Soldier> _soldiers = new List<Soldier>();

        public Database() 
        {
            AddSoldiers();
        }

        private void AddSoldiers()
        {
            _soldiers.Add(new Soldier("Солдат1","Автомат","Сержант",12));
            _soldiers.Add(new Soldier("Солдат2", "Винтовка", "Старший - Сержант", 10));
            _soldiers.Add(new Soldier("Солдат3", "Пулемет", "Младший - Сержант", 5));
            _soldiers.Add(new Soldier("Солдат4", "Гранотамет", "Рядовой", 8));
            _soldiers.Add(new Soldier("Солдат5", "Пистолет", "Ефрейтор", 12));
        }
    }
}
