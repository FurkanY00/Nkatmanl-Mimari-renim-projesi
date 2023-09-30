using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer;
using dataacceslayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<entitypersonel> llpersonellistesi()
        {
            return dalpersonel.personellistesi(); ;
        }
        public static int llpersonelekle(entitypersonel p)
        {
            if(p.Ad!=""&&p.Soyad!=""&&p.Maas>=12000 &&p.Ad.Length>=3)
            {
                return dalpersonel.personelekle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool llpersonelsil(int per)
        {
            if(per>1)
            {
                return dalpersonel.personelsil(per); 
            }
            else
            {
                return false;
            }
        }
        public static bool llpersonelguncelle(entitypersonel ent)
        {
            if(ent.Ad.Length>=3&& ent.Ad!=""&&ent.Maas>=9000) 
            {
                return dalpersonel.personelguncelle(ent);

            }
            else
            {
                return false;
            }
        }
        
    }
}
