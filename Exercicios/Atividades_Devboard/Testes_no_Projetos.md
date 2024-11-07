# Sobre Testes

>O que é testes?

Os sistemas de software são parte integrante da nossa vida atual. A maioria das pessoas já teve uma experiência com software que não funcionou de acordo com o esperado. O software que não funciona corretamente pode provocar muitos problemas, incluindo perdas de tempo, dinheiro ou reputação profissional e, em casos extremos, mesmo ferimentos ou morte. Os testes de software avaliam a qualidade do software e ajudam a reduzir o risco de falha do software em funcionamento.

Os testes de software são um conjunto de atividades concebidas para descobrir os defeitos e avaliar a qualidade dos artefactos de software. Estes artefactos, quando estão a ser testados, são conhecidos como objetos de teste. Um erro comum sobre os testes é que os mesmos consistem apenas na execução de testes (ou seja, na execução do software e verificação dos resultados do teste).

Outro erro comum sobre os testes é que os mesmos se concentram exclusivamente na verificação do objeto de teste. Embora os testes impliquem verificação, ou seja, verificar se o sistema cumpre os requisitos especificados, também implica validação, o que significa verificar se o sistema irá satisfazer as necessidades dos utilizadores e dos outros stakeholders nos respetivos ambientes operacionais.

## Objetivos de Teste

>Os objetivos de teste típicos são:

• Avaliar produtos de trabalho, tais como requisitos, user stories, conceções e código
• Encontrar falhas e defeitos
• Assegurar a cobertura requerida do objeto de teste
• Reduzir o nível de risco de software com qualidade inadequada
• Verificar se todos os requisitos especificados foram cumpridos
• Verificar se o objeto de teste cumpre os requisitos contratuais, legais e regulamentares
• Fornecer informação aos stakeholders para que possam tomar decisões informadas
• Aumentar a confiança na qualidade do objeto de teste
• Validar se o objeto de teste está concluído e funciona como esperado pelos stakeholders

## Testes e Debugging

Os testes e o debugging são atividades separadas. Os testes podem acionar falhas que são causadas por defeitos no software (teste dinâmico) ou podem encontrar defeitos diretamente no objeto de teste (teste estático).
Quando o teste dinâmico (ver Capítulo 4) aciona uma falha, o debugging tem como foco encontrar as causas desta falha (defeitos), analisar as respetivas causas e proceder à sua eliminação.

>O processo típico de debugging neste caso implica:

• Reproduzir a falha
• Diagnóstico (encontrar a causa raiz do defeito)
• Corrigir a causa

## Erros, Defeitos, Falhas e Causas Raiz do Defeito

Os seres humanos cometem erros (enganos), o que pode levar à introdução de defeitos (bugs), o que, por sua vez, pode resultar em falhas. Os seres humanos cometem erros por vários motivos, tais como pressão de tempo, complexidade dos produtos de trabalho, processos, infraestrutura ou interações, ou simplesmente devido ao cansaço ou porque não têm a formação adequada.

## Abordagem Shift-Left

A abordagem "Shift-Left" é uma maneira de pensar em testes que incentiva a realização dos testes o mais cedo possível no ciclo de desenvolvimento de software (SDLC). Em vez de esperar para testar apenas quando o código está pronto ou quando os componentes estão integrados, o objetivo do Shift-Left é começar o processo de validação o quanto antes, ajudando a identificar e corrigir problemas no início. Isso evita que erros fiquem escondidos até as fases finais, o que pode ser mais caro e demorado para corrigir.

## Como Funciona a Abordagem Shift-Left

> Vamos ver algumas práticas que ilustram essa abordagem para entender como aplicá-la na rotina de desenvolvimento:

**Revisar a Especificação com Olhar Crítico de Teste:** Antes mesmo de começar a programar, é útil analisar as especificações do projeto. Imagine que você está revisando um documento que descreve como uma funcionalidade deve funcionar. Ler com atenção e pensar como aquilo será testado pode ajudar a identificar requisitos que estejam confusos, faltando detalhes, ou até mesmo contradições. Isso evita problemas depois, quando alguém percebe que há algo errado na especificação original.

**Escrever Casos de Teste Antes do Código (Testes Pré-código):** Aqui, o objetivo é planejar como você vai testar o código antes de escrevê-lo. Pense nos testes como um guia: ao escrever casos de teste primeiro, você já tem uma ideia clara de como o código deve funcionar. Por exemplo, se você está desenvolvendo uma calculadora, poderia escrever um teste para ver se a função de "somar" retorna o valor esperado. Depois, ao implementar a função, você já sabe se ela atende ao que o teste exige.

**Usar Integração Contínua (CI) e Deploy Contínuo (CD):** CI/CD são práticas de automação para enviar o código para o repositório e testá-lo automaticamente, permitindo um feedback rápido sobre a qualidade. Por exemplo, ao enviar uma mudança de código para o repositório (como o GitHub ou GitLab), um sistema de CI/CD pode rodar uma série de testes automaticamente, alertando rapidamente sobre erros. Assim, você corrige antes que o erro se espalhe para outras partes do sistema.

**Análise Estática do Código Antes dos Testes Dinâmicos:** A análise estática verifica o código sem executá-lo, ajudando a identificar problemas como erros de sintaxe ou padrões ruins. Ferramentas de análise de código, como o ESLint para JavaScript, verificam automaticamente o código enquanto ele está sendo escrito. Dessa forma, erros simples podem ser corrigidos rapidamente, economizando tempo nos testes dinâmicos, que exigem execução.

**Testes Não-Funcionais Desde o Início (quando possível):** Além dos testes funcionais (que verificam se o sistema faz o que deveria), testes não-funcionais (como desempenho e segurança) podem ser feitos desde cedo. Por exemplo, testar o tempo de resposta de uma funcionalidade ainda em desenvolvimento pode revelar problemas de performance logo no começo, facilitando as melhorias.

## Benefícios e Investimento do Shift-Left

Implementar o Shift-Left pode requerer um esforço maior no início, como configurar ferramentas de CI/CD ou definir bons casos de teste. Entretanto, isso reduz retrabalho e problemas críticos na fase final, poupando tempo e custos. É uma abordagem que visa qualidade contínua e constante validação do que está sendo desenvolvido, aumentando a confiança no código.

## Níveis de Teste e Como o Shift-Left Interage com Eles

**Teste de Componentes (Unitário):** O teste unitário valida partes pequenas do código, como funções individuais, de forma isolada. Por exemplo, em um sistema de login, poderia haver um **teste unitário para verificar se a função** de verificar senha retorna verdadeiro para a senha correta. Esse é um ponto importante do Shift-Left, pois esses testes são rápidos e pegam erros logo que o código é escrito.

**Teste de Integração de Componentes:** Quando diferentes componentes começam a interagir, testamos para garantir que a comunicação entre eles funciona bem. Imagine um sistema de e-commerce: a integração entre o carrinho e o sistema de pagamento precisa ser testada. O Shift-Left aplica-se aqui ao permitir que esses testes sejam executados automaticamente assim que os componentes são conectados, por meio de uma estratégia de integração contínua.

**Teste de Sistema:** Este nível abrange o comportamento do sistema completo. Por exemplo, ao testar um aplicativo web, executa-se um fluxo do início ao fim, como a compra de um produto. Com o Shift-Left, o objetivo é iniciar a automação desses testes o quanto antes, criando scripts que simulam as interações dos usuários.

**Teste de Integração de Sistemas:** Quando vários sistemas precisam interagir (como um sistema de vendas integrado a um sistema de estoque), o teste verifica se eles trabalham juntos corretamente. Shift-Left incentiva a automatizar e realizar esses testes sempre que uma nova integração acontece, evitando problemas futuros.

**Teste de Aceitação:** Focado em validar que o sistema está pronto para os usuários finais. Imagine um novo recurso de cadastro, que precisa ser testado por pessoas reais. Com Shift-Left, parte desses testes de aceitação pode ser antecipada, com a ajuda de testes automatizados que simulam o uso real antes de chegar aos usuários finais.
