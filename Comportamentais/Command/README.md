# Padrão Command - Milagres de Jesus

## Descrição
O padrão Command encapsula uma solicitação como um objeto, permitindo parametrizar clientes com diferentes solicitações, enfileirar ou registrar solicitações e suportar operações que podem ser desfeitas.

## Exemplo Bíblico
Neste exemplo, implementamos os **Milagres de Jesus** usando o padrão Command:

- **Receiver**: Jesus (quem executa os milagres)
- **Commands**: CurarCegoCommand, MultiplicarPaesCommand, CaminharAguasCommand
- **Invoker**: Discípulos (quem invoca os comandos)
- **Client**: Aplicação que configura os comandos

## Funcionalidades
- ✅ Execução de diferentes tipos de milagres
- ✅ Histórico de milagres realizados
- ✅ Capacidade de desfazer milagres (Undo)
- ✅ Separação entre quem solicita e quem executa

## Como usar
```csharp
var jesus = new Jesus();
var curarCego = new CurarCegoCommand(jesus);
var discipulos = new Discipulos();

discipulos.ExecutarMilagre(curarCego);
discipulos.DesfazerUltimoMilagre();
```

## Vantagens
- Desacopla o objeto que invoca a operação do objeto que a executa
- Permite parametrizar objetos com diferentes solicitações
- Suporte a operações de desfazer (undo)
- Facilita a criação de macros e filas de comandos
