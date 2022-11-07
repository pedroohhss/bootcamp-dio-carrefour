using System;

public class Desafio {
    public static void Main() {

        //Leitura dos valores de entrada
        float valorSalario;
        if (!float.TryParse(Console.ReadLine(), out valorSalario))
        {}
        else {}
        float valorBeneficios;
        if (!float.TryParse(Console.ReadLine(), out valorBeneficios))
        {}
        else {}
        //Fim leitura dos valores de entrada

        //Definição dos valores dos impostos
        float valorImposto = 0;
        if (valorSalario >= 0 && valorSalario <= 1100) {
            //Imposto de 5%
            valorImposto = 0.05f * valorSalario;
        }
        if (valorSalario >= 1100.01 && valorSalario <= 2500) {
            //Imposto de 10%
            valorImposto = 0.10f * valorSalario;
        }
        if (valorSalario > 2500) {
            //Imposto de 15%
            valorImposto = 0.15f * valorSalario;
        }
        //Fim definição dos valores dos impostos

        //Cálculo e impressão de saida com 2 casas decimais
        float saida = valorSalario - valorImposto + valorBeneficios;
        String s = saida.ToString("0.00");
        Console.WriteLine(s);
        //Fim código
    }
}