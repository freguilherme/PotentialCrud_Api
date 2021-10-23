using System;

namespace PotentialCrud.Data
{
    public class Developer
    {
        private DateTime _dataNascimento;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public string Hobby { get; set; }
       
        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento.Date;
            }
            set
            {
                _dataNascimento = value.Date;
            }
        }
    }
}
