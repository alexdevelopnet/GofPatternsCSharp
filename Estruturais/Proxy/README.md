# Proxy com Exemplo Bíblico

## Versículo relacionado ao Proxy
> "Toda a Escritura divinamente inspirada é proveitosa para ensinar, para redarguir, para corrigir, para instruir em justiça"  
> — 2 Timóteo 3:16

**Explicação:** Assim como o Proxy controla o acesso a um objeto, o acesso às Escrituras Sagradas pode ser controlado com diferentes níveis de permissão, cache para modo offline, e funcionalidades adicionais como logging e lazy loading.

---

## O que é Proxy?
O Proxy é um padrão estrutural que fornece um substituto ou placeholder para outro objeto para controlar o acesso a ele. Pode adicionar funcionalidades como lazy loading, controle de acesso, cache, e logging.

---

## Estrutura do exemplo
- **IEscriturasSagradas**: Interface comum para acesso às escrituras.
- **EscriturasSagradas**: RealSubject - acesso real às escrituras (recurso "pesado").
- **ProxyEscrituras**: Proxy que controla acesso com permissões, cache e logging.
- Níveis de acesso: Visitante, Membro, Líder, Pastor.

---

## Funcionamento
- Controla acesso baseado em níveis de permissão (Visitante < Membro < Líder < Pastor).
- Implementa lazy loading - carrega escrituras apenas quando necessário.
- Oferece cache para modo offline.
- Registra todos os acessos para auditoria.
- Adiciona funcionalidades sem modificar o objeto real.

---

## Como rodar/testar
1. Execute o programa principal e escolha a opção do Proxy.
2. Observe diferentes níveis de acesso e suas limitações.
3. Veja o lazy loading em ação na primeira chamada.
4. Note o sistema de cache para modo offline.
5. Observe o logging de todas as operações.

### Exemplo de uso:
```csharp
var proxy = new ProxyEscrituras("Membro");
proxy.LerCapitulo("João", 3); // Carrega escrituras na primeira vez
proxy.PesquisarTema("Salvação"); // Usa escrituras já carregadas
```

---

## Vantagens
- **Controle de Acesso**: Implementa diferentes níveis de permissão.
- **Lazy Loading**: Carrega recursos apenas quando necessário.
- **Cache**: Suporte a modo offline com cache local.
- **Logging**: Registra todas as operações para auditoria.
- **Transparência**: Cliente usa a mesma interface do objeto real.
