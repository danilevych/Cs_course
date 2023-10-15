using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void FixAndWritePhoneBook(Dictionary<string, string> phoneBook, string path)
    {
        string tempKey;
        const string uaPhoneCode = "+3";
        const string failMarker = "80";

        try
        {
            using (StreamWriter newFile = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string, string> data in phoneBook)
                {
                    tempKey = data.Key;

                    if (data.Key.StartsWith(failMarker))
                    {
                        tempKey = uaPhoneCode + data.Key;
                    }
                    newFile.WriteLine("[{0} {1}]", tempKey, data.Value);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void Main(string[] args)
    {
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        string path = @"C:\Users\User\source\repos\Cs_course\HomeWork7\mob.txt";
        string newPath = @"C:\Users\User\source\repos\Cs_course\HomeWork7\newMob.txt";

        //Task 1

        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] part = line.Split(',');

                    phoneBook.Add(part[0], part[1]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("________________________________________");


        //Task 2


        Console.WriteLine("Enter a name from the list above:");
        string name = Console.ReadLine();
        bool numberIsNotFound = true;

        foreach (string mobileNumber in phoneBook.Keys)
        {
            if (phoneBook[mobileNumber].Contains(name))
            {
                Console.WriteLine(mobileNumber);
                numberIsNotFound = false;
            }
        }
        if (numberIsNotFound)
        {
            Console.WriteLine("This name is not found!");
        }

        //Task 3

        FixAndWritePhoneBook(phoneBook, newPath);
    }
}

