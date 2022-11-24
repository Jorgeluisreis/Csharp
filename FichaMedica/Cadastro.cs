using System;

namespace FichaMedica
{
    class Cadastro
    {
        private int idade;
        private float altura, peso;
        private string nome, sobrenome, doenca, fatorRH;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        public string FatorRH { get => fatorRH; set => fatorRH = value; }
        public string Doenca { get => doenca; set => doenca = value; }

        public string NomeCompleto
        {
            get
            {
                return nome + " " + sobrenome;
            }
        }

        public float Altura { get => altura; set => altura = value; }

        public float Peso { get => peso; set => peso = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}