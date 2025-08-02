# Padrão State - Estados de Fé de Pedro

## Descrição
O padrão State permite que um objeto altere seu comportamento quando seu estado interno muda. O objeto parecerá ter mudado de classe.

## Exemplo Bíblico
Implementamos a **Jornada de Fé de Pedro** usando o padrão State:

- **Context**: Pedro (pessoa cuja fé muda)
- **States**: FeForte, FeAbalada, FeQuebrada, FeRestaurada, FeInabalavel
- **Transições**: Baseadas em situações e eventos bíblicos

## Funcionalidades
- ✅ Transições automáticas entre estados de fé
- ✅ Comportamentos diferentes para cada estado
- ✅ Reações específicas a situações
- ✅ Progressão realista da jornada espiritual

## Estados Implementados
1. **Fé Forte**: Estado inicial de confiança
2. **Fé Abalada**: Dúvidas e incertezas
3. **Fé Quebrada**: Após negação de Jesus
4. **Fé Restaurada**: Após perdão e restauração
5. **Fé Inabalável**: Estado final de maturidade

## Como usar
```csharp
var pedro = new Pedro();
pedro.EnfrentarDesafio("tempestade no mar");
pedro.EnfrentarDesafio("negação de Jesus");
pedro.ReceberEncorajamento();
```

## Vantagens
- Elimina condicionais complexas
- Facilita adição de novos estados
- Comportamento específico por estado
- Transições claras e controladas
