using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<CRYPTO, List<string>> myDictionary = new Dictionary<CRYPTO, List<string>>();
            myDictionary.Add(CRYPTO.BTC, new());
            // myDictionary.Add(CRYPTO.ETH, new());



            myDictionary[CRYPTO.BTC].Add("Hai Effettuato la transazione di 1000 EURO");
            myDictionary[CRYPTO.BTC].Add("Hai Effettuato la transazione di 200 EURO");

            //myDictionary[CRYPTO.ETH].Add("Hai Effettuato la transazione di 5000 EURO");
            //myDictionary[CRYPTO.ETH].Add("Hai Effettuato la transazione di 50 EURO");

            foreach (var item in myDictionary.Keys) // KEY + VALUE
            {
                Console.WriteLine(item);
            }

            if (myDictionary.ContainsKey(CRYPTO.BTC)) 
            {
                Console.WriteLine($"ETH is { true}");

            }
            if (myDictionary.ContainsKey(CRYPTO.ETH))
            {
                Console.WriteLine($"ETH is { true}");

            }
            else
            {
                Console.WriteLine($"ETH is { false}");
            }



            Dictionary<string, Dictionary<ACCOUNT,List<string>>> banca = 
                      new Dictionary<string, Dictionary<ACCOUNT, List<string>>>();

            banca.Add("FRRBNR8383HFNN4",new());

            banca["FRRBNR8383HFNN4"].Add(ACCOUNT.FIAT, new());
            banca["FRRBNR8383HFNN4"].Add(ACCOUNT.STOCK, new());
            banca["FRRBNR8383HFNN4"].Add(ACCOUNT.CRYPTO, new());

            banca["FRRBNR8383HFNN4"][ACCOUNT.FIAT].Add(" Hai prelevato 5 Euro"); 
            banca["FRRBNR8383HFNN4"][ACCOUNT.FIAT].Add(" Hai prelevato 10 Euro");

            banca["FRRBNR8383HFNN4"][ACCOUNT.CRYPTO].Add(" Hai prelevato 0.001 BTC");
            banca["FRRBNR8383HFNN4"][ACCOUNT.CRYPTO].Add(" Hai prelevato 1 ETH");

            banca["FRRBNR8383HFNN4"][ACCOUNT.STOCK].Add(" Hai comprato 5 Euro di TESLA");
            banca["FRRBNR8383HFNN4"][ACCOUNT.STOCK].Add(" Hai comprato 10 Euro APPLE");


            foreach (var item in banca["FRRBNR8383HFNN4"][ACCOUNT.CRYPTO])
            {
                Console.WriteLine(item);
            }

            

        }
    } 
    public enum CRYPTO
    {
        BTC, 
        ETH
    } 

    public enum ACCOUNT
    {
        FIAT, 
        CRYPTO, 
        STOCK
    }
}
