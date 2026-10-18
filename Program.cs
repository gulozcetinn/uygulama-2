using System;
using System.Collections.Generic;
class Program
{
    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (var numara in liste)
        {
            if (numara== aranan)
            {
                return true;
            }
        }
        return false;
    }
    static void Main()
    {
        //örnek 
        List<string> telefonlar = new List<string>() { "05321112233","05423334455", "05556667788" };
        // listede olan ilk eleman
        Console.WriteLine("İlk eleman aranıyor: " + NumaraVarMi(telefonlar, "05321112233"));
        // listede olan son eleman
        Console.WriteLine("Son eleman aranıyor: " + NumaraVarMi(telefonlar, "05556667788"));
        // listede olmayan eleman
        Console.WriteLine("Olmayan eleman aranıyor: " + NumaraVarMi(telefonlar, "05003377788"));
        // boş listede arama
        List<string> bosListe = new List<string>();
        Console.WriteLine("Boş listede arama: " + NumaraVarMi(bosListe, "05321112233"));
     }
}
