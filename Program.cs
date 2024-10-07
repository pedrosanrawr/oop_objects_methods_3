using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_objects_methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call class
            Character c = new Character("Layla", "Time to Shine", 100, 50, 1);
            //introduce output
            c.introduce();
            //sayDialog output
            c.sayDialog();
            //checkStat output
            c.checkStat();
        }

        //class
        public class Character
        {
            public string name, dialog;
            public int hp, mp, lvl;

            //constructor
            public Character(string name, string dialog, int hp, int mp, int lvl)
            {
                this.name = name;
                this.dialog = dialog;
                this.hp = hp;
                this.mp = mp;
                this.lvl = lvl;
            }

            //method - introduce
            public void introduce()
            {
                Console.WriteLine("I am " + name);
            }

            //method - sayDialog
            public void sayDialog()
            {
                Console.WriteLine(name + " : " + dialog);
            }

            //method - checkStat
            public void checkStat()
            {
                Console.WriteLine("name: " + name);
                Console.WriteLine("hp: " + hp);
                Console.WriteLine("mp: " + mp);
                Console.WriteLine("lvl: " + lvl);
            }
        }
    }
}
