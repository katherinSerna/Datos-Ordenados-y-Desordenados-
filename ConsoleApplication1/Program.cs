using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Alumna : Katherin serna Meza
//Repositorio : 2
//Programa: "Ordena y desordena datos"

interface IImprimible
{

    void Imprime();
    void Imprime(int n);
}

class usuario : IComparable
{
    public string nombre, correo;
    public usuario(string n, string c)
    {
        this.nombre = n;
        this.correo = c;
    }

    public override string ToString()
    {
        return String.Format("{0}: {1}", this.nombre, this.correo);
    }




    public int CompareTo(object o)
    {
        usuario usr = (usuario)o;
        return this.nombre.CompareTo(((usuario)o).nombre);


    }
}




class Program
{
    static private List<usuario> usuarios = new List<usuario>();


    static void Main(string[] args)
    {



        usuarios.Add(new usuario("ana", "ana@gmail.com"));
        usuarios.Add(new usuario("Juanita", "ana@gmail.com"));
        usuarios.Add(new usuario("Maria", "ana@gmail.com"));
        usuarios.Add(new usuario("Laura no esta", "ana@gmail.com"));
        usuarios.Add(new usuario("ana", "ana@gmail.com"));

        Console.WriteLine("Desordenadps");
        foreach (usuario u in usuarios)
        {

            Console.WriteLine(u);
        }

        usuarios.Sort();
        Console.WriteLine("Ordenados");

        foreach (usuario u in usuarios)
        {
            Console.WriteLine(u);
        }


        Console.ReadKey();
    }
}
