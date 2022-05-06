using System;


namespace SimpleToPark
{
    public class GerenciadorArrecadacao
    {
        public float ValorHora { get; set; }
        private float Arrecadacao;

        public float Arrecadado
        {
            get => Arrecadacao;
            set => Arrecadacao += value;
        }


        public float CalculoEstadia(DateTime entrada)
        {
            var permanencia = DateTime.Now - entrada;

            if (permanencia.Hours <= 0)
                return ValorHora;

            return ValorHora * permanencia.Hours;

        }
    }
}
