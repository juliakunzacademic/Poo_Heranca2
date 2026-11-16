# Atividade 3 — Processamento de Documentos

## Previsão (antes de executar)

| Teste | Chamada | Minha previsão (base ou classe?) | Resultado com new | Resultado com override |
|---|---|---|---|---|
| 1 | documento1.ExibirResumo() | | | |
| 2 | relatorio.ExibirResumo() | | | |
| 3 | documento2.ExibirResumo() | | | |
| 4 | planilha.ExibirResumo() | | | |

**Diferença entre os resultados com override e com new:**


**Erro de compilação ao tentar instanciar Documento:**


## Questões para reflexão

**1. Por que Documento deve ser abstrata e Processar() não tem corpo?**


**2. Por que ExibirResumo() pode ser virtual em vez de abstrato?**


**3. Em quais chamadas ocorre despacho para a implementação sobrescrita com override?**


**4. Por que a chamada por Documento e a chamada por Planilha não são equivalentes quando se utiliza new?**


**5. Por que new não deve ser tratado como sinônimo de override?**


**6. Qual é o efeito do tipo declarado de uma referência no caso de métodos ocultados?**

