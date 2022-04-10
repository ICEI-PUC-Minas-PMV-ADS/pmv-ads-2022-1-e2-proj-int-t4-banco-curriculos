
# Metodologia

## Relação de Ambientes de Trabalho

O quadro 8 mostra os artefatos do projeto, onde são desenvolvidos, e a relação dos ambientes com sua plataforma, respectivamente. Em seguida serão explicados individualmente os ambientes de repositório de código fonte e de gestão do projeto.

<p align = "center">Quadro 8 - Artefatos do Projeto</p>
<div align = "center">

Ambiente|Plataforma|Link de Acesso
|:--------|:----------:|:--------------:|
|Repositório de código fonte|GitHub|  [GitHub](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos)|
|Projeto de Interface e  Wireframes|Figma| [Figma](https://www.figma.com/proto/gRxyF2Zazn1WhjnqMYSvl0/Untitled?node-id=1%3A45&scaling=scale-down&page-id=0%3A1&starting-point-node-id=1%3A45)|
|Gerenciamento do Projeto|Trello| [Trello](https://trello.com/b/nQq4FJDP/gerenciamento-banco-de-curr%C3%ADculos)|

</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

## Controle de Versão

Para a organização, o armazenamento e o histórico de alterações do projeto, será utilizado o fluxo de trabalho Gitflow ligado ao Git, sistema de controle de versões. Devido ao grande fluxo de commits realizados no repositório do projeto, o Gitflow tornou-se um modelo mais adequado para se aderir, pois otimizará tempo com a organização do elevado número de alterações.

**Ciclos de desenvolvimento com branchs**

Nesse fluxo, são criadas duas branchs principais: a `master` e a `develop`, além de branchs secundárias, podendo ser do tipo `feature`, `hotfix` e `release`.

- Branchs principais:

 -`master` é a branch mãe, ou seja, é o código final do projeto.
 
 -`develop` é a branch onde são armazenados todos os registros estáveis, sendo uma espécie de cópia da `master` mesclada com o código desenvolvido a partir das branchs secundárias. 

- Branchs secundárias:

-`feature` é a branch usada para criar novos registros. Pode ser mergeada à `develop`.

-criada a partir da `master`, `hotfix` é a branch utilizada para alterações emergenciais e pontuais do projeto. Pode ser mergeada com a `develop` e a `master`.
 
-`release` é a branch de lançamento, ou seja, é unido todo o código pronto que será mergeado à `master`.



## Gerenciamento de Projeto

Para manter de forma organizada o processo de desenvolvimento do sistema, a equipe optou por utilizar a metodologia ágil Kanban, que é um sistema de gestão de trabalho que busca conduzir as tarefas por um fluxo pré-definido. Além de indicar as tarefas, com o Kanban também é possível acompanhar o andamento do projeto, tornando-o um método que permite maior produtividade do workflow.
<br> A equipe possui um quadro na ferramenta Trello, onde se faz a organização e a distribuição das tarefas de cada etapa. O quadro possui listas e as mesmas seguem os padrões do método Kanban. Segue abaixo a estrutura do Trello com suas respectivas listas:

- `Backlog:` Nesta lista são adicionadas todas as tarefas da etapa que foram identificadas, mas não iniciadas, podendo ou não já estarem alocadas há alguma pessoa.
- `Em desenvolvimento:` São adicionadas nesta lista as tarefas que já foram alocadas há algum membro do grupo e que o mesmo já esteja atuando sobre ela.
- `Bloqueio:` Se encontram nessa lista as tarefas em que surgiram algum impedimento durante seu andamento ou tarefas em que foram identificados pontos de melhoria.
- `Concluído:` Nessa lista são colocadas as tarefas que passaram por todo o processo de desenvolvimento e não necessitam de melhorias, ou seja, tarefas prontas para serem entregues.

<p align = "center">Figura 1 - Quadro Kanban no Trello</p> 

![Quadro Trello](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t4-banco-curriculos/blob/main/docs/img/Trello.png)

<p align = "center">Fonte: Elaborado pelos autores</p>

### Ferramentas

As ferramentas empregadas no projeto são:

- **Editor de código:** VS Code
- **Ferramentas de comunicação:** Microsoft Teams e WhatsApp
- **Ferramenta de desenho de tela:** Figma
- **Ferramentas de criação de diagramas:** Astah e paradigm

