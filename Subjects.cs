using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoReflection
{
    internal class Subjects
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public bool Obrigatoria { get; set; }
        private decimal Nota { get; set; } = 0;

        public void SomarNotas(decimal nota1, decimal nota2)
        {
            Nota = nota1 + nota2;
        }
        public void Situacao()
        {
            string result = "Reprovado";
            if (Nota > 7)
                result = "Aprovado";
            Console.WriteLine($"A nota é {Nota}, o aluno está {result}");
        }

        public string ToString()
        {
            var result = "obrigatório";
            if (!Obrigatoria)
                result = "optativo";

            return $"{Nome} com carga horária de {CargaHoraria}hrs e caráter {result}.";
        }
    }
}
