# Padrão Mediator - Conselho de Jerusalém

## Descrição
O padrão Mediator define como um conjunto de objetos interage. Mediator promove o acoplamento fraco ao evitar que objetos se refiram uns aos outros explicitamente, e permite variar sua interação independentemente.

## Exemplo Bíblico
Implementamos o **Conselho de Jerusalém (Atos 15)** usando o padrão Mediator:

- **Mediator**: IConselhoMediator
- **Concrete Mediator**: ConselhoJerusalem
- **Colleagues**: Pedro, Paulo, Barnabé, Tiago
- **Communication**: Decisões sobre doutrina e práticas cristãs

## Funcionalidades
- ✅ Mediação de comunicação entre apóstolos
- ✅ Decisões coletivas coordenadas
- ✅ Registro e gerenciamento de participantes
- ✅ Resolução de questões doutrinárias

## Como usar
```csharp
var conselho = new ConselhoJerusalem();
var pedro = new Pedro(conselho);
var paulo = new Paulo(conselho);

conselho.RegistrarApostolo(pedro);
conselho.RegistrarApostolo(paulo);

paulo.EnviarMensagem("Precisamos resolver a questão da circuncisão!");
conselho.TomarDecisao("gentios e circuncisão");
```

## Vantagens
- Reduz dependências entre objetos
- Centraliza lógica de interação
- Facilita manutenção
- Promove reutilização
