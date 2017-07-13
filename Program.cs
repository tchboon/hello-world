using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{

    class CArk
    {

        public List<CHAnimal> animList = new List<CHAnimal>();
        public List<CHVariety> varyList = new List<CHVariety>();
        public int TotalVarieties;
        public int TotalAnimals;

        public int AddAnimal(string name, string vary)
        {

            CHAnimal anim = new CHAnimal();

            anim.name = name;
            anim.vname = vary;
            animList.Add(anim);
            TotalAnimals = animList.Count;

            return 1;

        }

        public int AddVariety(string name)
        {
            CHAnimal anim = new CHAnimal();

            anim.name = name;
            anim.vname = vary;
            animList.Add(anim);
            TotalAnimals = animList.Count;

            return 1;

        }

    }

    class CHAnimal: CHVariety
    {
        public string name;
        public string character;
    }

    class CHVariety : CHSpecies
    {
        public string vname;
        public string vcharacter;
    }

    class CHSpecies: CHGenus
    {
        public string sname;
        public string scharacter;
    }

    class CHGenus: CHFamily
    {
        public string gname;
        public string gcharacter;
    }

    class CHFamily: CHOrder
    {
        public string fname;
        public string fcharacter;
    }

    class CHOrder: CHClass
    {
        public string oname;
        public string ocharacter;
    }

    class CHClass
    {
        public string cname;
        public string ccharacter;
    }

    class Program
    {

        static public CArk theArk = new CArk();

            static public void DisplayRecords()
        {

            Console.WriteLine("SNo   Animal    Variety    Species    Genus    Family    Order    Class");
            Console.WriteLine("_____________________________________________________________________");

            for (int i = 0; i < theArk.TotalAnimals; i++)
            {
                Console.Write("{0, -7}", i);
                Console.Write("{0, -10}", theArk.animList[i].name);
                Console.Write("{0, -10}", theArk.animList[i].vname);
                Console.Write("{0, -10}", theArk.animList[i].sname);
                Console.Write("{0, -10}", theArk.animList[i].gname);
                Console.Write("{0, -10}", theArk.animList[i].fname);
                Console.Write("{0, -10}", theArk.animList[i].oname);
                Console.Write("{0, -10}", theArk.animList[i].cname);
                Console.Write("\n");
            }

        } // ViewRecords


        static void Main(string[] args)
        {
            string s = "blank";
            int n = 10;




            Console.Write("Hello\n");
            Console.WriteLine("Noah's Ark Animal Inventory : \n");

            theArk.AddAnimal("Horse1", "");
            theArk.AddAnimal("Cattle1", "");
            theArk.AddAnimal("Dog1", "Alsatian");
            theArk.AddAnimal("Cat1", "Persian");
            theArk.AddAnimal("Mouse1", "");

            DisplayRecords();

            Console.Read();

        }
    }
}
