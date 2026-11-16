using ProcessamentoDocumentos.Modelo;

// 1. Pelo menos um objeto de cada classe concreta
RelatorioFinanceiro relatorioAnual = new RelatorioFinanceiro(
    "Relatório trimestral", "Ana", new DateTime(2026, 3, 31), 80000m, 65000m);
DocumentoTexto texto = new DocumentoTexto(
    "Ata da reunião", "João", new DateTime(2026, 4, 2), "A reunião   começou às 10h e terminou às 11h.");
Planilha planilhaVendas = new Planilha(
    "Vendas do mês", "Paula", new DateTime(2026, 5, 1), 30, 8);

// 2. Processar() em cada objeto
Console.WriteLine("=== Processar ===");
relatorioAnual.Processar();
texto.Processar();
planilhaVendas.Processar();
Console.WriteLine();

// DocumentoTexto não sobrescreve ExibirResumo(): usa o herdado do Documento
Console.WriteLine("=== Resumo do documento de texto (herdado) ===");
texto.ExibirResumo();
Console.WriteLine();

// 3. Investigação obrigatória: override x new
Documento documento1 = new RelatorioFinanceiro(
    "Relatório anual", "Maria",
    new DateTime(2026, 1, 10), 50000m, 32000m);

Documento documento2 = new Planilha(
    "Controle de estoque", "Carlos",
    new DateTime(2026, 2, 5), 20, 5);

RelatorioFinanceiro relatorio = (RelatorioFinanceiro)documento1;
Planilha planilha = (Planilha)documento2;

Console.WriteLine("Teste 1:");
documento1.ExibirResumo();   // relatório (override: vale o objeto real)
Console.WriteLine("Teste 2:");
relatorio.ExibirResumo();    // relatório
Console.WriteLine("Teste 3:");
documento2.ExibirResumo();   // BASE (new: vale o tipo da variável, que é Documento)
Console.WriteLine("Teste 4:");
planilha.ExibirResumo();     // planilha (variável do tipo Planilha)
Console.WriteLine();

// 4 e 5. Trocando new por override em Planilha.ExibirResumo(), o Teste 3 passa
// a mostrar o resumo da planilha. Os testes 1, 2 e 4 não mudam.
// Com override, o método chamado depende do OBJETO; com new, depende do TIPO DA VARIÁVEL.

// Desafio: List<Documento> sem conversões de tipo
Console.WriteLine("=== Lista de documentos ===");
List<Documento> documentos = new List<Documento>();
documentos.Add(relatorioAnual);
documentos.Add(texto);
documentos.Add(planilhaVendas);

foreach (Documento documento in documentos)
{
    documento.Processar();      // abstrato: cada classe executa a sua versão
    documento.ExibirResumo();   // a planilha mostra o resumo da BASE, porque usa new
    Console.WriteLine();
}

// 7. Tentativa de instanciar Documento (linha removida para o programa executar):
// Documento documento = new Documento("X", "Y", DateTime.Now);
// Erro CS0144: Não é possível criar uma instância da classe abstrata ou interface 'Documento'

// 6. Validações de dados inválidos
Console.WriteLine("=== Testes de validação ===");

try
{
    RelatorioFinanceiro invalido = new RelatorioFinanceiro("", "Maria", new DateTime(2026, 1, 10), 100m, 50m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    RelatorioFinanceiro invalido = new RelatorioFinanceiro("Relatório", "Maria", DateTime.Now.AddDays(5), 100m, 50m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    RelatorioFinanceiro invalido = new RelatorioFinanceiro("Relatório", "Maria", new DateTime(2026, 1, 10), -100m, 50m);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    DocumentoTexto invalido = new DocumentoTexto("Texto", "", new DateTime(2026, 1, 10), "Conteúdo");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    DocumentoTexto invalido = new DocumentoTexto("Texto", "João", new DateTime(2026, 1, 10), "");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Planilha invalida = new Planilha("Planilha", "Carlos", new DateTime(2026, 1, 10), 0, 5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
