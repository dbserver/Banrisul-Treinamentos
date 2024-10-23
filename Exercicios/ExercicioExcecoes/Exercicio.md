
# Exceções

1) Se nenhuma exceção é lançada em um bloco try, onde o controle de execução
prossegue quando o bloco try termina a execução?

2) O que acontece se nenhum catch for executado quando ocorrer um exceção?

3) Escreva um programa para preencher valores de um vetor de inteiros com 10
posições. O usuário irá informar os valores a serem inseridos e suas respectivas
posições no array. O programa deve tratar as exceções
IndexOutOfRangeException quando for informada uma posição
inexistente do vetor e FormatException quando o valor informado não
for numero. 

4) Crie um programa que receba n números e some esses numeros enquanto a soma
não for superior a 100. O programa deverá imprimir o valor somado (antes de
atingir o número maior que 100) e deverá informar quantos números foram
somados e qual a média. Refaça seu programa utilizando as seguintes regras:

* Utilize os tratamentos de exceção para lidar com a entrada de dados.
*  Quando a soma for superior a 100, o programa deverá gerar uma exceção
criada pelo programador, com nome ExcecaoAcimaDeCem.
*  Lance essa exceção, com o uso de throws
