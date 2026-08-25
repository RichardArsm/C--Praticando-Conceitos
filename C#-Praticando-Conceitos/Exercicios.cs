namespace C__Praticando_Conceitos;

class Exercicios
{
  
    //Estou seguindo apenas as orientações dos exercicios, não estou aprofundando em conceitos e verificações ainda.
    //Pois conheço que precisa de algumas consistencias nos exercicios.
    //Entradas validas por exemplo...

    static void Main(){
        Console.WriteLine("Exercício 1");
        Exercicio1();

        Console.WriteLine("************************************");

        Console.WriteLine("Exercício 2");
        Exercicio2();

        Console.WriteLine("************************************");

        Console.WriteLine("Exercício 3");
        Exercicio3();

        Console.WriteLine("************************************");

        Console.WriteLine("Exercício 4");
        Exercicio4();

        Console.WriteLine("************************************");

        Console.WriteLine("Exercício 5");
        Exercicio5();

        Console.WriteLine("************************************");

        Console.WriteLine("Exercício 6");
        Exercicio6();
    }

    static string? flRetornaNome()
    {
        Console.WriteLine("Qual é o seu nome?");
        return Console.ReadLine();
    }

    static int flRetornaNumero(string csPergunta) {
        Console.Write(csPergunta);
        return int.Parse(Console.ReadLine());
    }

    static void Exercicio1() {
        string? lsNome = flRetornaNome();

        Console.WriteLine($"Olá {lsNome}! Seja muito bem-vindo!");
    }

    static void Exercicio2() {
        string? lsNome = flRetornaNome();

        Console.WriteLine("Qual é o seu sobrenome?");
        string? lsSobreNome = Console.ReadLine();

        Console.WriteLine($"Olá {lsNome} {lsSobreNome}!");
    }

    static void Exercicio3() {
        int linumero1 = flRetornaNumero("Digite o primeiro número: ");
        int linumero2 = flRetornaNumero("Digite o segundo número: ");

        Console.WriteLine($"Soma: {linumero1 + linumero2}");
        Console.WriteLine($"Subtração: {linumero1 - linumero2}");
        Console.WriteLine($"multiplicação: {linumero1 * linumero2}");
        if (linumero2 > 0)
        {
            Console.WriteLine($"Divisão: {linumero1 / linumero2}");
        }
        else {
            Console.WriteLine($"Divisão: Não é possivel fazer divisão por 0");
        }
        Console.WriteLine($"Media: {(linumero1 + linumero2) / 2}");

    }

    static void Exercicio4() {
        Console.WriteLine("Digite uma palavra");
        string? lsPalavra = Console.ReadLine();

        Console.WriteLine($"A palavra contem {lsPalavra.Length} caracteres");
    }

    static void Exercicio5()
    {
        Console.Write("Digite a placa do veículo: ");
        string? lsPlaca = Console.ReadLine();

        bool lbPlacaValida = true;

        if (lsPlaca == null || lsPlaca.Length != 7)
        {
            lbPlacaValida = false;
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(lsPlaca[i]))
                {
                    lbPlacaValida = false;
                }
            }

            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(lsPlaca[i]))
                {
                    lbPlacaValida = false;
                }
            }
        }

        Console.WriteLine(lbPlacaValida ? "Verdadeiro" : "Falso");
    }

    static void Exercicio6()
    {
        DateTime ldDataAtual = DateTime.Now;

        Console.WriteLine($"Data completa: {ldDataAtual:dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss}");
        Console.WriteLine($"Apenas a data: {ldDataAtual:dd/MM/yyyy}");
        Console.WriteLine($"Apenas a hora: {ldDataAtual:HH:mm:ss}");
        Console.WriteLine($"Data com mês por extenso: {ldDataAtual:dd 'de' MMMM 'de' yyyy}");
    }

}
