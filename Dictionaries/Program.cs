using System;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(122, "Ahmet Yeşim");
            students.Add(1375, "Sevgi Sevinç");
            students.Add(872, "Suat Varlı");
            students.Add(1220, "Yeliz Kar");
            students.Add(367, "Mehmet Yılmaz");
        }
    }
}
