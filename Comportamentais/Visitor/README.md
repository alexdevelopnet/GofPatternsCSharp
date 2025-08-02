# Padrão Visitor - Visitação aos Patriarcas

## Descrição
O padrão Visitor representa uma operação a ser executada nos elementos de uma estrutura de objetos. Visitor permite definir uma nova operação sem mudar as classes dos elementos sobre os quais opera.

## Exemplo Bíblico
Implementamos a **Visitação Divina aos Patriarcas** usando o padrão Visitor:

- **Visitor**: IVisitanteDivino
- **Concrete Visitors**: AnjoDoSenhor, EspiritoSanto, Jesus
- **Element**: IPatriarca
- **Concrete Elements**: Abraao, Isaque, Jaco, Jose, Moises
- **Object Structure**: LinhagemAbramica

## Funcionalidades
- ✅ Diferentes visitantes divinos
- ✅ Interações específicas com cada patriarca
- ✅ Mensagens personalizadas por visitante
- ✅ Estrutura flexível para novos visitantes

## Visitantes Implementados
1. **Anjo do Senhor**: Traz promessas e direções específicas
2. **Espírito Santo**: Capacita e transforma espiritualmente
3. **Jesus**: Revela significados proféticos e tipológicos

## Como usar
```csharp
var linhagem = new LinhagemAbramica();
var anjo = new AnjoDoSenhor();
var jesus = new Jesus();

linhagem.ReceberVisitacao(anjo);
linhagem.ReceberVisitacao(jesus);
```

## Vantagens
- Facilita adição de novas operações
- Centraliza operações relacionadas
- Mantém elementos simples
- Suporte a múltiplas operações
