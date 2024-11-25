using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace TextEditor{

class Program{

    public static void Main(string[] args){
        Menu();

    }

    static void Menu(){
        Console.WriteLine("Select an option: ");
        Console.WriteLine("1 - Open file");
        Console.WriteLine("2 - Create file");
        Console.WriteLine("0 - Exit ");

        short option = short.Parse(Console.ReadLine());

        switch(option){
            
            case 0: System.Environment.Exit(0);
            break;

            case 1: Open();
            break;

            case 2: Create();
            break;

            default: Menu();
            break;
        }
    }

    static void Open(){

    }

    static void Create(){
        Console.Clear();
        Console.WriteLine("Type your text below: ");
        Console.WriteLine("Press ESC to Exit");
        Console.WriteLine("---------------------");

        string text = "";

        do{
            text += Console.ReadLine();
            text += Environment.NewLine;

        }
        
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Write(text);

        Save(text);
    }

    static void Save(string text){
        Console.Clear();
        Console.WriteLine("Where is the directory's destiny to save?");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path)){
            file.Write(text);
        }

        Console.WriteLine("The file is saved!{0}",path);
        Menu();

    }
}
}