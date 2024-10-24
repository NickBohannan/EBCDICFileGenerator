﻿using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        byte[] ebcdicData = new byte[] {
            0xC5,
            0xD9,
            0xD9,
            0xD6,
            0xD9,
            0x40,
            0xF1,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x25,
            0xC5,
            0xD9,
            0xD9,
            0xD6,
            0xD9,
            0x7A,
            0x40,
            0xC1,
            0x95,
            0x40,
            0x89,
            0xA2,
            0xA2,
            0xA4,
            0x85,
            0x40,
            0x88,
            0x81,
            0xA2,
            0x40,
            0x96,
            0x83,
            0x83,
            0xA4,
            0x99,
            0x99,
            0x85,
            0x84,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x25,
            0xC5,
            0xD9,
            0xD9,
            0xD6,
            0xD9,
            0x7A,
            0x40,
            0xC4,
            0x89,
            0xA2,
            0x92,
            0x40,
            0x86,
            0x81,
            0x89,
            0x93,
            0xA4,
            0x99,
            0x85,
            0x40,
            0x84,
            0x85,
            0xA3,
            0x85,
            0x83,
            0xA3,
            0x85,
            0x84,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x40,
            0x25
        };

        string outputFilePath = "mainframe_ebcdic_file.dat";

        // Write the bytes to a file (this simulates a mainframe file in EBCDIC encoding)
        File.WriteAllBytes(outputFilePath, ebcdicData);

        Console.WriteLine($"EBCDIC encoded file saved at {outputFilePath}");
    }
}
