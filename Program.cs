﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lexico_3 {
    class Program {
        static void Main(string[] args) {
            bool usarTRAND = true;
            try {
                using (Lexico l = new Lexico("Prueba.cpp")) {
                    while (!l.finArchivo()) {
                        l.nexToken(usarTRAND);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}