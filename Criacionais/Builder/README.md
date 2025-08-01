# Builder com Exemplo do Tabernáculo

## Versículo relacionado ao Builder
> “Conforme tudo o que eu te mostrar para modelo do tabernáculo, e para modelo de todos os seus móveis, assim mesmo o fareis.”  
> — Êxodo 25:9

**Explicação:** Deus deu a Moisés o modelo e as etapas para construir o Tabernáculo, assim como o padrão Builder define o passo a passo para construir um objeto complexo.

---

## O que é Builder?
O Builder é um padrão criacional que permite construir objetos complexos passo a passo, separando a construção da representação final. É útil quando o objeto a ser criado tem muitas partes ou pode ser montado de diferentes formas.

---

## Estrutura do exemplo
- **Tabernaculo.cs**: Objeto complexo a ser construído.
- **ITabernaculoBuilder.cs**: Interface do builder.
- **TabernaculoSimplesBuilder.cs**: Builder concreto (simples).
- **TabernaculoDetalhadoBuilder.cs**: Builder concreto (detalhado).
- **MoisesDirector.cs**: Coordena a construção.
- **MinhaAppBuilder.cs**: Classe de teste que demonstra o uso do padrão.

---

## Funcionamento
- O Director (Moisés) coordena a construção do Tabernáculo usando um builder.
- Cada builder pode criar um Tabernáculo diferente (simples ou detalhado).
- O cliente pode obter o resultado final chamando `ObterTabernaculo()`.

---

## Como rodar/testar
1. Salve os arquivos na pasta `Builder`.
2. No ponto de entrada do projeto (`Program.cs`), chame:
   ```csharp
   using GoFPatternsCSharp.Builder;
   class Program
   {
       static void Main(string[] args)
       {
           MinhaAppBuilder.Executar();
       }
   }
   ```
3. Execute:
   ```
   dotnet run
   ```

### Saída esperada:
```
Tabernáculo Simples:
Tabernáculo construído:
- Estrutura: Estrutura de madeira simples
- Altar: Altar de bronze
- Arca: Arca simples
- Cortinas: Cortinas de linho

Tabernáculo Detalhado:
Tabernáculo construído:
- Estrutura: Estrutura de madeira de acácia revestida de ouro
- Altar: Altar de bronze com detalhes em ouro
- Arca: Arca da Aliança com querubins de ouro
- Cortinas: Cortinas de linho fino bordadas com querubins
```

---

## O que você aprende com esse exemplo?
- Como construir objetos complexos passo a passo.
- Como separar a lógica de construção da representação final.
- Como aplicar o padrão em um contexto real e didático.

---

## Referências
- Livro: *Design Patterns: Elements of Reusable Object-Oriented Software* (GoF)
- Exemplo didático criado para facilitar o entendimento do padrão Builder
