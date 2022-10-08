using System;
using System.Collections;


namespace collections
{
    class collections
    {
        public static void Main()
        {
            dictionary();
            Hashvalue();
        }
        public static void dictionary()
        {
            //here we need to specify the datatype(string ,string)
            Dictionary<string, string> dt = new Dictionary<string, string>();
            dt.Add("A", "john");
            dt.Add("B", "shri");
            dt.Add("C", "rishi");
            Console.WriteLine("dictionary keys are : ");
            foreach (string key in dt.Keys)
            {
                Console.WriteLine("keys:" + key);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("dictionary values are : ");
            foreach (string value in dt.Values)
            {
                Console.WriteLine("key values:" + value);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Key: {dt["C"]}");
            //If the key is not found -> raise an exception
            //Console.WriteLine($"Key: {dt[1]}");
            Console.WriteLine("-----------------------------");

        }
        public static void Hashvalue()
        {
            //here it takes random datatype,not required to mention any datatype
            Hashtable ht = new Hashtable();
            ht.Add(1, "james");
            ht.Add(2, "sam");
            ht.Add(3, "rick");
            Console.WriteLine("hashtable key - values are : ");
            foreach (var key in ht.Keys)
            {
                Console.Write(key+"\t");
                Console.WriteLine(ht[key]);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Key: {ht[1]}");
            //If the key is not found -> null value
            Console.WriteLine($"Key: {ht[4]}");
            Console.WriteLine("-----------------------------");
        }
    }
}