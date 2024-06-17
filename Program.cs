using System;

namespace TestandoFactoryAndBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new PessoaBuilder()
                .Nome("Pablo")
                .Sobrenome("Eduardo")
                .Documento("123456789")
                .Email("Pablo.eduardo@example.com")
                .Apelido("devPablo")
                .DataDeNascimento("15/05/2002")
                .Build();

            Console.WriteLine(pessoa1);
        }
    }

    public class Pessoa
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public string Documento { get; }
        public string Email { get; }
        public string Apelido { get; }
        public string DataDeNascimento { get; }

        public Pessoa(string nome, string sobrenome, string documento, string email, string apelido, string dataDeNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
            Apelido = apelido;
            DataDeNascimento = dataDeNascimento;
        }

        // Sobrescrever o método ToString para exibir as informações de Pessoa
        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}\nDocumento: {Documento}\nEmail: {Email}\nApelido: {Apelido}\nData de Nascimento: {DataDeNascimento}";
        }
    }

    public class PessoaBuilder
    {
        private string nome;
        private string sobrenome;
        private string documento;
        private string email;
        private string apelido;
        private string dataDeNascimento;

        public PessoaBuilder Nome(string nome)
        {
            this.nome = nome;
            return this; // Retorna o próprio PessoaBuilder
        }

        public PessoaBuilder Sobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
            return this;
        }

        public PessoaBuilder Documento(string documento)
        {
            this.documento = documento;
            return this;
        }

        public PessoaBuilder Email(string email)
        {
            this.email = email;
            return this;
        }

        public PessoaBuilder Apelido(string apelido)
        {
            this.apelido = apelido;
            return this;
        }

        public PessoaBuilder DataDeNascimento(string dataDeNascimento)
        {
            this.dataDeNascimento = dataDeNascimento;
            return this;
        }

        public Pessoa Build()
        {
            return new Pessoa(nome, sobrenome, documento, email, apelido, dataDeNascimento);
        }
    }
}
