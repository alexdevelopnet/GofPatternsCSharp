# Padrão Strategy - Estratégias de Evangelização de Paulo

## Descrição
O padrão Strategy define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. Strategy permite que o algoritmo varie independentemente dos clientes que o usam.

## Exemplo Bíblico
Implementamos as **Estratégias de Evangelização de Paulo** usando o padrão Strategy:

- **Context**: Paulo (o evangelista)
- **Strategies**: EstrategiaJudeus, EstrategiaGentios, EstrategiaFilosofos, EstrategiaGovernantes, EstrategiaSimples
- **Algoritmos**: Diferentes abordagens para diferentes audiências

## Funcionalidades
- ✅ Múltiplas estratégias de evangelização
- ✅ Seleção dinâmica de estratégia baseada na audiência
- ✅ Flexibilidade para adicionar novas estratégias
- ✅ Separação entre contexto e algoritmo

## Estratégias Implementadas
1. **Judeus**: Usa Escrituras do AT e profecias messiânicas
2. **Gentios**: Começa com criação e Deus desconhecido
3. **Filósofos**: Argumentos filosóficos sofisticados
4. **Governantes**: Respeitoso, foca em justiça e juízo
5. **Pessoas Simples**: Linguagem direta e parábolas

## Como usar
```csharp
var paulo = new Paulo();
paulo.DefinirEstrategia(new EstrategiaJudeus());
paulo.Pregar("judeus na sinagoga");

paulo.DefinirEstrategia(new EstrategiaGentios());
paulo.Pregar("gentios no Areópago");
```

## Vantagens
- Elimina condicionais complexas
- Facilita adição de novas estratégias
- Permite mudança de algoritmo em tempo de execução
- Promove reutilização de código
