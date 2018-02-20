using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Tentti_tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piste> pisteet = new List<Piste>();
            Piste p1 = new Piste("P1", 1.0, 2.0);
            Piste p2 = new Piste("P2", 3.5, 6.2);
            pisteet.Add(p1);
            pisteet.Add(p2);
            // Sarjallistaminen ja tulostus
            string jsonString = JsonConvert.SerializeObject(pisteet);
            Console.WriteLine(jsonString);

            //Binääritiedoston lukeminen ja tulostus, sekä lisäys listaan
            FileStream stream = new FileStream("C:\\tmp\\Tentti\\bindataTentti.bin", FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);

            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            while (reader != null && reader.BaseStream.Position < reader.BaseStream.Length)
            {
                string nimi = reader.ReadString();
                double x = reader.ReadDouble();
                double y = reader.ReadDouble();
                Piste p = new Tentti_tehtava2.Piste(nimi, x, y);
                pisteet.Add(p);
                Console.WriteLine(p.ToString());
            }
            // Listan sarjallistaminen ja tulostus
            string jsonList = JsonConvert.SerializeObject(pisteet);
            Console.WriteLine(jsonList);
        }
    }
}
