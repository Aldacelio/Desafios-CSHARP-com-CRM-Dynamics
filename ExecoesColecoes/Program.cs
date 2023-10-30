string[] linhas = File.ReadAllLines("Arquivos/texto.txt");

foreach(string linha in linhas){
    Console.WriteLine(linha);
}