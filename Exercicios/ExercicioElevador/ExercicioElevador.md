# Sistema de Elevadores 

Neste exercício, você irá criar um programa para simular o funcionamento de elevadores em um edifício com múltiplos andares. O objetivo é determinar qual elevador deve atender a uma solicitação de uso.
Descrição do Problema

* O edifício possui vários elevadores, que podem estar em diferentes andares e se movimentando para cima ou para baixo.

* Cada elevador pode estar em uma das três condições: parado em um andar específico, subindo ou descendo.

* Os elevadores se movimentam sempre de andar em andar, sem paradas entre os andares.

## Regras do Funcionamento dos Elevadores

* Solicitação do Elevador
    - Quando um elevador é solicitado, a chamada será feita, por padrão, do último andar do edifício.

* Movimento dos Elevadores
    - Um elevador só muda de direção ao atingir o último ou o primeiro andar do edifício.
    - Não é permitido que um elevador inverta a direção no meio do trajeto. Por exemplo, em um prédio com 10 andares, um elevador que está subindo do 3º andar deve continuar subindo até o 10º andar antes de começar a descer.

* Condições dos Andares
    - O prédio tem um número específico de andares, e cada andar é identificado por um número inteiro. Por exemplo, em um edifício de 10 andares, os andares são numerados de 1 a 10.
    - Um elevador nunca estará "entre" andares. Ele estará sempre posicionado em um andar inteiro.

### Objetivo

Escreva um programa que, dado o estado inicial dos elevadores e uma solicitação de uso, determine qual elevador será o mais adequado para atender a chamada, com base nas regras acima.
#### Exemplos

* Edifício de 10 Andares
    - Elevador A: parado no 5º andar, subindo.
    - Elevador B: parado no 2º andar, descendo.
    - Elevador C: parado no 8º andar, subindo.

    Se uma solicitação for feita a partir do 10º andar, qual elevador deve ser enviado para atender a chamada?