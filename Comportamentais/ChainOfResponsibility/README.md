# Padrão Chain of Responsibility - Cadeia de Intercessão

## Descrição
O padrão Chain of Responsibility evita acoplar o remetente de uma solicitação ao seu receptor, dando a mais de um objeto a oportunidade de tratar a solicitação. Encadeia os objetos receptores e passa a solicitação ao longo da cadeia até que um objeto a trate.

## Exemplo Bíblico
Implementamos a **Cadeia de Intercessão** usando o padrão Chain of Responsibility:

- **Handler**: IntercessorHandler (base para todos os intercessores)
- **Concrete Handlers**: IrmaoIntercessor, PastorIntercessor, AnjoIntercessor, EspiritoSantoIntercessor, CristoIntercessor
- **Request**: PedidoOracao (com tipo, descrição e urgência)
- **Chain**: Irmão → Pastor → Anjo → Espírito Santo → Jesus Cristo

## Funcionalidades
- ✅ Cadeia hierárquica de intercessão
- ✅ Diferentes níveis de responsabilidade
- ✅ Tratamento baseado na urgência e tipo do pedido
- ✅ Flexibilidade para adicionar novos intercessores

## Como usar
```csharp
var irmaoJoao = new IrmaoIntercessor("João");
var pastorPedro = new PastorIntercessor("Pedro");
var anjoGabriel = new AnjoIntercessor("Gabriel");

irmaoJoao.DefinirProximo(pastorPedro);
pastorPedro.DefinirProximo(anjoGabriel);

var pedido = new PedidoOracao("cura", "Pessoa doente", 3);
irmaoJoao.Interceder(pedido);
```

## Vantagens
- Desacopla remetente e receptor
- Flexibilidade na cadeia de responsabilidade
- Facilita adição de novos handlers
- Distribuição dinâmica de responsabilidades
