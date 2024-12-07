decimal valorGasolina, valorEtanol, valorFinal, percentual;

Console.WriteLine("--- Etanol ou Gasolina? ---");
Console.WriteLine("Digite o preço do etanol (R$).....:");
valorEtanol = Convert.ToDecimal (Console.ReadLine());
Console.WriteLine("Digite o preço da gasolina (R$)...:");
valorGasolina = Convert.ToDecimal (Console.ReadLine());

matematica();

void abastecimento(){
    if (valorGasolina >= 70)
    {
        Console.WriteLine($"O preço do etanol corresponde a {percentual:N1}% do preço da gasolina.");
        Console.WriteLine("Recomendação: Abasteça com GASOLINA.");
    }

    else 
    {
        Console.WriteLine($"O preço do etanol corresponde a {percentual:N1}% do preço da gasolina.");
        Console.WriteLine("Recomendação: Abasteça com ETANOL.");
    }
}

abastecimento();


void matematica(){
    valorFinal = valorEtanol / valorGasolina;
    percentual = ((valorFinal * 73) / 100);
}
