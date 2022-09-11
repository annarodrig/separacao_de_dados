//Cria a variável com os valores e separa os dados utilizando o separador ","

string dados = ("Anna,89,78,Maria,78,Jose,Mateus,8,6,415,230,45.0,Modal GR");
string[] numeros = dados.Split(",");

//Exibe os dados separados

Console.WriteLine("==== Dados separados ====\n");

foreach (var numero in numeros) {

    System.Console.WriteLine($"Dado: {numero}");

}