// prática de criacao de classes e aprofundamento em propriedades, metodos e construtores


using System.Globalization;
using classesMetodosPropriedaeds.models;


// podemos instanciar utilizando construtores, reduzindo o número de linhas necessárias em nosso código principal, mantendo o código conciso e direto
Pessoa p1 = new Pessoa("Gabriel", "Teixeira");
Pessoa p2 = new Pessoa("Andressa", "Souza");

// Classe curso
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

// Adicionando pessoas na lista de Alunos do curso
cursoDeIngles.AdicionaAluno(p1);
cursoDeIngles.AdicionaAluno(p2);
cursoDeIngles.ListarAlunosMatriculados();

// utilizando valores monetarios 
decimal ValorMonetario = 1450.50M;
Console.WriteLine($"{ValorMonetario:C}"); // note que quando nao definimos a Cultura/localizacao, é automaticamente assumido a cultura cadastrada no PC, neste caso em USD

// Para mudar dentro do próprio código a cultura utilize:
CultureInfo.DefaultThreadCurrentCulture= new CultureInfo("pt-BR");
Console.WriteLine($"{ValorMonetario:C}");
// este é um exemplo de alteracao dentro do próprio código, porém é possível alterar a cultura em si:
//neste exemplo já temos a moeda convertida para reais, porém em vez de definir uma nova cultura, vamos definir ela dentro de um escopo writeline
Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{ValorMonetario:C}");

// ou podemos formatar de maneira personalizada, sem a necessidade de estipular uma cultura especifica:
Console.WriteLine(ValorMonetario.ToString("C")); // vai printar R$ 1.450,50
Console.WriteLine(ValorMonetario.ToString("C1")); // altera o número de casas decimais para 1 // vai printar R$ 1.450,5
Console.WriteLine(ValorMonetario.ToString("C3")); // altera o número de casas decimais para 3 // vai printar R$ 1.450,500
Console.WriteLine(ValorMonetario.ToString("N3")); // Podemos utilizar N em vez do C, mostrando em formato de numero em vez de moeda // vai printar 1.450,500

// porcentagens:
double porcentagem = .0423;
Console.WriteLine(porcentagem.ToString("P")); // prints 4,230%
Console.WriteLine(porcentagem.ToString("P2")); // prints 4,23%

// uso de # 
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##")); // prints 12-34-56








