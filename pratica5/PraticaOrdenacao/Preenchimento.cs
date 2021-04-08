﻿using System;

namespace Pratica5 {
    class Preenchimento {
        public static void Aleatorio(int[] vet, int limite) {
            Random r = new Random();
            for (int i = 0; i < vet.Length; i++) {
                vet[i] = r.Next(0, limite);
            }
        }
        public static void Crescente(int[] vet, int limite) {
            double Passo = limite / (vet.Length * 1.0);
            double numeroA = 0;
            for(int i = 0; i< vet.Length; i++) 
            {
                numeroA += Passo;
                vet[i] = (int)numeroA;
            }
            
        }
        public static void Decrescente(int[] vet, int limite) {
            double Passo = limite / (vet.Length * 1.0);
            double numeroA = 0;
            for (int i = vet.Length-1; i >= 0; i--)
            {
                numeroA += Passo;
                vet[i] = (int)numeroA;
            }
        }
    }
}
