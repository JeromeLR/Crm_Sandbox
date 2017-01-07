using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using BS;

namespace ntier
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            var bs = BusinessService.Instance;

            var c1 = bs.Societe.GetSocieteById(1);

            var c2 = bs.Societe.GetSocieteByNom("ikea");

            Console.WriteLine("soc Id 1 : {0}",c1.Nom);
            Console.WriteLine("Id soc nom 'ikea' : {0}",c2.Identifiant);


            var liste = bs.Societe.GetAllSocietes();
            
            foreach(var c in liste)
            {
                Console.WriteLine("{0} : {1} {2} {3} {4}", c.Identifiant, c.Nom, c.Nom, c.TelephoneStandard,c.Remarque);
            }


            Console.ReadLine();
        }
    }
}
