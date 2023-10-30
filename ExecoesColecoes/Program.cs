string[] linhas = File.ReadAllLines("Arquivos/texto.txt");
try{
    foreach(string linha in linhas){
    Console.WriteLine(linha);
    }
}catch(FileNotFoundException ex){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo, arquivo não encontrado. {ex.Message}");
}catch(DirectoryNotFoundException ex){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo, pasta não encontrada. {ex.Message}");
}catch(Exception ex){
    Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
}

Console.WriteLine("Chegou até aqui.");


// Exemplo de fila

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(5);
fila.Enqueue(6);
fila.Enqueue(28);
fila.Enqueue(9);

foreach(int item in fila){
    Console.WriteLine(fila);
}

Console.WriteLine($"Removendo o elemento ---> {fila.Dequeue()} ");
fila.Enqueue(01);

foreach(int item in fila){
    Console.WriteLine(fila);
}
