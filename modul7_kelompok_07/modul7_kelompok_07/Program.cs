using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302213079 mahasiswa = DataMahasiswa_1302213079.ReadJSON("jurnal7_1_1302213079.json");
        TeamMembers_1302213079 dataAnggota = new TeamMembers_1302213079();
        dataAnggota.ReadJSON("jurnal7_2_1302213079.json");
    }
}

