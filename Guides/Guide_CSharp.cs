// Comentários de linha única começam com //
/*
Comentários de múltiplas linhas são desta forma
*/
/// <summary>
/// Este é um comentário de documentação XML que pode ser usado para gerar documentação
/// externa ou para fornecer ajuda de contexto dentro de uma IDE
/// </summary>
//public void MethodOrClassOrOtherWithParsableHelp() {}

// Especifica os namespaces que o código irá usar
// Os namespaces a seguir são padrões da biblioteca de classes do .NET Framework
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;

// Mas este aqui não é :
using System.Data.Entity;
// Para que consiga utilizá-lo, você precisa adicionar novas referências
// Isso pode ser feito com o gerenciador de pacotes NuGet : `Install-Package EntityFramework`

// Namespaces são escopos definidos para organizar o código em "pacotes" ou "módulos"
// Usando este código a partir de outro arquivo de origem: using Learning.CSharp;
namespace Learning.CSharp
{
    // Cada .cs deve conter  uma classe com o mesmo nome do arquivo
    // você está autorizado a contrariar isto, mas evite por sua sanidade.
    public class AprenderCsharp
    {
        // Sintaxe Básica - Pule para as CARACTERÍSTICAS INTERESSANTES se você ja usou Java ou C++ antes.
        public static void Syntax()
        {
            // Use Console.WriteLine para apresentar uma linha
            Console.WriteLine("Hello World");
            Console.WriteLine(
                "Integer: " + 10 +
                " Double: " + 3.14 +
                " Boolean: " + true);

            // Para apresentar sem incluir uma nova linha, use Console.Write
            Console.Write("Hello ");
            Console.Write("World");

            ///////////////////////////////////////////////////
            // Tipos e Variáveis
            //
            // Declare uma variável usando <tipo> <nome>
            ///////////////////////////////////////////////////

            // Sbyte - Signed 8-bit integer
            // (-128 <= sbyte <= 127)
            sbyte fooSbyte = 100;

            // Byte - Unsigned 8-bit integer
            // (0 <= byte <= 255)
            byte fooByte = 100;

            // Short - 16-bit integer
            // Signed - (-32,768 <= short <= 32,767)
            // Unsigned - (0 <= ushort <= 65,535)
            short fooShort = 10000;
            ushort fooUshort = 10000;

            // Integer - inteiro de 32 bits 
            int fooInt = 1; // (-2,147,483,648 <= int <= 2,147,483,647)
            uint fooUint = 1; // (0 <= uint <= 4,294,967,295)
            //Números por padrão são int ou uint, dependendo do tamanho.
            
            // Long - 64-bit integer
            long fooLong = 100000L; // (-9,223,372,036,854,775,808 <= long <= 9,223,372,036,854,775,807)
            ulong fooUlong = 100000L; // (0 <= ulong <= 18,446,744,073,709,551,615)
            
            // Números por padrão são int ou uint dependendo do tamanho.
            // L é usado para denotar que o valor da variável é do tipo long ou ulong.

            // Double - Double-precision 64-bit IEEE 754 Floating Point
            double fooDouble = 123.4; // Precision: 15-16 digits

            // Float - Single-precision 32-bit IEEE 754 Floating Point
            float fooFloat = 234.5f; // Precision: 7 digits
            // f is used to denote that this variable value is of type float

            // Decimal - um tipo de dados de 128 bits, com mais precisão do que outros tipos de ponto flutuante,
            // adequado para cálculos financeiros e monetários
            decimal fooDecimal = 150.3m;

            // Boolean - true & false
            bool fooBoolean = true; // or false

            // Char - A single 16-bit Unicode character
            char fooChar = 'A';

            // Strings - ao contrário dos anteriores tipos base, que são todos os tipos de valor,
            // Uma string é um tipo de referência. Ou seja, você pode configurá-lo como nulo
            string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
            Console.WriteLine(fooString);

            //  Você pode acessar todos os caracteres de string com um indexador: 
            char charFromString = fooString[1]; // => 'e'
            // Strings são imutáveis: você não pode fazer fooString[1] = 'X';

            // Compare strings com sua atual cultura, ignorando maiúsculas e minúsculas
            string.Compare(fooString, "x", StringComparison.CurrentCultureIgnoreCase);

            // Formatando, baseado no sprintf
            string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);

            // Datas e formatações
            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));

            // Você pode juntar um string em mais de duas linhas com o símbolo @. Para escapar do " use ""
            string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses cried";

            // Use const ou read-only para fazer uma variável imutável
            // os valores da const são calculados durante o tempo de compilação
            const int HoursWorkPerWeek = 9001;

            ///////////////////////////////////////////////////
            // Estrutura de Dados
            ///////////////////////////////////////////////////

            // Matrizes - zero indexado
            // O tamanho do array pode ser decidido ainda na declaração
            // O formato para declarar uma matriz é o seguinte: 
            // <tipodado>[] <var nome> = new <tipodado>[<array tamanho>];
            int[] intArray = new int[10];

            // Outra forma de declarar & inicializar uma matriz
            int[] y = { 9000, 1000, 1337 };

            // Indexando uma matriz - Acessando um elemento
            Console.WriteLine("intArray @ 0: " + intArray[0]);
            // Matriz são alteráveis
            intArray[1] = 1;

            // Listas
            // Listas são usadas frequentemente tanto quanto matriz por serem mais flexíveis
            // O formato de declarar uma lista é o seguinte:
            // List<tipodado> <var nome> = new List<tipodado>();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            List<int> z = new List<int> { 9000, 1000, 1337 }; // inicializar
            // O <> são para genéricos - Confira está interessante seção do material

            // Lista não possuem valores padrão.
            // Um valor deve ser adicionado antes e depois acessado pelo indexador
            intList.Add(1);
            Console.WriteLine("intList @ 0: " + intList[0]);

            // Outras estruturas de dados para conferir:
            // Pilha/Fila
            // Dicionário (uma implementação de map de hash)
            // HashSet
            // Read-only Coleção
            // Tuple (.Net 4+)

            ///////////////////////////////////////
            // Operadores
            ///////////////////////////////////////
            Console.WriteLine("\n->Operators");

            int i1 = 1, i2 = 2; // Forma curta para declarar diversas variáveis

            // Aritmética é clara
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3

            // Modulo
            Console.WriteLine("11%3 = " + (11 % 3)); // => 2

            // Comparações de operadores
            Console.WriteLine("3 == 2? " + (3 == 2)); // => falso
            Console.WriteLine("3 != 2? " + (3 != 2)); // => verdadeiro
            Console.WriteLine("3 > 2? " + (3 > 2)); // => verdadeiro
            Console.WriteLine("3 < 2? " + (3 < 2)); // => falso
            Console.WriteLine("2 <= 2? " + (2 <= 2)); // => verdadeiro
            Console.WriteLine("2 >= 2? " + (2 >= 2)); // => verdadeiro

            // Operadores bit a bit (bitwise)
            /*
            ~       Unário bitwise complemento
            <<      Signed left shift
            >>      Signed right shift
            &       Bitwise AND
            ^       Bitwise exclusivo OR
            |       Bitwise inclusivo OR
            */

            // Incrementações
            int i = 0;
            Console.WriteLine("\n->Inc/Dec-rementation");
            Console.WriteLine(i++); //i = 1. Post-Incrementation
            Console.WriteLine(++i); //i = 2. Pre-Incrementation
            Console.WriteLine(i--); //i = 1. Post-Decrementation
            Console.WriteLine(--i); //i = 0. Pre-Decrementation

            ///////////////////////////////////////
            // Estrutura de Controle
            ///////////////////////////////////////
            Console.WriteLine("\n->Control Structures");

            // Declaração if é como a linguagem C
            int j = 10;
            if (j == 10)
            {
                Console.WriteLine("I get printed");
            }
            else if (j > 10)
            {
                Console.WriteLine("I don't");
            }
            else
            {
                Console.WriteLine("I also don't");
            }

            // Operador Ternário
            // Um simples if/else pode ser escrito da seguinte forma
            // <condição> ? <verdadeiro> : <falso>
            int toCompare = 17;
            string isTrue = toCompare == 17 ? "True" : "False";

            // While loop
            int fooWhile = 0;
            while (fooWhile < 100)
            {
                //Iterated 100 times, fooWhile 0->99
                fooWhile++;
            }

            // Do While Loop
            int fooDoWhile = 0;
            do
            {
                // Inicia a interação 100 vezes, fooDoWhile 0->99
                if (false)
                    continue; // pule a intereção atual para a próxima

                fooDoWhile++;

                if (fooDoWhile == 50)
                    break; // Interrompe o laço inteiro

            } while (fooDoWhile < 100);

            //estrutura de loop for  => for(<declaração para começar>; <condicional>; <passos>)
            for (int fooFor = 0; fooFor < 10; fooFor++)
            {
                //Iterado 10 vezes, fooFor 0->9
            }

            // For Each Loop
            // Estrutura do foreach  => foreach(<Tipo Iterador> <Nome do Iterador> in <enumerable>)
            // O laço foreach percorre sobre qualquer objeto que implementa IEnumerable ou IEnumerable<T>
            // Toda a coleção de tipos  (Array, List, Dictionary...) no .Net framework
            // implementa uma ou mais destas interfaces.
            // (O ToCharArray() pode ser removido, por que uma string também implementa IEnumerable)
            foreach (char character in "Hello World".ToCharArray())
            {
                //Iterated over all the characters in the string
            }

            // Switch Case
            // Um switch funciona com os tipos de dados byte, short, char, e int.
            // Isto também funcional com tipos enumeradors (discutidos em Tipos Enum),
            // A classe String, and a few special classes that wrap
            // tipos primitívos: Character, Byte, Short, and Integer.
            int month = 3;
            string monthString;
            switch (month)
            {
                case 1:
                    monthString = "January";
                    break;
                case 2:
                    monthString = "February";
                    break;
                case 3:
                    monthString = "March";
                    break;
                // Você pode declarar mais de um "case" para uma ação
                // Mas você não pode adicionar uma ação sem um "break" antes de outro "case"
                // (se você quiser fazer isso, você tem que explicitamente adicionar um "goto case x")
                case 6:
                case 7:
                case 8:
                    monthString = "Summer time!!";
                    break;
                default:
                    monthString = "Some other month";
                    break;
            }

            ///////////////////////////////////////
            // Convertendo Data Types e Typecasting
            ///////////////////////////////////////

            // Convertendo dados

            // Converter String para Integer

            // isso vai jogar um erro FormatException quando houver falha
            int.Parse("123");//retorna uma verão em Integer da String "123"

            // try parse vai ir por padrão para o typo default quando houver uma falha
            // nesse caso: 0
            int tryInt;
            if (int.TryParse("123", out tryInt)) // Função booleana
                Console.WriteLine(tryInt);       // 123

            // Converter Integer para String
            // A classe Convert possuí métodos para facilitar as conversões
            Convert.ToString(123);
            // ou
            tryInt.ToString();

            // Casting
            // Cast decimal 15 to a int
            // and then implicitly cast to long
            long x = (int) 15M;
        }

        ///////////////////////////////////////
        // CLASSES - Veja definições no fim do arquivo
        ///////////////////////////////////////
        public static void Classes()
        {
            // Veja Declaração de objetos no fim do arquivo

            // Use new para instanciar uma classe
            Bicycle trek = new Bicycle();

            // Chame métodos do objeto
            trek.SpeedUp(3); // Você deve sempre usar métodos setter e getter
            trek.Cadence = 100;

            // ToString é uma convenção para exibir o valor desse Objeto.
            Console.WriteLine("trek info: " + trek.Info());

            // Instancie um novo Penny Farthing
            PennyFarthing funbike = new PennyFarthing(1, 10);
            Console.WriteLine("funbike info: " + funbike.Info());

            Console.Read();
        } // Fim do método principal

        // CONSOLE ENTRY A console application must have a main method as an entry point
        public static void Main(string[] args)
        {
            OtherInterestingFeatures();
        }

        //
        // INTERESTING FEATURES
        //

        // DEFAULT METHOD SIGNATURES

        public // Visibility
        static // Allows for direct call on class without object
        int // Return Type,
        MethodSignatures(
            int maxCount, // First variable, expects an int
            int count = 0, // will default the value to 0 if not passed in
            int another = 3,
            params string[] otherParams // captures all other parameters passed to method
        )
        {
            return -1;
        }

        // Methods can have the same name, as long as the signature is unique
        // A method that differs only in return type is not unique
        public static void MethodSignatures(
            ref int maxCount, // Pass by reference
            out int count)
        {
            count = 15; // out param must be assigned before control leaves the method
        }

        // GENERICS
        // The classes for TKey and TValue is specified by the user calling this function.
        // This method emulates the SetDefault of Python
        public static TValue SetDefault<TKey, TValue>(
            IDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue defaultItem)
        {
            TValue result;
            if (!dictionary.TryGetValue(key, out result))
                return dictionary[key] = defaultItem;
            return result;
        }

        // Você pode pode restringir os objetos que são passados
        public static void IterateAndPrint<T>(T toPrint) where T: IEnumerable<int>
        {
            // Nos podemos iterar, desde que T seja um "IEnumerable"
            foreach (var item in toPrint)
                // Item é um inteiro
                Console.WriteLine(item.ToString());
        }

        public static void OtherInterestingFeatures()
        {
            // OPTIONAL PARAMETERS
            MethodSignatures(3, 1, 3, "Some", "Extra", "Strings");
            MethodSignatures(3, another: 3); // explicity set a parameter, skipping optional ones

            // BY REF AND OUT PARAMETERS
            int maxCount = 0, count; // ref params must have value
            MethodSignatures(ref maxCount, out count);

            // EXTENSION METHODS
            int i = 3;
            i.Print(); // Defined below

            // NULLABLE TYPES - great for database interaction / return values
            // any value type (i.e. not a class) can be made nullable by suffixing a ?
            // <type>? <var name> = <value>
            int? nullable = null; // short hand for Nullable<int>
            Console.WriteLine("Nullable variable: " + nullable);
            bool hasValue = nullable.HasValue; // true if not null

            // ?? is syntactic sugar for specifying default value (coalesce)
            // in case variable is null
            int notNullable = nullable ?? 0; // 0

            // IMPLICITLY TYPED VARIABLES - you can let the compiler work out what the type is:
            var magic = "magic is a string, at compile time, so you still get type safety";
            // magic = 9; will not work as magic is a string, not an int

            // GENERICS
            //
            var phonebook = new Dictionary<string, string>() {
                {"Sarah", "212 555 5555"} // Add some entries to the phone book
            };

            // Calling SETDEFAULT defined as a generic above
            Console.WriteLine(SetDefault<string,string>(phonebook, "Shaun", "No Phone")); // No Phone
            // nb, you don't need to specify the TKey and TValue since they can be
            // derived implicitly
            Console.WriteLine(SetDefault(phonebook, "Sarah", "No Phone")); // 212 555 5555

            // LAMBDA EXPRESSIONS - allow you to write code in line
            Func<int, int> square = (x) => x * x; // Last T item is the return value
            Console.WriteLine(square(3)); // 9

            // ERROR HANDLING - coping with an uncertain world
            try
            {
                var funBike = PennyFarthing.CreateWithGears(6);

                // will no longer execute because CreateWithGears throws an exception
                string some = "";
                if (true) some = null;
                some.ToLower(); // throws a NullReferenceException
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Not so much fun now!");
            }
            catch (Exception ex) // catch all other exceptions
            {
                throw new ApplicationException("It hit the fan", ex);
                // throw; // A rethrow that preserves the callstack
            }
            // catch { } // catch-all without capturing the Exception
            finally
            {
                // executes after try or catch
            }

            // DISPOSABLE RESOURCES MANAGEMENT - let you handle unmanaged resources easily.
            // Most of objects that access unmanaged resources (file handle, device contexts, etc.)
            // implement the IDisposable interface. The using statement takes care of
            // cleaning those IDisposable objects for you.
            using (StreamWriter writer = new StreamWriter("log.txt"))
            {
                writer.WriteLine("Nothing suspicious here");
                // At the end of scope, resources will be released.
                // Even if an exception is thrown.
            }

            // PARALLEL FRAMEWORK
            // http://blogs.msdn.com/b/csharpfaq/archive/2010/06/01/parallel-programming-in-net-framework-4-getting-started.aspx
            var websites = new string[] {
                "http://www.google.com", "http://www.reddit.com",
                "http://www.shaunmccarthy.com"
            };
            var responses = new Dictionary<string, string>();

            // Will spin up separate threads for each request, and join on them
            // before going to the next step!
            Parallel.ForEach(websites,
                new ParallelOptions() {MaxDegreeOfParallelism = 3}, // max of 3 threads
                website =>
            {
                // Do something that takes a long time on the file
                using (var r = WebRequest.Create(new Uri(website)).GetResponse())
                {
                    responses[website] = r.ContentType;
                }
            });

            // This won't happen till after all requests have been completed
            foreach (var key in responses.Keys)
                Console.WriteLine("{0}:{1}", key, responses[key]);

            // OBJETOS DINÂMICOS (ótimo para trabalhar com outros idiomas)
            dynamic student = new ExpandoObject();
            student.FirstName = "First Name"; // No need to define class first!

            // You can even add methods (returns a string, and takes in a string)
            student.Introduce = new Func<string, string>(
                (introduceTo) => string.Format("Hey {0}, this is {1}", student.FirstName, introduceTo));
            Console.WriteLine(student.Introduce("Beth"));

            // IQUERYABLE<T> - almost all collections implement this, which gives you a lot of
            // very useful Map / Filter / Reduce style methods
            var bikes = new List<Bicycle>();
            bikes.Sort(); // Sorts the array
            bikes.Sort((b1, b2) => b1.Wheels.CompareTo(b2.Wheels)); // Sorts based on wheels
            var result = bikes
                .Where(b => b.Wheels > 3) // Filters - chainable (returns IQueryable of previous type)
                .Where(b => b.IsBroken && b.HasTassles)
                .Select(b => b.ToString()); // Map - we only this selects, so result is a IQueryable<string>

            var sum = bikes.Sum(b => b.Wheels); // Reduce - sums all the wheels in the collection

            // Create a list of IMPLICIT objects based on some parameters of the bike
            var bikeSummaries = bikes.Select(b=>new { Name = b.Name, IsAwesome = !b.IsBroken && b.HasTassles });
            // Hard to show here, but you get type ahead completion since the compiler can implicitly work
            // out the types above!
            foreach (var bikeSummary in bikeSummaries.Where(b => b.IsAwesome))
                Console.WriteLine(bikeSummary.Name);

            // ASPARALLEL
            // And this is where things get wicked - combines linq and parallel operations
            var threeWheelers = bikes.AsParallel().Where(b => b.Wheels == 3).Select(b => b.Name);
            // this will happen in parallel! Threads will automagically be spun up and the
            // results divvied amongst them! Amazing for large datasets when you have lots of
            // cores

            // LINQ - maps a store to IQueryable<T> objects, with delayed execution
            // e.g. LinqToSql - maps to a database, LinqToXml maps to an xml document
            var db = new BikeRepository();

            // execution is delayed, which is great when querying a database
            var filter = db.Bikes.Where(b => b.HasTassles); // no query run
            if (42 > 6) // You can keep adding filters, even conditionally - great for "advanced search" functionality
                filter = filter.Where(b => b.IsBroken); // no query run

            var query = filter
                .OrderBy(b => b.Wheels)
                .ThenBy(b => b.Name)
                .Select(b => b.Name); // still no query run

            // Now the query runs, but opens a reader, so only populates are you iterate through
            foreach (string bike in query)
                Console.WriteLine(result);



        }

    } // End LearnCSharp class

    // You can include other classes in a .cs file

    public static class Extensions
    {
        // EXTENSION FUNCTIONS
        public static void Print(this object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }

    // Class Declaration Syntax:
    // <public/private/protected/internal> class <class name>{
    //    //data fields, constructors, functions all inside.
    //    //functions are called as methods in Java.
    // }

    public class Bicycle
    {
        // Bicycle's Fields/Variables
        public int Cadence // Public: Can be accessed from anywhere
        {
            get // get - define a method to retrieve the property
            {
                return _cadence;
            }
            set // set - define a method to set a proprety
            {
                _cadence = value; // Value is the value passed in to the setter
            }
        }
        private int _cadence;

        protected virtual int Gear // Protected: Accessible from the class and subclasses
        {
            get; // creates an auto property so you don't need a member field
            set;
        }

        internal int Wheels // Internal: Accessible from within the assembly
        {
            get;
            private set; // You can set modifiers on the get/set methods
        }

        int _speed; // Everything is private by default: Only accessible from within this class.
                    // can also use keyword private
        public string Name { get; set; }

        // Enum is a value type that consists of a set of named constants
        // It is really just mapping a name to a value (an int, unless specified otherwise).
        // The approved types for an enum are byte, sbyte, short, ushort, int, uint, long, or ulong.
        // An enum can't contain the same value twice.
        public enum BikeBrand
        {
            AIST,
            BMC,
            Electra = 42, //you can explicitly set a value to a name
            Gitane // 43
        }
        // We defined this type inside a Bicycle class, so it is a nested type
        // Code outside of this class should reference this type as Bicycle.Brand

        public BikeBrand Brand; // After declaring an enum type, we can declare the field of this type

        // Decorate an enum with the FlagsAttribute to indicate that multiple values can be switched on
        [Flags] // Any class derived from Attribute can be used to decorate types, methods, parameters etc
        public enum BikeAccessories
        {
            None = 0,
            Bell = 1,
            MudGuards = 2, // need to set the values manually!
            Racks = 4,
            Lights = 8,
            FullPackage = Bell | MudGuards | Racks | Lights
        }

        // Usage: aBike.Accessories.HasFlag(Bicycle.BikeAccessories.Bell)
        // Before .NET 4: (aBike.Accessories & Bicycle.BikeAccessories.Bell) == Bicycle.BikeAccessories.Bell
        public BikeAccessories Accessories { get; set; }

        // Static members belong to the type itself rather then specific object.
        // You can access them without a reference to any object:
        // Console.WriteLine("Bicycles created: " + Bicycle.bicyclesCreated);
        public static int BicyclesCreated { get; set; }

        // readonly values are set at run time
        // they can only be assigned upon declaration or in a constructor
        readonly bool _hasCardsInSpokes = false; // read-only private

        // Constructors are a way of creating classes
        // This is a default constructor
        public Bicycle()
        {
            this.Gear = 1; // you can access members of the object with the keyword this
            Cadence = 50;  // but you don't always need it
            _speed = 5;
            Name = "Bontrager";
            Brand = BikeBrand.AIST;
            BicyclesCreated++;
        }

        // This is a specified constructor (it contains arguments)
        public Bicycle(int startCadence, int startSpeed, int startGear,
                       string name, bool hasCardsInSpokes, BikeBrand brand)
            : base() // calls base first
        {
            Gear = startGear;
            Cadence = startCadence;
            _speed = startSpeed;
            Name = name;
            _hasCardsInSpokes = hasCardsInSpokes;
            Brand = brand;
        }

        // Constructors can be chained
        public Bicycle(int startCadence, int startSpeed, BikeBrand brand) :
            this(startCadence, startSpeed, 0, "big wheels", true, brand)
        {
        }

        // Function Syntax:
        // <public/private/protected> <return type> <function name>(<args>)

        // classes can implement getters and setters for their fields
        // or they can implement properties (this is the preferred way in C#)

        // Method parameters can have default values.
        // In this case, methods can be called with these parameters omitted
        public void SpeedUp(int increment = 1)
        {
            _speed += increment;
        }

        public void SlowDown(int decrement = 1)
        {
            _speed -= decrement;
        }

        // propriedade recupera e/ou atribui valores (get/set). 
        // quando os dados precisam apenas ser acessados, considere o uso de propriedades.
        // uma propriedade pode ter "get" ou "set", ou ambos.
        private bool _hasTassles; // private variable
        public bool HasTassles // public accessor
        {
            get { return _hasTassles; }
            set { _hasTassles = value; }
        }

        // Você também pode definir uma propriedade automática em uma linha
        // Esta sintaxe criará um campo de apoio automaticamente.
        // Você pode definir um modificador de acesso no getter ou no setter (ou ambos)
        // para restringir seu acesso:
        public bool IsBroken { get; private set; }

        // Properties can be auto-implemented
        public int FrameSize
        {
            get;
            // you are able to specify access modifiers for either get or set
            // this means only Bicycle class can call set on Framesize
            private set;
        }

        // It's also possible to define custom Indexers on objects.
        // All though this is not entirely useful in this example, you
        // could do bicycle[0] which yields "chris" to get the first passenger or
        // bicycle[1] = "lisa" to set the passenger. (of this apparent quattrocycle)
        private string[] passengers = { "chris", "phil", "darren", "regina" };

        public string this[int i]
        {
            get {
                return passengers[i];
            }

            set {
                return passengers[i] = value;
            }
        }

        //Método para exibir os valores dos atributos deste objeto.
        public virtual string Info()
        {
            return "Gear: " + Gear +
                    " Cadence: " + Cadence +
                    " Speed: " + _speed +
                    " Name: " + Name +
                    " Cards in Spokes: " + (_hasCardsInSpokes ? "yes" : "no") +
                    "\n------------------------------\n"
                    ;
        }

        // Methods can also be static. It can be useful for helper methods
        public static bool DidWeCreateEnoughBycles()
        {
            // Within a static method, we only can reference static class members
            return BicyclesCreated > 9000;
        } // If your class only needs static members, consider marking the class itself as static.


    } // end class Bicycle

    // PennyFarthing é uma subclasse de Bicycle
    class PennyFarthing : Bicycle
    {
        // (Penny Farthings são aquelas bicicletas com uma grande roda frontal.
        // Elas não tem correias.)

        // chamando construtor pai
        public PennyFarthing(int startCadence, int startSpeed) :
            base(startCadence, startSpeed, 0, "PennyFarthing", true, BikeBrand.Electra)
        {
        }

        protected override int Gear
        {
            get
            {
                return 0;
            }
            set
            {
                throw new InvalidOperationException("You can't change gears on a PennyFarthing");
            }
        }

        public static PennyFarthing CreateWithGears(int gears)
        {
            var penny = new PennyFarthing(1, 1);
            penny.Gear = gears; // Oops, can't do this!
            return penny;
        }

        public override string Info()
        {
            string result = "PennyFarthing bicycle ";
            result += base.ToString(); // Calling the base version of the method
            return result;
        }
    }

    // Interfaces contêm apenas as assinaturas dos membros, sem a implementação.
    interface IJumpable
    {
        void Jump(int meters); // todos os membros da interface são implicitamente públicos
    }

    interface IBreakable
    {
        bool Broken { get; } // interfaces can contain properties as well as methods & events
    }

    // Classes podem herdar apenas de uma outra classe, mas podem implementar qualquer quantidade de interfaces.
    class MountainBike : Bicycle, IJumpable, IBreakable
    {
        int damage = 0;

        public void Jump(int meters)
        {
            damage += meters;
        }

        public bool Broken
        {
            get
            {
                return damage > 100;
            }
        }
    }

    /// <summary>
    /// Exemplo de como conectar-se ao DB via LinqToSql.
    /// EntityFramework First Code é impressionante (semelhante ao ActiveRecord de Ruby, mas bidirecional)
    /// http://msdn.microsoft.com/en-us/data/jj193542.aspx
    /// </summary>
    public class BikeRepository : DbContext
    {
        public BikeRepository()
            : base()
        {
        }

        public DbSet<Bicycle> Bikes { get; set; }
    }
} // End Namespace
