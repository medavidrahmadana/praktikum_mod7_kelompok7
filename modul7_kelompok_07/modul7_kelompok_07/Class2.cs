﻿using System;
using System.IO;
using System.Text.Json;

class TeamMembers_1302213050
{
    public class Anggota
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public List<Anggota> members { get; set; }

    public void ReadJSON(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        TeamMembers_1302213050 dataAnggota = JsonSerializer.Deserialize<TeamMembers_1302213050>(jsonString);

        Console.WriteLine("====================================================================");
        Console.WriteLine("Daftar member:");
        foreach (Anggota member in dataAnggota.members)
        {
            Console.WriteLine("{0} {1} {2} ( {3} - {4} )", member.nim, member.firstName, member.lastName, member.age, member.gender);
        }
        Console.WriteLine("====================================================================");
    }
}
