﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexico_3 {
    class Program {
        static void Main(string[] args) {
            try {
                using (Lexico l = new Lexico("prueba.cpp")) {
                    while (!l.finArchivo()) {
                        l.nexToken();
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}