# Abstract Factory com Exemplo da Bíblia

## Versículo relacionado ao Abstract Factory
> “Há um só corpo e um só Espírito, como também fostes chamados em uma só esperança da vossa vocação.”  
> — Efésios 4:4

**Explicação:** Assim como a Abstract Factory cria famílias de objetos relacionados, a Bíblia mostra que, mesmo com diferentes membros e funções, todos pertencem a uma mesma família espiritual.

---

## Por que Moisés e Jesus?
Neste exemplo, escolhemos **Moisés** (Antigo Testamento) e **Jesus** (Novo Testamento) para ilustrar o padrão Abstract Factory porque:
- **Moisés** é símbolo do Antigo Testamento, liderança e libertação (travessia do Mar Vermelho).
- **Jesus** é símbolo do Novo Testamento, provisão e salvação (multiplicação dos pães e peixes).
- Cada fábrica (Antigo ou Novo Testamento) cria uma família de objetos (história + personagem) marcantes daquele contexto.
- Isso mostra como o padrão permite trocar toda a “família” de objetos mudando apenas a fábrica, mantendo a relação entre eles.

---

## O que é Abstract Factory?
O Abstract Factory é um padrão criacional que permite criar famílias de objetos relacionados, sem especificar suas classes concretas. Ele separa a lógica de criação do uso dos objetos e garante que os objetos criados sejam compatíveis entre si.

---

## Estrutura do exemplo
- **IHistoriaBiblica.cs**: Interface para histórias bíblicas.
- **IPersonagemBiblico.cs**: Interface para personagens bíblicos.
- **HistoriaAntigoTestamento.cs / HistoriaNovoTestamento.cs**: Implementações concretas de histórias.
- **PersonagemAntigoTestamento.cs / PersonagemNovoTestamento.cs**: Implementações concretas de personagens.
- **IBibliaFactory.cs**: Interface da Abstract Factory.
- **AntigoTestamentoFactory.cs / NovoTestamentoFactory.cs**: Fábricas concretas.
- **MinhaAppAbstractFactory.cs**: Classe de teste que demonstra o uso do padrão.

---

## Funcionamento
- Cada fábrica concreta cria uma família de objetos (história + personagem) do mesmo "testamento".
- O cliente usa apenas a interface da fábrica, sem conhecer as classes concretas.
- É fácil trocar toda a família de objetos mudando apenas a fábrica.

---

## Como rodar/testar
1. Salve os arquivos na pasta `AbstractFactory`.
2. No ponto de entrada do projeto (`Program.cs`), chame:
   ```csharp
   using GoFPatternsCSharp.AbstractFactory;
   class Program
   {
       static void Main(string[] args)
       {
           MinhaAppAbstractFactory.Executar();
       }
   }
   ```
3. Execute:
   ```
   dotnet run
   ```

### Saída esperada:
```
Exemplo com Antigo Testamento:
História: A travessia do Mar Vermelho (Êxodo 14)
Personagem: Moisés

Exemplo com Novo Testamento:
História: A multiplicação dos pães e peixes (Mateus 14:13-21)
Personagem: Jesus
```

---

## O que você aprende com esse exemplo?
- Como criar famílias de objetos relacionados usando Abstract Factory.
- Como garantir compatibilidade entre objetos criados.
- Como aplicar o padrão em um contexto real e didático.

---

## Referências
- Livro: *Design Patterns: Elements of Reusable Object-Oriented Software* (GoF)
- Exemplo didático criado para facilitar o entendimento do padrão Abstract Factory
