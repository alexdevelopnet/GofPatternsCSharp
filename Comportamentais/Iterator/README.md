# Padrão Iterator - Livros da Bíblia

## Descrição
O padrão Iterator fornece uma maneira de acessar os elementos de um objeto agregado sequencialmente sem expor sua representação subjacente.

## Exemplo Bíblico
Implementamos a **Percorrência dos Livros da Bíblia** usando o padrão Iterator:

- **Iterator**: IIterator<LivroBiblico>
- **Concrete Iterators**: IteratorSequencial, IteratorPorTestamento, IteratorReverso
- **Aggregate**: IColecaoBiblica<LivroBiblico>
- **Concrete Aggregate**: Biblia

## Funcionalidades
- ✅ Iteração sequencial pelos livros
- ✅ Iteração filtrada por testamento
- ✅ Iteração reversa
- ✅ Múltiplas formas de percorrer a mesma coleção

## Como usar
```csharp
var biblia = new Biblia();
biblia.CarregarLivrosBiblicos();

var iterator = biblia.CriarIterator();
while (iterator.TemProximo())
{
    var livro = iterator.Proximo();
    Console.WriteLine(livro);
}
```

## Vantagens
- Acesso uniforme aos elementos
- Suporte a múltiplas traversals
- Interface simplificada
- Desacoplamento da estrutura interna
