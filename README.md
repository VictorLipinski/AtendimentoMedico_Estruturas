# AtendimentoMedico_Estruturas

## Sistema de Atendimento Médico - Estruturas de Dados
Este programa simula o gerenciamento de pacientes utilizando diversas estruturas de dados comuns em programação, como vetores, matrizes, listas, filas, pilhas e algoritmos de pesquisa. O objetivo principal é fornecer uma interface simples para interagir com essas estruturas e realizar operações como inserção, remoção, busca e exibição de pacientes.

## Funcionalidades
O programa oferece as seguintes funcionalidades:

Trabalhar com Vetores
  - Inserir pacientes em um vetor.
  - Remover pacientes do vetor.
  - Buscar pacientes por ID.
  - Exibir todos os pacientes presentes no vetor.
  - 
Trabalhar com Matrizes
  - Inserir pacientes em uma matriz.
  - Remover pacientes de uma posição específica.
  - Buscar pacientes por ID na matriz.
  - Exibir todos os pacientes organizados na matriz.
  
 Trabalhar com Lista
  - Inserir pacientes em uma lista.
  - Remover pacientes da lista.
  - Buscar pacientes por ID.
  - Exibir todos os pacientes da lista.

Trabalhar com Fila
  - Enfileirar pacientes (adicionar ao final da fila).
  - Desenfileirar pacientes (remover do início da fila).
  - Buscar pacientes por ID na fila.
  - Exibir todos os pacientes na fila.

Trabalhar com Pilha
  - Empilhar pacientes (adicionar ao topo da pilha).
  - Desempilhar pacientes (remover do topo da pilha).
  - Buscar pacientes por ID na pilha.
  - Exibir todos os pacientes na pilha.

Algoritmos de Pesquisa
  - Pesquisa Sequencial: Percorre o vetor em busca de um paciente.
  - Pesquisa Binária: Realiza uma busca otimizada em um vetor ordenado, buscando o paciente por ID.

## Estruturas de Dados Utilizadas
  1. Vetores
  O vetor armazena pacientes de maneira sequencial, permitindo que operações de inserção e remoção sejam feitas de forma eficiente até o limite do vetor.

  2. Matrizes
  A matriz armazena pacientes em um formato bidimensional, permitindo que os pacientes sejam distribuídos por "linhas" e "colunas".

  3. Listas
  A lista é uma coleção dinâmica que permite inserção e remoção de elementos de forma flexível.

  4. Filas
  A fila segue a estrutura FIFO (First In, First Out), ou seja, o primeiro paciente a ser enfileirado será o primeiro a ser desenfileirado.

  5. Pilhas
  A pilha segue a estrutura LIFO (Last In, First Out), ou seja, o último paciente a ser empilhado será o primeiro a ser desempilhado.

##Como Usar
```csharp
Escolha uma opção no menu principal:

1: Trabalhar com Vetores

2: Trabalhar com Matrizes

3: Trabalhar com Lista

4: Trabalhar com Fila

5: Trabalhar com Pilha

6: Algoritmos de Pesquisa (Binária e Sequencial)

0: Sair
```

Dentro de cada estrutura de dados, você poderá realizar as seguintes operações:
  - Inserir paciente (informe o ID e nome).
  - Remover paciente (informe o ID do paciente a ser removido).
  - Buscar paciente por ID.
  - Exibir todos os pacientes da estrutura selecionada.

## Algoritmos de Pesquisa:
Para realizar a pesquisa binária ou sequencial, você pode escolher a opção 6 no menu principal e informar o ID do paciente desejado.

# Exemplo de Uso

=== Atendimento Médico ===
1. Trabalhar com Vetores
2. Trabalhar com Matrizes
3. Trabalhar com Lista
4. Trabalhar com Fila
5. Trabalhar com Pilha
6. Algoritmos de Pesquisa (Binária e Sequencial)
0. Sair
Escolha uma opção: 1

== Vetores ==
1. Inserir paciente
2. Remover paciente
3. Exibir todos
4. Buscar paciente
0. Voltar
Opção: 1
Informe o ID do paciente (número inteiro): 101
Informe o nome do paciente: João Silva
Paciente inserido com sucesso.

Pressione qualquer tecla para continuar...

## Funções Auxiliares

  LerPaciente()
Esta função é utilizada para coletar os dados do paciente (ID e nome) a partir do console, sendo usada em todas as opções que envolvem inserção de pacientes.

  LerNumeroPositivo()
Esta função é usada para garantir que o número inserido seja válido e positivo, sendo usada ao solicitar tamanhos de vetores, matrizes, e para determinar posições em filas e pilhas.

  Pausar()
Após a execução de cada operação, o programa exibe a mensagem "Pressione qualquer tecla para continuar..." para permitir que o usuário veja os resultados antes de retornar ao menu.

##  Requisitos
.NET Core ou .NET Framework para compilar e executar o programa.

Ambiente de desenvolvimento como Visual Studio, Visual Studio Code ou outro IDE de sua preferência.

##Licença
Este projeto está licenciado sob a MIT License, o que significa que você pode usá-lo, modificá-lo e distribuí-lo conforme suas necessidades.

