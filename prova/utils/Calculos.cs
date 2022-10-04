using System;
using API.Models;


namespace API.Utils
{
    public class Calculos {

        public double salariobruto(int horas, double valor) {
        return horas * valor;
        }


        public double impostoinss(double bruto) {
        if (bruto <= 1693.72) {
            return bruto * .08;
        } else if (bruto <= 2822.9) {
            return bruto * .09;
        } else if (bruto <= 5645.8) {
            return bruto * .11;
        }
        return 621.03;
         }


        public double impostofgts(double bruto) {
         return bruto * .08;
        }



         public double salarioliquido(double bruto,
            double irrf, double inss) {
            return bruto - irrf - inss;
         }
    }
}