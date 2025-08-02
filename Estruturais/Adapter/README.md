# Adapter com Exemplo Bíblico

## Versículo relacionado ao Adapter
> “Fiz-me tudo para todos, para por todos os meios chegar a salvar alguns.”  
> — 1 Coríntios 9:22

**Explicação:** Assim como o Adapter permite que classes com interfaces incompatíveis trabalhem juntas, Paulo adaptava sua abordagem para alcançar diferentes pessoas.

---

## O que é Adapter?
O Adapter é um padrão estrutural que permite que interfaces incompatíveis trabalhem juntas, convertendo a interface de uma classe em outra esperada pelo cliente.

---

## Estrutura do exemplo
- **IMensagemEvangelho.cs**: Interface esperada pelo sistema.
- **MensagemJudaica.cs**: Classe existente com interface diferente.
- **AdapterPaulo.cs**: Adapter que permite usar MensagemJudaica como MensagemEvangelho.
- **MinhaAppAdapter.cs**: Demonstra o uso do Adapter.

---

## Funcionamento
- O sistema espera objetos do tipo IMensagemEvangelho.
- MensagemJudaica tem uma interface diferente.
- AdapterPaulo adapta MensagemJudaica para ser usada como IMensagemEvangelho.

---

## Como rodar/testar
1. Salve os arquivos na pasta `Estruturais/Adapter`.
2. No ponto de entrada do projeto (`Program.cs`), chame:
   ```csharp
   using Estruturais.Adapter;
   class Program
   {
       static void Main(string[] args)
       {
           MinhaAppAdapter.Executar();
       }
   }
   ```
3. Execute:
   ```
   dotnet run
   ```

### Saída esperada:
```
Paulo adapta a mensagem para o contexto:
Proclamando a Torah para o povo judeu!
```

---

## O que você aprende com esse exemplo?
- Como adaptar interfaces incompatíveis.
- Como aplicar o padrão Adapter em um contexto real e didático.

---

## Referências
- Livro: *Design Patterns: Elements of Reusable Object-Oriented Software* (GoF)
- Exemplo didático criado para facilitar o entendimento do padrão Adapter
