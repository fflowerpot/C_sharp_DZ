using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;


namespace C_DZ._16_06_2023
{
    //--------------------------------------------------1------------------------------------------------------------//
    /*
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of fractions:");
            int count = int.Parse(Console.ReadLine());

            Fraction[] fractions = new Fraction[count];

            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the numerator for fraction {0}:", i + 1);
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the denominator for fraction {0}:", i + 1);
                int denominator = int.Parse(Console.ReadLine());

                fractions[i] = new Fraction(numerator, denominator);
            }

            
            string json = JsonConvert.SerializeObject(fractions);

            // Збереження серіалізованого масиву у файл
            string filePath = "fractions.json";
            File.WriteAllText(filePath, json);

            Console.WriteLine("Array of fractions serialized and saved to file: {0}", filePath);

            // Завантаження та десеріалізація масиву з файлу
            string loadedJson = File.ReadAllText(filePath);
            Fraction[] loadedFractions = JsonConvert.DeserializeObject<Fraction[]>(loadedJson);

            Console.WriteLine("Array of fractions loaded from file:");
            foreach (Fraction fraction in loadedFractions)
            {
                Console.WriteLine(fraction);
            }
        }
    }

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
    }
    */


    //-----------------------------------------------------------------------------------2------------------------------------------------------------//
    /*
    class Program
    {
        static void Main()
        {
            Magazine magazine = new Magazine();

            Console.WriteLine("Enter the magazine details:");
            Console.Write("Title: ");
            magazine.Title = Console.ReadLine();

            Console.Write("Publisher: ");
            magazine.Publisher = Console.ReadLine();

            Console.Write("Publication Date: ");
            magazine.PublicationDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Number of Pages: ");
            magazine.NumberOfPages = int.Parse(Console.ReadLine());


            // Серіалізація тільки Title і Publisher
            XmlSerializer serializer = new XmlSerializer(typeof(Magazine), new XmlRootAttribute("Magazine"));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, magazine);
            string serializedMagazine = writer.ToString();

            string filePath = "magazine.xml";
            File.WriteAllText(filePath, serializedMagazine);

            Console.WriteLine("Serialized magazine saved to file: " + filePath);

            // Завантаження та десеріалізація журналу з файлу
            string loadedMagazine = File.ReadAllText(filePath);
            Magazine deserializedMagazine;
            using (StringReader reader = new StringReader(loadedMagazine))
            {
                deserializedMagazine = (Magazine)serializer.Deserialize(reader);
            }

            Console.WriteLine("Deserialized Magazine Details:");
            Console.WriteLine("Title: " + deserializedMagazine.Title);
            Console.WriteLine("Publisher: " + deserializedMagazine.Publisher);
        }
    }

    public class Magazine
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlIgnore]
        public DateTime PublicationDate { get; set; }

        [XmlIgnore]
        public int NumberOfPages { get; set; }
    }
    */
}

