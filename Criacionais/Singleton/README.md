# Singleton com Exemplo de Histórias da Bíblia

## Versículo relacionado ao Singleton
> “Ouve, Israel, o Senhor nosso Deus é o único Senhor.”  
> — Deuteronômio 6:4

**Explicação:** Assim como o Singleton garante uma única instância, a Bíblia afirma que só há um Deus verdadeiro.

Este exemplo demonstra o padrão de projeto **Singleton** usando um repositório de histórias bíblicas e a analogia da Arca de Noé.

## O que é Singleton?
O Singleton garante que uma classe tenha **apenas uma instância** e fornece um ponto global de acesso a ela. É útil quando você precisa de um único objeto compartilhado em todo o sistema.

---

## Exemplo 1: Repositório de Histórias Bíblicas
- **RepositorioHistoriasBiblicas.cs**: Classe Singleton que armazena e gerencia as histórias.
- **HistoriaBiblica.cs**: Representa uma história da Bíblia (título, referência, resumo).
- **MinhaAppSingletonHistorias.cs**: Classe de teste que demonstra o uso do Singleton.

### Versículo relacionado ao repositório
> “Santifica-os na verdade; a tua palavra é a verdade.”  
> — João 17:17

**Explicação:** Assim como o repositório Singleton centraliza as histórias, a Bíblia é a fonte central e única da verdade para o cristão.

## Exemplo 2: A Arca de Noé (Analogia)
- **ArcaDeNoe.cs**: Singleton que representa a única arca possível.
- **MinhaAppArcaDeNoe.cs**: Classe de teste que demonstra o uso do Singleton da Arca.

### Versículo relacionado à Arca de Noé
> “Entraram na arca com Noé, dois a dois de toda carne em que havia espírito de vida.”  
> — Gênesis 7:15

**Explicação:** Todos os salvos estavam na mesma arca, não havia outra opção — assim como o Singleton garante uma única instância.

---

## Funcionamento do Singleton (Arca de Noé)
- Só existe **uma arca** (uma instância do Singleton).
- Todos que embarcam, embarcam na **mesma arca** (todos usam o mesmo objeto).
- Não é possível criar outra arca (construtor privado).
- O método `Instancia` garante acesso global e único.

### Código principal
```csharp
var arca1 = ArcaDeNoe.Instancia;
arca1.Embarcar("Noé");
arca1.Embarcar("Leão");

var arca2 = ArcaDeNoe.Instancia;
arca2.Embarcar("Pomba");

arca1.ListarPassageiros();
Console.WriteLine($"arca1 e arca2 são a mesma instância? {object.ReferenceEquals(arca1, arca2)}");
```

### Saída esperada
```
Noé embarcou na Arca!
Leão embarcou na Arca!
Ovelha embarcou na Arca!
Pomba embarcou na Arca!
Passageiros na Arca:
- Noé
- Leão
- Ovelha
- Pomba
arca1 e arca2 são a mesma instância? True
```

---

## O que você aprende com esse exemplo?
- Como garantir uma única instância de um objeto compartilhado.
- Como acessar e manipular dados centralizados usando Singleton.
- Como aplicar o padrão em um contexto real e didático.

---

## Referências
- Livro: *Design Patterns: Elements of Reusable Object-Oriented Software* (GoF)
- Exemplo didático criado para facilitar o entendimento do padrão Singleton