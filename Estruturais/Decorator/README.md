# Decorator com Exemplo Bíblico

## Versículo relacionado ao Decorator
> "Mas o fruto do Espírito é: amor, gozo, paz, longanimidade, benignidade, bondade, fé, mansidão, temperança"  
> — Gálatas 5:22-23

**Explicação:** Assim como o Decorator adiciona responsabilidades a um objeto dinamicamente, as virtudes cristãs são "decoradas" na vida do crente, uma por uma, transformando-o progressivamente à imagem de Cristo.

---

## O que é Decorator?
O Decorator é um padrão estrutural que permite adicionar novos comportamentos a objetos colocando-os dentro de wrappers que contêm esses comportamentos. Oferece uma alternativa flexível à subclasse para estender funcionalidades.

---

## Estrutura do exemplo
- **IPessoa**: Interface comum para pessoas.
- **PessoaBase**: Implementação básica de uma pessoa.
- **VirtudeCrista**: Decorator abstrato para virtudes.
- **Fe, Esperanca, Amor, etc.**: Decorators concretos para virtudes específicas.

---

## Funcionamento
- Uma pessoa base pode ser "decorada" com diferentes virtudes cristãs.
- Cada virtude adiciona descrição, versículo bíblico e nível espiritual.
- Virtudes podem ser combinadas livremente, criando pessoas com diferentes perfis espirituais.
- O padrão permite adicionar/remover virtudes dinamicamente.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Decorator.
2. Observe como virtudes são adicionadas progressivamente.
3. Veja diferentes combinações de virtudes em diferentes pessoas.
4. Note como o nível espiritual aumenta com cada virtude.

### Exemplo de uso:
```csharp
IPessoa joao = new PessoaBase("João");
joao = new Fe(joao);
joao = new Amor(joao);
joao = new Paciencia(joao);
Console.WriteLine(joao.GetDescricao());
```

---

## Vantagens
- **Flexibilidade**: Adiciona comportamentos dinamicamente.
- **Combinação**: Permite múltiplas combinações de virtudes.
- **Extensibilidade**: Fácil adicionar novas virtudes.
- **Responsabilidade Única**: Cada decorator tem uma responsabilidade específica.
