using PersonagensJogo.Modelo;

// 1. Um personagem comum, um guerreiro, um mago e um arqueiro
Personagem comum = new Personagem("Aldeão", 50, 5);
Guerreiro guerreiro = new Guerreiro("Conan", 120, 15, 10);
Mago mago = new Mago("Merlin", 80, 8, 30, 10, 20);
Arqueiro arqueiro = new Arqueiro("Robin", 90, 12, 8);

comum.ExibirStatus();
Console.WriteLine();
guerreiro.ExibirStatus();
Console.WriteLine();
mago.ExibirStatus();
Console.WriteLine();
arqueiro.ExibirStatus();
Console.WriteLine();

// 2. Dano do ataque de todos
Console.WriteLine("=== Ataques ===");
Console.WriteLine($"{comum.Nome}: {comum.Atacar()} de dano");
Console.WriteLine($"{guerreiro.Nome}: {guerreiro.Atacar()} de dano");
Console.WriteLine($"{arqueiro.Nome}: {arqueiro.Atacar()} de dano");
Console.WriteLine();

// 3. Ataques sucessivos do mago até acabar a mana do ataque especial
Console.WriteLine("=== Ataques do mago ===");
for (int i = 1; i <= 4; i++)
{
    int dano = mago.Atacar();
    Console.WriteLine($"Ataque {i}: {dano} de dano | mana restante: {mago.ManaAtual}");
}
Console.WriteLine();

// 4. Ataque normal e ataque crítico do arqueiro
Console.WriteLine("=== Ataques do arqueiro ===");
Console.WriteLine($"Ataque normal: {arqueiro.Atacar(false)} de dano");
Console.WriteLine($"Ataque crítico: {arqueiro.Atacar(true)} de dano");
Console.WriteLine();

// 5. ReceberDano e pontos de vida restantes
Console.WriteLine("=== Recebendo dano ===");
guerreiro.ReceberDano(30);
Console.WriteLine($"{guerreiro.Nome} recebeu 30 de dano. Vida restante: {guerreiro.PontosDeVida}");
comum.ReceberDano(100);
Console.WriteLine($"{comum.Nome} recebeu 100 de dano. Vida restante: {comum.PontosDeVida}");
Console.WriteLine();

// 6. Guerreiro guardado numa variável do tipo Personagem
Console.WriteLine("=== Guerreiro como Personagem ===");
Personagem personagem = new Guerreiro("Leônidas", 100, 20, 5);
Console.WriteLine($"Dano: {personagem.Atacar()}");
// Mostra 25 (20 + 5): como Atacar() é virtual e o Guerreiro fez override,
// o C# executa a versão do objeto real (Guerreiro), e não a do tipo da variável.
Console.WriteLine();

// Desafio: Paladino
Console.WriteLine("=== Paladino ===");
Paladino paladino = new Paladino("Arthur", 150, 18, 7, 10);
Console.WriteLine($"{paladino.Nome}: {paladino.Atacar()} de dano"); // 18 + 7 + 10 = 35
Console.WriteLine();

// 7. Valores inválidos de construção e de dano
Console.WriteLine("=== Testes de validação ===");

try
{
    Personagem invalido = new Personagem("", 50, 5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Guerreiro invalido = new Guerreiro("Thor", 0, 10, 5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Mago invalido = new Mago("Gandalf", 80, 8, 30, 0, 20);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    Arqueiro invalido = new Arqueiro("Legolas", 90, 12, 0);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

try
{
    arqueiro.ReceberDano(-5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
