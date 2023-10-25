public class Menu{

    //mensagem que mostra o menu com todas as opções
    public void mensagem(){
        var mensagem = "-------------------------------\n" +
                       "|      Escolha uma opção      |\n" +
                       "-------------------------------\n" +
                       "| 1 |  Mensagem de hello word | \n" +
                       "|---|-------------------------|\n" +
                       "| 2 |  Teste de aprovação     |\n" +
                       "|---|-------------------------|\n" +
                       "| 3 |  Utilizando o for       |\n" +
                       "|---|-------------------------|\n" +
                       "| 4 |  Utilizando o while     |\n" +
                       "|---|-------------------------|\n" +
                       "| 5 |  Utilizando o foreach   |\n" +
                       "|---|-------------------------|\n" +
                       "| 0 |  Sair                   |\n" +
                       "-------------------------------";
        Console.WriteLine(mensagem);
    }

    //realiza o teste de aprovação
    public int teste(){

        Console.WriteLine("Escolhe a opção desejada: ");
        char operacao = Char.Parse(Console.ReadLine());
        int aux = 0;
        switch (operacao){
            case '0':
                aux = 1;
                break;
            case '1':
                var f = new Funcionalidades();
                f.op1();
                break;
            case '2':
                var f2 = new Funcionalidades();
                aux = f2.op2();
                break;
            case '3':
                var f3 = new Funcionalidades();
                f3.op3();
                break;
            case '4':
                var f4 = new Funcionalidades();
                f4.op4();
                break;
            case '5':
                var f5 = new Funcionalidades();
                f5.op5();
                break;
        }

        if (aux == 1){
            Console.Clear();
            return aux;
        }
        else{
            mensagem();
            return aux;
        }
    }
}