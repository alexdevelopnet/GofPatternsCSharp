# Composite com Exemplo Bíblico

## Versículo relacionado ao Composite
> "E ele mesmo deu uns para apóstolos, e outros para profetas, e outros para evangelistas, e outros para pastores e doutores"  
> — Efésios 4:11

**Explicação:** Assim como o Composite permite tratar objetos individuais e composições de objetos uniformemente, a igreja tem uma hierarquia onde cada membro (individual) e cada liderança (composite) têm funções específicas, mas todos fazem parte do mesmo corpo.

---

## O que é Composite?
O Composite é um padrão estrutural que permite compor objetos em estruturas de árvore para representar hierarquias parte-todo. Permite que clientes tratem objetos individuais e composições de objetos de maneira uniforme.

---

## Estrutura do exemplo
- **ElementoIgreja**: Componente abstrato que define interface comum.
- **MembroIgreja**: Folha (leaf) - representa membros individuais.
- **LiderancaIgreja**: Composite - pode conter outros elementos.
- Hierarquia: Pastor → Presbíteros → Diáconos → Membros

---

## Funcionamento
- Cada elemento da igreja (membro ou liderança) implementa as mesmas operações.
- Lideranças podem conter outros elementos, formando uma árvore hierárquica.
- Operações como ministrar, contar membros e mostrar hierarquia funcionam recursivamente.
- Permite adicionar e remover membros dinamicamente.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Composite.
2. Observe a construção da hierarquia da igreja.
3. Veja como as operações são executadas em cascata.
4. Note a flexibilidade de reorganizar a estrutura.

### Exemplo de uso:
```csharp
var pastor = new LiderancaIgreja("Pastor João", "Pastor Principal", "Apascenta as minhas ovelhas");
var membro = new MembroIgreja("Maria", "Líder de Louvor", "Música");
pastor.AdicionarMembro(membro);
pastor.MostrarHierarquia();
```

---

## Vantagens
- **Uniformidade**: Trata objetos individuais e compostos da mesma forma.
- **Flexibilidade**: Fácil adicionar novos tipos de componentes.
- **Simplicidade**: Cliente não precisa distinguir entre folhas e composites.
- **Recursividade**: Operações funcionam naturalmente em toda a árvore.
