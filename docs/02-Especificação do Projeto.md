# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

A seguir são retratadas as personas identificadas, resultantes da etapa de pesquisa e mapeamento do problema: 

<p align = "center">Quadro 1 - Persona Raquel Couto</p>

|<img src="img\PauloMendes.jpg" width="380" title="persona1">| PAULO MENDES |
|---------------------------------------------------------|--------------|
|**Idade**        | 27 anos                                              | 
|**Cargo**        | Tech Recruiter                                       |
|**Interesses**   | Tecnologia, livros e estudos                         |
|**Frustrações**  | Profissionais que não dão resposta, falta de uma plataforma de recrutamento mais completa, candidatos que não possuem o perfil da vaga                    |
|**Redes sociais**| LinkedIn, Instagram e Whatsapp                       |

<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

<p align = "center">Quadro 2 - Persona Carla Santos</p>

|<img src="img\CarlaSantos.jpg" width="380" title="persona1">| CARLA SANTOS |
|---------------------------------------------------------|--------------|
|**Idade**        | 23 anos                                              | 
|**Cargo**        | Desenvolvedora                                       |
|**Interesses**   | Tecnologia, jogos e yoga                             |
|**Frustrações**  | Dificuldade em conseguir emprego                     |
|**Redes sociais**| Instagram,  Whatsapp e Twitter                       |

<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

<p align = "center">Quadro 3 - Persona Fernando Silva</p>

|<img src="img\FernandoSilva.jpg" width="380" title="persona1">| FERNANDO SILVA |
|---------------------------------------------------------|--------------|
|**Idade**        | 21 anos                                              | 
|**Cargo**        | Publicitário                                         |
|**Interesses**   | Marketing, publicidade e propaganda                  |
|**Frustrações**  | Recém formado porém encontra dificuldades em conseguir primeiro emprego na sua área|
|**Redes sociais**| Instagram,  Whatsapp e Twitter                       |

<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`                   |PARA ... `MOTIVO/VALOR`                                           |
|--------------------|------------------------------------------------------|------------------------------------------------------------------|
|Paulo Mendes        | Centralizar informações dos profissionais            | Agilizar o recrutamento                                          |
|Carla Santos        | Saber com mais facilidade os requisitos de uma vaga  | Evitar frustrações e entender se a vaga combina com o meu perfil |
| Paulo Mendes       | Filtrar perfis de profissionais                      | Encontrar profissionais mais compatíveis com a vaga              |
| Fernando Silva     | Entrar em contato com o profissional através do site | Facilitar o contato com o profissional                           |
| Fernando Silva     | Ser notificado sobre o surgimento de vagas           | Conseguir um emprego na área que escolheu                        |
| Carla Santos       | Filtrar empresas por área de atuação                 | Visualizar empresas que são da área de formação do profissional  |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
