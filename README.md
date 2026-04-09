# 🎸 C# Mastery: Screen Sound, Desafios e Game Logic

Este repositório consolida o desenvolvimento de aplicações interativas e lógica de programação utilizando o ecossistema .NET, explorando desde fundamentos de funções até a criação de sistemas de gestão e jogos.

---

## 🔍 O que foi explorado?

O foco principal foi a construção de interfaces de linha de comando (CLI) dinâmicas, focadas em usabilidade e fluxo de controle.

### 1. Screen Sound (Sistema de Gestão Musical)
Aplicação principal que utiliza uma interface estruturada:
* **Menu Dinâmico:** Implementação de um sistema de navegação baseado em entradas numéricas e `switch case`.
* **Identidade Visual:** Uso de ASCII Art para personalização do terminal e melhoria da experiência do utilizador.
* **Lógica de Gestão:** Preparação do código para operações de registo, listagem e avaliação de bandas.

### 2. Jogo de Adivinhação
Um laboratório focado em lógica de jogos e feedback em tempo real:
* **Classe Random:** Geração de números aleatórios entre 0 e 100.
* **Game Loop:** Uso do laço `for` para limitar as tentativas, com condicionais que informam se o número secreto é maior ou menor que o palpite atual.
* **Controle de Fluxo:** Utilização de `break` para encerrar o jogo assim que o utilizador acerta o número.

### 3. Desafios de Fundamentos
Práticas essenciais para manipulação de dados:
* **Cálculo de Média:** Função estática para processar notas, utilizando `int.Parse` para converter entradas do teclado.
* **Iteração de Coleções:** Uso de `foreach` para percorrer e exibir listas (arrays) de linguagens de programação.

---

## 💻 Estrutura Técnica

| Projeto | Arquivo Principal | Conceitos Chave |
| :--- | :--- | :--- |
| **Screen Sound** | `Program.cs` | Dicionários, Switch, Console Styling |
| **Jogo** | `Program.cs` | Random, For Loop, Feedback Lógico |
| **Desafios** | `Program.cs` | Métodos Estáticos, Foreach, Casting |

---

## 🛠️ Tecnologias
* **Linguagem:** C#
* **Framework:** .NET (Versões 7.0 e 10.0)
* **Ambiente:** VS Code

---

## 🚀 Como Executar

Cada projeto contém o seu próprio ficheiro `.csproj`. Para correr as aplicações:

1. Aceda à pasta do projeto pretendido via terminal.
2. Execute o comando:
   ```bash
   dotnet run
---
**Desenvolvido por Lucas Nery Miranda**
*Estudante de Ciência da Computação - UNA*
