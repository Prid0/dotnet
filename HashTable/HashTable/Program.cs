using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable
{

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Hashtable> emp_dat = new List<Hashtable>();

            Hashtable emp1 = new Hashtable()
            {
                {"id",324 },
                {"name","priyan" },
                {"phNo",3246234235},
                {"address","todi estate ,lower paler east" },
                {"salary",20000.00 }
            };
            emp_dat.Add(emp1);

            Hashtable emp2 = new Hashtable()
             {
                {"id",333 },
                {"name","manya" },
                {"phNo",3246234235},
                {"address","todi estate ,lower paler east" },
                {"salary",30000.00 }
             };
            emp_dat.Add(emp2);

            foreach (var emp in emp_dat)
            {
                Console.WriteLine($"--------conut : {emp.Count} --------");
                foreach (object key in emp.Keys)
                    Console.WriteLine($"{key}: {emp[key]}");
                //Console.WriteLine($"name : {emp["name"]}");
            }

            /*emp_dat.Add("id", 213);
            emp_dat.Add("name", "amit rai");
            emp_dat.Add("phNo", 2342323454);
            emp_dat.Add("address", "todi estate ,lower paler east");
            emp_dat.Add("salary", 40000.00);*/

            //Console.WriteLine($"id : {emp_dat["id"]}");
        }
    }
}
