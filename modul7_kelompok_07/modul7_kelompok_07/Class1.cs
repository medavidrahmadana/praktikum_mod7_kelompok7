﻿using System;
using System.IO;
using System.Text.Json;

class DataMahasiswa_1302213050
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Alamat address { get; set;}
    public List<course> courses { get; set; }

    public class Alamat
    {
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    }

    public class course
    {
    public string code { get; set; }
    public string name { get; set; }
    }



    public static DataMahasiswa_1302213050 ReadJSON(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        DataMahasiswa_1302213050 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213050>(jsonString);

        Console.WriteLine("Nama: {0} {1} \nGender: {2} \nBerumur: {3} \nBeralamat: {4}, {5}, {6}",
        mahasiswa.firstName, mahasiswa.lastName, mahasiswa.gender, mahasiswa.age, mahasiswa.address.streetAddress, mahasiswa.address.city, mahasiswa.address.state);



    Console.WriteLine("====================================================================");
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (course course in mahasiswa.courses)
        {
            Console.WriteLine("MK {0} {1} - {2}", i++, course.code, course.name);
        }
        Console.WriteLine("====================================================================");

        return mahasiswa;
    }
}