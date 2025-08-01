# Prototype com Exemplo do Rolo das Escrituras

## Versículo relacionado ao Prototype
> “E agora escrevei para vós este cântico, e ensinai-o aos filhos de Israel; põe-no na boca deles, para que este cântico me seja por testemunha contra os filhos de Israel.”  
> — Deuteronômio 31:19

**Explicação:** Deus ordenou que Moisés fizesse cópias do cântico para que todos tivessem acesso, assim como o Prototype permite criar cópias fiéis de um objeto original.

---

## O que é Prototype?
O Prototype é um padrão criacional que permite criar novos objetos copiando (clonando) um objeto existente, em vez de instanciar do zero. É útil quando a criação de um objeto é custosa ou complexa.

---

## Estrutura do exemplo
- **IRoloPrototype.cs**: Interface de clonagem.
- **RoloDasEscrituras.cs**: Objeto que pode ser clonado (Prototype).
- **MinhaAppPrototype.cs**: Classe de teste que demonstra o uso do padrão.

---

## Funcionamento
- O objeto original pode ser clonado para criar novas cópias independentes.
- Cada cópia pode ser modificada sem afetar o original.

---

## Como rodar/testar
1. Salve os arquivos na pasta `Prototype`.
2. No ponto de entrada do projeto (`Program.cs`), chame:
   ```csharp
   using GoFPatternsCSharp.Prototype;
   class Program
   {
       static void Main(string[] args)
       {
           MinhaAppPrototype.Executar();
       }
   }
   ```
3. Execute:
   ```
   dotnet run
   ```

### Saída esperada:
```
Rolo original:
Rolo: Isaías
Conteúdo: Consolai, consolai o meu povo, diz o vosso Deus.

Rolo copiado:
Rolo: Cópia de Isaías
Conteúdo: Consolai, consolai o meu povo, diz o vosso Deus.

Rolo original permanece inalterado:
Rolo: Isaías
Conteúdo: Consolai, consolai o meu povo, diz o vosso Deus.
```

---

## O que você aprende com esse exemplo?
- Como criar cópias fiéis de objetos usando Prototype.
- Como modificar cópias sem afetar o original.
- Como aplicar o padrão em um contexto real e didático.

---

## Referências
- Livro: *Design Patterns: Elements of Reusable Object-Oriented Software* (GoF)
- Exemplo didático criado para facilitar o entendimento do padrão Prototype 
