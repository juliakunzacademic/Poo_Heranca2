using ReservasEspacos.Modelo;

// 1. Um objeto de cada classe concreta, mostrando as informações gerais com o método herdado
SalaEstudo sala = new SalaEstudo("Sala 101", "Bloco A", 10, 15m);
Auditorio auditorio = new Auditorio("Auditório Central", "Bloco B", 200, 100m, 250m);
LaboratorioInformatica laboratorio = new LaboratorioInformatica("Lab 3", "Bloco C", 30, 25, 4m);

Console.WriteLine("=== Sala de estudo ===");
sala.ExibirInformacoes();
Console.WriteLine();

Console.WriteLine("=== Auditório ===");
auditorio.ExibirInformacoes();
Console.WriteLine();

Console.WriteLine("=== Laboratório de informática ===");
laboratorio.ExibirInformacoes();
Console.WriteLine();

// 2 e 3. Custos para 2, 4 e 6 horas: cada classe calcula do seu jeito (override)
int[] duracoes = { 2, 4, 6 };

foreach (int horas in duracoes)
{
    Console.WriteLine($"--- {horas} horas ---");
    Console.WriteLine($"Sala de estudo: {sala.CalcularCusto(horas):C}");
    Console.WriteLine($"Auditório: {auditorio.CalcularCusto(horas):C}");
    Console.WriteLine($"Laboratório: {laboratorio.CalcularCusto(horas):C}");
    Console.WriteLine();
}

// 4. Tentativa de instanciar Espaco (linha removida para o programa executar):
// Espaco espaco = new Espaco("X", "Y", 10);
// Erro CS0144: Não é possível criar uma instância da classe abstrata ou interface 'Espaco'

// 5. Testes de dados inválidos
Console.WriteLine("=== Testes de validação ===");

try
{
    sala.CalcularCusto(0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    auditorio.CalcularCusto(-3);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    SalaEstudo salaInvalida = new SalaEstudo("", "Bloco A", 10, 15m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Auditorio auditorioInvalido = new Auditorio("Auditório 2", "Bloco B", 0, 100m, 50m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Auditorio auditorioInvalido = new Auditorio("Auditório 3", "Bloco B", 100, 100m, -10m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    LaboratorioInformatica labInvalido = new LaboratorioInformatica("Lab 4", "Bloco C", 20, 25, 4m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
