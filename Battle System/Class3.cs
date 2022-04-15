using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System
{
    class Class3
    {
        public class Item
        {
            public string Nama { get; protected set; }

            public override string ToString()
            {
                return "Nama: " + Nama;
            }

            public Item(string nama, int cost)
            {
                Nama = nama;
            }
        }

        public abstract class SpecialItem : Item
        {
            public SpecialItem(string name, int cost) : base(name, cost) { }
        }

        public abstract class ElementalsItem : SpecialItem
        {
            public int Nasigoreng { get; protected set; }
            public int Migoreng { get; protected set; }
            public int Babi { get; protected set; }
            public int Rendang { get; protected set; }
            public override string ToString()
            {
                return base.ToString()
                    + "\nNasigoreng Damages/Resistance: " + Nasigoreng
                    + "\nMigoreng Damages/Resistance: " + Migoreng
                    + "\nBabi Damages/Resistance: " + Babi
                    + "\nRendang Damages/Resistance: " + Rendang;


            }
            protected ElementalsItem(string name,
                                     int cost,
                                     int Nasigoreng,
                                     int Migoreng,
                                     int Babi,
                                     int Rendang)
                                     : base(name, cost)
            {
                Nasigoreng = Nasigoreng;
                Migoreng = Migoreng;
                Babi = Babi;
                Rendang = Rendang;
            }
        }
        public class Weapon : ElementalsItem
        {
            public int Damages { get; private set; }
            public override string ToString() { return base.ToString(); }

            public Weapon(string name,
                          int cost,
                          int damages,
                          int Sword = 0,
                          int Archer = 0,
                          int Spear = 0,
                          int Shield = 0)
                          :base(name, cost, Sword, Archer, Spear, Shield)

            {
                Damages = damages;
            }
        }


    }
}
