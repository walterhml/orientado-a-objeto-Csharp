using System;

class Program
{
    static void Main()
    {
        // Criar uma instância do sistema de gerenciamento
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

    // Método construtor
    public Aluno(int matricula, string nome, int idade)
    {
        Matricula = matricula;
        Nome = nome;
        Idade = idade;
    }

    // Método para exibir informações do aluno
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Matrícula: {Matricula}, Nome: {Nome}, Idade: {Idade}");
    }
}

// Classe para representar um curso
public class Curso
{
    // Propriedades do curso
    public int Codigo { get; set; }
    public string Nome { get; set; }

    // Método construtor
    public Curso(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
    }

    // Método para exibir informações do curso
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Código: {Codigo}, Nome do Curso: {Nome}");
    }
}

// Classe para representar o sistema de gerenciamento
public class SistemaGerenciamento
{
    // Método principal do sistema
    public void Executar()
    {
        // Criando instâncias de aluno e curso
        Aluno aluno1 = new Aluno(1001, "João", 20);
        Curso curso1 = new Curso(2001, "Programação Orientada a Objetos");

        // Exibindo informações do aluno e do curso
        Console.WriteLine("Informações do Aluno:");
        aluno1.ExibirInformacoes();

        Console.WriteLine("\nInformações do Curso:");
        curso1.ExibirInformacoes();
    }
}
