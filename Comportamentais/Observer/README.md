# Padrão Observer - Anunciação aos Pastores

## Descrição
O padrão Observer define uma dependência um-para-muitos entre objetos, de modo que quando um objeto muda de estado, todos os seus dependentes são notificados e atualizados automaticamente.

## Exemplo Bíblico
Implementamos a **Anunciação do Nascimento de Jesus** usando o padrão Observer:

- **Subject**: Anjo do Senhor (notifica sobre eventos divinos)
- **Observers**: Pastores, Reis Magos, Maria (recebem as notificações)
- **Eventos**: Nascimento de Jesus, Glória a Deus

## Funcionalidades
- ✅ Notificação automática de múltiplos observadores
- ✅ Adição e remoção dinâmica de observadores
- ✅ Desacoplamento entre subject e observers
- ✅ Diferentes tipos de observadores (Pastores, Reis Magos, Maria)

## Como usar
```csharp
var anjoGabriel = new AnjoDoSenhor("Gabriel");
var pastorJose = new Pastor("José", "campos de Belém");
var reiGaspar = new ReiMago("Gaspar", "ouro");

anjoGabriel.Attach(pastorJose);
anjoGabriel.Attach(reiGaspar);
anjoGabriel.AnunciarNascimento();
```

## Vantagens
- Baixo acoplamento entre Subject e Observer
- Suporte a comunicação broadcast
- Adição/remoção dinâmica de observadores
- Princípio Aberto/Fechado respeitado
