using System.Reflection;

namespace TreinandoReflection
{
    internal class Program
    {
        // Crie um método que receba um objeto genérico e liste as propriedades e métodos dele
        static void ListPropAndMethods<T>(T obj)
        {
            var myType = obj.GetType();

            var properties = myType.GetProperties();
            Console.WriteLine("Propriedades: \n");
            foreach (var property in properties)
                Console.WriteLine(property.Name);

            var methods = myType.GetMethods();
            Console.WriteLine("\nMétodos: \n");
            foreach (var method in methods)
                Console.WriteLine(method.Name);

        }

        // Crie um método que receba um objeto genérico e crie uma instância dele e a retorne

        static T Instantiate<T>()
        {
            return Activator.CreateInstance<T>();
        }

        static void Main(string[] args)
        {
            // Teste listagem de propriedades e metódos

            var materia = new Subjects
            {
                Nome = "Resistência dos Materiais",
                CargaHoraria = 60,
                Obrigatoria = true
            };

            ListPropAndMethods(materia);

            Console.WriteLine("\n\n");
            // Teste criar instância

            var materiaInstanciada = Instantiate<Subjects>();
            Console.WriteLine(materiaInstanciada);
            var nomeMateria = materiaInstanciada.GetType().GetProperty("Nome");
            nomeMateria.SetValue(materiaInstanciada, "Saneamento Básico III");
            var cargaMateria = materiaInstanciada.GetType().GetProperty("CargaHoraria");
            cargaMateria.SetValue(materiaInstanciada, 60);
            var tipoMateria = materiaInstanciada.GetType().GetProperty("Obrigatoria");
            tipoMateria.SetValue(materiaInstanciada, false);

            Console.WriteLine(materiaInstanciada.ToString());

        }
    }
}