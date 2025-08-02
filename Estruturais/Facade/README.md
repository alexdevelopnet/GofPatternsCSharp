# Facade com Exemplo Bíblico

## Versículo relacionado ao Facade
> "Tudo, porém, seja feito com decência e ordem"  
> — 1 Coríntios 14:40

**Explicação:** Assim como o Facade simplifica o acesso a subsistemas complexos, a organização de um culto envolve coordenar múltiplos sistemas (áudio, iluminação, climatização, etc.) através de uma interface simples.

---

## O que é Facade?
O Facade é um padrão estrutural que fornece uma interface simplificada para um subsistema complexo. Ele define uma interface de nível mais alto que torna o subsistema mais fácil de usar.

---

## Estrutura do exemplo
- **SistemaAudio, SistemaIluminacao, etc.**: Subsistemas complexos do templo.
- **CultoFacade**: Interface simplificada que coordena todos os subsistemas.
- Operações: PrepararCulto(), IniciarLouvor(), IniciarPregacao(), etc.

---

## Funcionamento
- O Facade coordena múltiplos subsistemas (áudio, iluminação, climatização, segurança, limpeza, ministério).
- Oferece métodos simples como "PrepararCulto()" que executam operações complexas nos bastidores.
- Permite tanto controle simplificado quanto acesso granular aos subsistemas.
- Encapsula a complexidade da coordenação de um culto completo.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Facade.
2. Observe como um culto completo é organizado com uma única chamada.
3. Veja também o controle granular das etapas individuais.
4. Note como a complexidade é ocultada do cliente.

### Exemplo de uso:
```csharp
var culto = new CultoFacade();
// Culto completo com uma única chamada
culto.CultoCompleto();

// Ou controle granular
culto.PrepararCulto();
culto.IniciarLouvor();
culto.EncerrarCulto();
```

---

## Vantagens
- **Simplicidade**: Interface simples para operações complexas.
- **Desacoplamento**: Cliente não precisa conhecer os subsistemas.
- **Flexibilidade**: Permite uso simplificado e granular.
- **Manutenibilidade**: Mudanças nos subsistemas não afetam o cliente.
