# Padrão Template Method - Rituais de Adoração

## Descrição
O padrão Template Method define o esqueleto de um algoritmo em uma operação, postergando alguns passos para as subclasses. Template Method permite que subclasses redefinam certos passos de um algoritmo sem mudar a estrutura do algoritmo.

## Exemplo Bíblico
Implementamos os **Rituais de Adoração** usando o padrão Template Method:

- **Abstract Class**: RitualAdoracao (define o template)
- **Concrete Classes**: CultoTemploSalomao, CultoSinagoga, CultoCristao, CultoDeserto
- **Template Method**: RealizarCulto() (algoritmo geral)
- **Primitive Operations**: PrepararLocal(), Adorar(), Pregar() (varia por contexto)

## Funcionalidades
- ✅ Estrutura comum para todos os cultos
- ✅ Personalização específica por tipo de culto
- ✅ Reutilização de código comum
- ✅ Hook methods para customização opcional

## Tipos de Culto Implementados
1. **Templo de Salomão**: Ritual elaborado com levitas
2. **Sinagoga**: Leitura da Torah e Shemá
3. **Igreja Primitiva**: Ceia do Senhor e evangelhos
4. **Deserto (Moisés)**: Tabernáculo e holocaustos

## Como usar
```csharp
var cultoTemplo = new CultoTemploSalomao();
cultoTemplo.RealizarCulto();

var cultoCristao = new CultoCristao();
cultoCristao.RealizarCulto();
```

## Vantagens
- Reutilização de código
- Controle da estrutura do algoritmo
- Facilita manutenção
- Princípio de Inversão de Dependência
