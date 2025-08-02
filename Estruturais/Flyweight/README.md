# Flyweight com Exemplo Bíblico

## Versículo relacionado ao Flyweight
> "Lâmpada para os meus pés é tua palavra, e luz para o meu caminho"  
> — Salmos 119:105

**Explicação:** Assim como o Flyweight reutiliza objetos para economizar memória, os versículos bíblicos são reutilizados em diferentes contextos e aplicações, mantendo seu conteúdo intrínseco mas sendo aplicados de formas diversas.

---

## O que é Flyweight?
O Flyweight é um padrão estrutural que minimiza o uso de memória compartilhando eficientemente dados comuns entre múltiplos objetos similares. Separa estado intrínseco (compartilhado) do extrínseco (específico do contexto).

---

## Estrutura do exemplo
- **IVersiculo**: Interface flyweight para versículos.
- **VersiculoBiblico**: Flyweight concreto (estado intrínseco: texto, referência, tema).
- **FabricaVersiculos**: Factory que gerencia e reutiliza versículos.
- **AplicacaoVersiculo**: Context (estado extrínseco: contexto, aplicação, pessoa).

---

## Funcionamento
- Versículos são criados uma única vez e reutilizados em múltiplas aplicações.
- Estado intrínseco (texto do versículo) é compartilhado.
- Estado extrínseco (contexto de uso, pessoa) é passado como parâmetro.
- Factory garante que versículos idênticos sejam reutilizados.
- Demonstra economia significativa de memória com muitas aplicações.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Flyweight.
2. Observe como versículos são reutilizados em diferentes contextos.
3. Veja as estatísticas de economia de memória.
4. Note como poucos objetos flyweight servem muitas aplicações.

### Exemplo de uso:
```csharp
var versiculo = FabricaVersiculos.GetVersiculo("João 3:16");
var aplicacao = new AplicacaoVersiculo("João 3:16", "Evangelismo", "Compartilhar amor", "Pastor");
aplicacao.Aplicar();
```

---

## Vantagens
- **Economia de Memória**: Reduz drasticamente o uso de memória.
- **Performance**: Menos objetos na memória, melhor performance.
- **Reutilização**: Objetos são compartilhados eficientemente.
- **Escalabilidade**: Suporta grandes quantidades de objetos similares.
