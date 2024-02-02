using System;
using System.Collections.Generic;

public class Buku
{
    private string judul;
    private string penulis;
    private int tahunTerbit;

    public Buku(string judul, string penulis, int tahunTerbit)
    {
        this.judul = judul;
        this.penulis = penulis;
        this.tahunTerbit = tahunTerbit;
    }

    public string GetJudul()
    {
        return judul;
    }

    public string GetPenulis()
    {
        return penulis;
    }

    public int GetTahunTerbit()
    {
        return tahunTerbit;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Judul: {judul}");
        Console.WriteLine($"Penulis: {penulis}");
        Console.WriteLine($"Tahun Terbit: {tahunTerbit}\n");
    }
}

public class Perpustakaan
{
    private string nama;
    private List<Buku> daftarBuku;

    public Perpustakaan(string nama)
    {
        this.nama = nama;
        this.daftarBuku = new List<Buku>();
    }

    public void TambahBuku(Buku buku)
    {
        daftarBuku.Add(buku);
    }

    public void TampilkanDaftarBuku()
    {
        Console.WriteLine($"Daftar Buku di Perpustakaan {nama}:\n");
        foreach (var buku in daftarBuku)
        {
            buku.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        Buku buku1 = new Buku(" Buku 1", "Penulis 1", 2020);
        Buku buku2 = new Buku(" Buku 2", "Penulis 2", 2021);

        Perpustakaan perpustakaan1 = new Perpustakaan("Perpustakaan Utama");

        perpustakaan1.TambahBuku(buku1);
        perpustakaan1.TambahBuku(buku2);

        perpustakaan1.TampilkanDaftarBuku();
    }
}
