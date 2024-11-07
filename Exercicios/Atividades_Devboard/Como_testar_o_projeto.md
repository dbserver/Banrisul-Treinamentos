# Como testar?

> Imagine que estamos desenvolvendo uma tarefa para adicionar uma nova funcionalidade no sistema, como uma calculadora com uma função de multiplicação. Vamos seguir uma abordagem bem didática para explicar como testar essa tarefa.

## 1. Compreensão da Tarefa

Primeiro, é importante entender a tarefa que você está testando. Por exemplo, se sua tarefa é adicionar uma função de multiplicação, pergunte-se:

- O que a função deve fazer? Multiplicar dois números e retornar o resultado.
- Qual será o comportamento esperado? Por exemplo, multiplicar 2 e 3 deve resultar em 6.

## 2. Planejar os Testes (O Que Incluir na Coluna de Testes)

> Na coluna de testes, você deve anotar os seguintes pontos:

**Cenários de Teste:** Liste os diferentes casos que você quer verificar. No exemplo da multiplicação, alguns cenários podem ser:

- Multiplicação de dois números positivos (ex.: 2 * 3 = 6).
- Multiplicação de um número positivo e um número negativo (ex.: 2 * -3 = -6).
- Multiplicação por zero (ex.: 5 * 0 = 0).
- Multiplicação de números negativos (ex.: -2 * -3 = 6).

**Critérios de Aceitação:** São as condições mínimas que a funcionalidade precisa cumprir para ser aceita. Por exemplo:

   | "A função deve retornar a multiplicação correta para qualquer par de números."

## 3. Escrever Casos de Teste

> Para cada cenário de teste listado, você vai criar um caso de teste, detalhando o que será verificado. Para cada caso de teste, escreva:

- Entrada: Valores que você usará no teste, por exemplo, multiplica(2, 3).
- Resultado Esperado: O que espera que a função retorne, como 6 para o exemplo multiplica(2, 3).

## Analisar os Resultados e Documentar

Depois de rodar os testes, atualize a coluna de testes:

- Se passou: Anote que a funcionalidade passou em todos os cenários e está pronta para o próximo estágio do desenvolvimento.
- Se falhou: Documente o erro encontrado e reenvie a tarefa para correção.

## Processo de Teste em um Ciclo de Desenvolvimento

- Compreenda a Tarefa e o que Deve ser Testado.
- Planeje os Testes e Liste Cenários na Coluna de Testes.
- Escreva os Casos de Teste (entrada e resultado esperado).
- Execute os Testes e Verifique os Resultados.
- Documente os Resultados e Atualize a Coluna de Testes.
