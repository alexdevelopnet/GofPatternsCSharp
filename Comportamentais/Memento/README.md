# Padrão Memento - Restauração de Jó

## Descrição
O padrão Memento captura e externaliza o estado interno de um objeto sem violar o encapsulamento, de modo que o objeto possa ser restaurado para este estado mais tarde.

## Exemplo Bíblico
Implementamos a **Restauração de Jó** usando o padrão Memento:

- **Originator**: Jo (objeto cujo estado é salvo)
- **Memento**: EstadoJo (armazena o estado de Jó)
- **Caretaker**: PlanoRedentor (Deus - gerencia os mementos)
- **States**: Riqueza, filhos, saúde, estado espiritual

## Funcionalidades
- ✅ Salvamento do estado antes das provações
- ✅ Restauração após fidelidade comprovada
- ✅ Histórico de estados com timestamps
- ✅ Encapsulamento do estado interno

## Como usar
```csharp
var jo = new Jo();
var planoRedentor = new PlanoRedentor("Deus Todo-Poderoso");

// Salvar estado antes das provações
planoRedentor.SalvarEstado(jo);

// Jó passa pelas provações
jo.SofrerPerdasMateriais();
jo.SofrerDoenca();

// Restauração final
jo.ReceberRestauracaoCompleta();
```

## Vantagens
- Preserva encapsulamento
- Simplifica o Originator
- Facilita operações de undo
- Histórico de estados
