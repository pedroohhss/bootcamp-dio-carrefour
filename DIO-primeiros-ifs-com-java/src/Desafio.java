import java.util.Scanner;

public class Desafio {
	
	public static void main(String[] args) {
		
		//Leitura dos Valores de entrada
		Scanner in = new Scanner(System.in);
		float valorSalario = in.nextFloat();
		float valorBeneficios = in.nextFloat();
		//Fim leitura dos valores
		
		//definição valores dos impostos
		float valorImposto = 0;
		if(valorSalario >=0 && valorSalario <= 1100) {
			//Imposto de 5%
			valorImposto = 0.05f * valorSalario;
		}
		if(valorSalario >= 1100.01 && valorSalario <=2500) {
			//Imposto de 10%
			valorImposto = 0.10f * valorSalario;
		}
		if (valorSalario > 2500) {
			//Imposto de 15%
			valorImposto = 0.15f * valorSalario;
		}
		//fim definição valores dos impostos
		
		//Cálculo e impressão da saida com 2 casas decimais
		float saida = valorSalario - valorImposto + valorBeneficios;
		System.out.println(String.format("%.2f", saida));
		//fim código
	}
}