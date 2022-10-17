using System;
using System.Collections;
using System.Collections.Generic;
using Collections.Classes;

namespace Collections{
    class Program{
        public static void Main(string[] args) {
            DictionaryEx();
            ListEx();
        }
        static void DictionaryEx(){
        Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
        Console.WriteLine(myDictionary.Count + " book entries");
        myDictionary.Add("Tommy's big day",null);
        myDictionary.Add("Sara's going to the store",null);
        Console.WriteLine(myDictionary.Count + " book entries");
        myDictionary.Remove("Tommy's big day");
        Console.WriteLine(myDictionary.Count + " book entries");
    }
    static void ListEx(){
        List<int> myList = new List<int>();
        myList.Add(0);
        Console.WriteLine(myList.Count + " book entries");
        myList.Remove(0);
        Console.WriteLine(myList.Count + " book entries");
    }
    }
}