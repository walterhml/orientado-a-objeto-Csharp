using System;

class Program
{
    static void Main()
    {
        // Criar uma inst�ncia do sistema de gerenciamento
        SistemaGerenciamento sistema = new SistemaGerenciamento();

        // Executar o sistema
        sistema.Executar();
    }
}


// Classe para representar um aluno
public class Aluno
{
    // Propriedades do aluno
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    // M�todo construtor
    public Aluno(int matricula, string nome, int idade)
    {
        Matricula = matricula;
        Nome = nome;
        Idade = idade;
    }

    // M�todo para exibir informa��es do aluno
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Matr�cula: {Matricula}, Nome: {Nome}, Idade: {Idade}");
    }
}

// Classe para representar um curso
public class Curso
{
    // Propriedades do curso
    public int Codigo { get; set; }
    public string Nome { get; set; }

    // M�todo construtor
    public Curso(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
    }

    // M�todo para exibir informa��es do curso
    public void ExibirInformacoes()
    {
        Console.WriteLine($"C�digo: {Codigo}, Nome do Curso: {Nome}");
    }
}

// Classe para representar o sistema de gerenciamento
public class SistemaGerenciamento
{
    // M�todo principal do sistema
    public void Executar()
    {
        // Criando inst�ncias de aluno e curso
        Aluno aluno1 = new Aluno(1001, "Jo�o", 20);
        Curso curso1 = new Curso(2001, "Programa��o Orientada a Objetos");

        // Exibindo informa��es do aluno e do curso
        Console.WriteLine("Informa��es do Aluno:");
        aluno1.ExibirInformacoes();

        Console.WriteLine("\nInforma��es do Curso:");
        curso1.ExibirInformacoes();
    }
}
