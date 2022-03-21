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
| Paulo Mendes       | Centralizar informações dos profissionais            | Agilizar o recrutamento                                          |
| Carla Santos       | Saber com mais facilidade os requisitos de uma vaga  | Evitar frustrações e entender se a vaga combina com o meu perfil |
| Paulo Mendes       | Filtrar perfis de profissionais                      | Encontrar profissionais mais compatíveis com a vaga              |
| Fernando Silva     | Entrar em contato com o profissional através do site | Facilitar o contato com o profissional                           |
| Fernando Silva     | Ser notificado sobre o surgimento de vagas           | Conseguir um emprego na área que escolheu                        |
| Carla Santos       | Filtrar empresas por área de atuação                 | Visualizar empresas que são da área de formação do profissional  |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais, que descrevem os comportamentos do sistema, as possibilidades de interações dos usuários, além das particularidades para o bom funcionamento da aplicação, bem como os requisitos não funcionais, que descrevem os aspectos que o sistema deverá apresentar em termos de desempenho, usabilidade, segurança, confiabilidade, entre outros.

### Requisitos Funcionais

|ID    |                                     Descrição do Requisito                                               | Prioridade |
|------|----------------------------------------------------------------------------------------------------------|------------|
|RF-01 | O sistema deve permitir o cadastro de empresas recrutadoras                                              | ALTA       | 
|RF-02 | O sistema deve permitir o cadastro de pessoas candidatas a posições de trabalho                          | ALTA       |
|RF-03 | O sistema deve permitir a publicação de posições de trabalho                                             | ALTA       |
|RF-04 | O sistema deve permitir a pesquisa por vagas de emprego                                                  | ALTA       |
|RF-05 | O sistema deve permitir a pesquisa por empresas recrutadoras                                             | MÉDIA      |
|RF-06 | O sistema deve permitir a pesquisa por pessoas candidatas                                                | MÉDIA      |
|RF-07 | O sistema deve possuir filtro de busca para critérios conforme demanda                                   | ALTA       |
|RF-08 | O sistema deve permitir salvar vagas de trabalho                                                         | BAIXA      |
|RF-09 | O sistema deve permitir a visualização de vagas por ordem cronológica de cadastro                        | BAIXA      |
|RF-10 | O sistema deve permitir exportar currículos em formato PDF                                               | MÉDIA      | 
|RF-11 | O sistema deve permitir o cadastro de email para recebimento de vagas de trabalho                        | ALTA       |
|RF-12 | O sistema deve permitir o cadastro de email para recebimento de pessoas candidatas                       | ALTA       |
|RF-13 | O sistema deve permitir que os usuários avaliem sua experiência                                          | MÉDIA      |
|RF-14 | O sistema deve apresentar as vagas de trabalho separadas por categorias                                  | MÉDIA      |
|RF-15 | O sistema deve conter uma página com as principais perguntas frequentes (FAQ - Frequent Asked Questions) | MÉDIA      |
|RF-16 | O sistema deve conter uma página com espaço para envio de dúvidas, sugestões, elogios e/ou reclamações   | ALTA       |

### Requisitos não Funcionais

|ID     |                                                Descrição do Requisito                                                                            |Prioridade|
|-------|--------------------------------------------------------------------------------------------------------------------------------------------------|----------|
|RNF-01 | O site deve ser publicado em um ambiente acessível publicamente na Internet (GitHub Pages, Heroku)                                               | ALTA     | 
|RNF-02 | O website se adaptará ao formato de tela do dispositivo utilizado, sem que ocorram distorções                                                    |  ALTA    |
|RNF-03 | O website deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Internet Explorer, Microsoft Edge, Safari)       |  ALTA    |
|RNF-04 | O sistema estará disponível 100% do tempo                                                                                                        |  ALTA    |
|RNF-05 | O sistema disponibilizará às funcionalidades ao usuário de maneira simples e intuitiva                                                           |  ALTA    |
|RNF-06 | O sistema terá tempo máximo de resposta e, quando o tempo for excedido, informará ao usuário que a operação está demorando mais do que o esperado|  MÉDIA   |
|RNF-07 | Apenas empresas que tenham sido autenticadas por um componente de controle de acesso e autenticação poderão visualizar informações dos candidatos|  MÉDIA   |
|RNF-08 | Deve ser feita cópias de todos os dados do sistema a cada 24 horas                                                                               |  ALTA    |
|RNF-09 | O sistema deve limitar o tempo de acesso ao sistema a fim de reduzir qualquer tipo de ameaça                                                     |  BAIXA   |
|RNF-10 | O sistema deverá se comunicar com o banco SQL Server                                                                                             |  ALTA    |
|RNF-11 | O sistema deve ser modularizado                                                                                                                  |  ALTA    |


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID   | Restrição                                                                                                                   |
|-----|-----------------------------------------------------------------------------------------------------------------------------|
|RE-01| MySQL será o banco de dados a ser utilizado                                                                                 |
|RE-02| O código do projeto deverá usar linguagem de programação **                                                                 |
|RE-03| O projeto deverá estar em conformidade com os parâmetros instituídos pelas diretrizes de trabalhos acadêmicos da PUC Minas  |
|RE-04| O desenvolvimento do projeto não poderá exceder o prazo final em 26/06/22                                                   |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
