# Bridge com Exemplo Bíblico

## Versículo relacionado ao Bridge
> "Orai sem cessar."  
> — 1 Tessalonicenses 5:17

**Explicação:** Assim como o Bridge separa a abstração (tipos de oração) da implementação (formas de orar), permitindo que diferentes tipos de oração sejam realizados de diferentes maneiras, mantendo a flexibilidade.

---

## O que é Bridge?
O Bridge é um padrão estrutural que separa uma abstração de sua implementação, permitindo que ambas variem independentemente. É útil quando você quer evitar um vínculo permanente entre uma abstração e sua implementação.

---

## Estrutura do exemplo
- **IFormaOracao**: Interface implementor que define como orar.
- **OracaoIndividual, OracaoColetiva, etc.**: Implementações concretas das formas de oração.
- **TipoOracao**: Abstração que define tipos de oração.
- **OracaoGratidao, OracaoIntercesao, etc.**: Abstrações refinadas para tipos específicos.

---

## Funcionamento
- Diferentes tipos de oração (Gratidão, Intercessão, Perdão, Súplica) podem ser realizados através de diferentes formas (Individual, Coletiva, Litúrgica, Espontânea).
- O padrão permite combinar qualquer tipo com qualquer forma, oferecendo flexibilidade total.
- É possível mudar a forma de oração dinamicamente durante a execução.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Bridge.
2. Observe como diferentes tipos de oração são realizados com diferentes formas.
3. Note a flexibilidade de mudar formas durante a execução.

### Exemplo de uso:
```csharp
var gratidao = new OracaoGratidao(new OracaoIndividual());
gratidao.RealizarOracao();

// Mudando a forma dinamicamente
gratidao.MudarFormaOracao(new OracaoColetiva());
gratidao.RealizarOracao();
```

---

## Vantagens
- **Flexibilidade**: Permite combinar qualquer abstração com qualquer implementação.
- **Extensibilidade**: Novos tipos de oração e formas podem ser adicionados independentemente.
- **Desacoplamento**: Abstração e implementação podem evoluir separadamente.
- **Reutilização**: Implementações podem ser compartilhadas entre diferentes abstrações.
