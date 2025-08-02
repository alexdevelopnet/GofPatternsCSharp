# Padrão Interpreter - Interpretação das Escrituras

## Descrição
O padrão Interpreter define uma representação para a gramática de uma linguagem e um interpretador que usa a representação para interpretar sentenças na linguagem.

## Exemplo Bíblico
Implementamos a **Interpretação das Escrituras Sagradas** usando o padrão Interpreter:

- **Context**: ContextoEscritura (contém símbolos e interpretações)
- **Abstract Expression**: ExpressaoEscritura
- **Terminal Expression**: SimboloExpression
- **Non-terminal Expressions**: FraseProfeticaExpression, ParabolaExpression, VisaoApocalipticaExpression

## Funcionalidades
- ✅ Interpretação de símbolos bíblicos
- ✅ Análise de parábolas e visões
- ✅ Dicionário de símbolos expandível
- ✅ Diferentes tipos de expressões

## Símbolos Implementados
- **cordeiro** → Jesus Cristo, o sacrifício perfeito
- **leão** → Jesus Cristo, o Rei dos reis
- **pomba** → Espírito Santo
- **água** → Palavra de Deus ou Espírito Santo
- **pão** → Jesus Cristo, o pão da vida

## Como usar
```csharp
var interprete = new InterpreteEscrituras();
var contexto = new ContextoEscritura("");

interprete.InterpretarTexto("Eu sou o pão da vida", contexto);
interprete.InterpretarParabola();
interprete.InterpretarVisaoApocaliptica();
```

## Vantagens
- Facilita mudanças na gramática
- Implementação direta da gramática
- Facilita adição de novas interpretações
- Separação clara entre sintaxe e semântica
