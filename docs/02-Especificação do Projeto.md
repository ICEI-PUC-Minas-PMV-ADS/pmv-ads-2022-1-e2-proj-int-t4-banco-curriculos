# Especificações do Projeto

## Personas

A seguir são retratadas as personas identificadas, resultantes da etapa de pesquisa e mapeamento do problema: 

<p align = "center">Quadro 1 - Persona Paulo Mendes</p>


| PAULO MENDES  |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img\PauloMendes.jpg" width="100" title="persona1">|**Idade:** 27 anos <br> **Ocupação:** Tech Recruiter | **Redes Sociais:**  LinkedIn, Instagram e Whatsapp <br> **Interesses:** Tecnologia, livros e estudos |
|**Motivações:**  Paulo gosta de sua profissão e espera contratar pessoas que sejam adequadas para cada tipo de vaga, por isso, o mesmo está sempre em busca de plataformas de recrutamento que sejam simples de utilizar e mais completas. |**Frustrações:** Por trabalhar com o recrutamento de pessoas, Paulo se sente desmotivado com plataformas que dificultam seu contato com os profissionais e que não possuem um bom sistema de seleção de candidatos para as vagas disponíveis.|**Hobbies, História:** Paulo sempre teve interesse pela tecnologia e facilidade em lidar e se comunicar com as pessoas, e foi com base nesses fatores que ele decidiu ser tech recruiter.| 


<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

<p align = "center">Quadro 2 - Persona Carla Santos</p>

| CARLA SANTOS  |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img\CarlaSantos.jpg" width="100" title="persona1">|**Idade:** 23 anos <br> **Ocupação:** Desenvolvedora | **Redes Sociais:** Instagram, Whatsapp e Twitter <br> **Interesses:** Tecnologia, jogos e yoga|
|**Motivações:** Carla adora a área que escolheu para sua formação pois busca ajudar as pessoas através da criação de softwares, por isso, não vê a hora de conseguir um emprego. |**Frustrações:**  Carla se sente frustrada por receber oportunidades de vagas que não são tão compatíveis com sua formação, tendo assim que realizar várias buscas em seu tempo livre.|**Hobbies, História:** Desde pequena Carla sempre gostou muito de jogos eletrônicos e tudo relacionado à tecnologia, por isso resolveu se tornar desenvolvedora, mas ela também gosta de passar um tempo em contato com a natureza e fazer exercícios| 

<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

<p align = "center">Quadro 3 - Persona Fernando Silva</p>

| FERNANDO SILVA |                                    |                |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img\FernandoSilva.jpg" width="100" title="persona1">|**Idade:** 21 anos <br> **Ocupação:**  Estudante de Publicidade| **Redes Sociais:** Instagram, Whatsapp e Twitter <br> **Interesses:** Marketing, publicidade e propaganda |
|**Motivações:** Prestes a concluir sua faculdade, Fernando gostaria de encontrar um estágio para que ele possa ganhar experiência na área em que decidiu cursar. |**Frustrações:** Por ainda estar na universidade, Fernando tem dificuldade em encontrar vagas para iniciantes ou de estágio em sua área pois são poucos divulgadas, dificultando sua inserção no mercado de trabalho. |**Hobbies, História:** Fernando é um cara animado e bastante sociável, além disso ele também é muito criativo.| 

<p align = "center">Fonte: Elaborado pelos autores</p>

<br>

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

<p align = "center">Quadro 4 - Histórias de usuários</p>

<div align = "center">

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`                   |PARA ... `MOTIVO/VALOR`                                           |
|--------------------|------------------------------------------------------|------------------------------------------------------------------|
| Paulo Mendes       | Centralizar informações dos profissionais            | Agilizar o recrutamento                                          |
| Carla Santos       | Saber com mais facilidade os requisitos de uma vaga  | Evitar frustrações e entender se a vaga combina com o meu perfil |
| Paulo Mendes       | Filtrar perfis de profissionais                      | Encontrar profissionais mais compatíveis com a vaga              |
| Fernando Silva     | Entrar em contato com o profissional através do site | Facilitar o contato com o profissional                           |
| Fernando Silva     | Ser notificado sobre o surgimento de vagas           | Conseguir um emprego na área que escolheu                        |
| Carla Santos       | Filtrar empresas por área de atuação                 | Visualizar empresas que são da área de formação do profissional  |

</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

## Requisitos

Para a compreensão das necessidades a serem solucionadas por meio do software, foi realizado o levantamento de requisitos onde estão estabelecidos as funcionalidades e os recursos da aplicação.

### Requisitos Funcionais

O Quadro 5 apresenta as funcionalidades que a plataforma se propõe a oferecer.

<p align = "center">Quadro 5 - Requisitos funcionais</p>

<div align = "center">

|ID    |                                     Descrição do Requisito                                               | Prioridade |
|------|----------------------------------------------------------------------------------------------------------|------------|
|RF-01 | O sistema deve permitir o cadastro de empresas recrutadoras                                              | ALTA       | 
|RF-02 | O sistema deve permitir o cadastro de pessoas candidatas a posições de trabalho                          | ALTA       |
|RF-03 | O sistema deve permitir a publicação de posições de trabalho                                             | ALTA       |
|RF-04 | O sistema deve permitir a pesquisa por vagas de emprego                                                  | ALTA       |
|RF-06 | O sistema deve permitir o usuário a candidatura para as vagas de trabalho | ALTA |
|RF-07 | O sistema deve permitir exportar currículos em formato PDF                                               | MÉDIA      | 
|RF-08 | O sistema deve permitir o cadastro de email para recebimento de pessoas candidatas                       | ALTA       |
|RF-09 | O sistema deve permitir a edição de posições de trabalho                                                 | MÉDIA      |
|RF-10 | O sistema deve permitir a exclusão de posições de trabalho                                               | MÉDIA      |
|RF-11 | O sistema deve permitir o cadastro do currículo do candidato                                             | MÉDIA      |
|RF-12 | O sistema deve permitir a edição das informações no currículo do candidato                               | MÉDIA      |
|RF-13 | O sistema deve permitir a exclusão das informações no currículo do candidato                             | MÉDIA      |

</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Requisitos não Funcionais

Os requisitos não funcionais são apresentados no Quadro 6.

<p align = "center">Quadro 6 - Requisitos não funcionais</p>

<div align = "center">

|ID     |                                                Descrição do Requisito                                                                            |Prioridade|
|-------|--------------------------------------------------------------------------------------------------------------------------------------------------|----------|
|RNF-01 | O site deve ser publicado em um ambiente acessível publicamente na Internet (GitHub Pages, Heroku)                                               | ALTA     | 
|RNF-02 | O website se adaptará ao formato de tela do dispositivo utilizado, sem que ocorram distorções                                                    |  ALTA    |
|RNF-03 | O website deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Internet Explorer, Microsoft Edge, Safari)       |  ALTA    |
|RNF-04 | O sistema estará disponível 100% do tempo                                                                                                        |  ALTA    |
|RNF-05 | O sistema disponibilizará às funcionalidades ao usuário de maneira simples e intuitiva                                                           |  ALTA    |
|RNF-06 | Apenas empresas que tenham sido autenticadas por um componente de controle de acesso e autenticação poderão visualizar informações dos candidatos|  MÉDIA   |
|RNF-07 | O sistema deve limitar o tempo de acesso ao sistema a fim de reduzir qualquer tipo de ameaça                                                     |  BAIXA   |
|RNF-08 | O sistema deverá se comunicar com o banco SQL Server                                                                                             |  ALTA    |
|RNF-09 | O sistema deve ser modularizado                                                                                                                  |  ALTA    |

</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

## Restrições

As questões vistas como litações à construção do projeto estão evidenciados no Quadro 7.

<p align = "center">Quadro 7 - Restrições</p>

<div align = "center">

|ID   | Restrição                                                                                                                   |
|-----|-----------------------------------------------------------------------------------------------------------------------------|
|RE-01| O projeto deverá ser conduzido com os direcionamentos do professor orientador                                                                                 |
|RE-02| A equipe só poderá se reunir com o professor orientador às segundas-feiras às 20h50                                                                 |
|RE-03| O projeto deverá estar em conformidade com o escopo disponibilizado pela PUC Minas  |
|RE-04| O prazo para entrega final do projeto é 26/06/2022                                                 |

</div>

<p align = "center">Fonte: Elaborado pelos autores</p>
<br>

## Diagrama de Casos de Uso

O Diagrama de Casos de Uso, com a representação das funcionalidades e relacionamentos do sistema, é ferramenta que compõe a fase de levantamento e análise de requisitos da aplicação.
<br><br>
A seguir apresenta-se a documentação narrativa e a representação visual do caso de uso:
<br><br>
Um candidato entra no site e efetua seu login. Caso não possua cadastro prévio, ele o faz com seus dados pessoais e informações de âmbito profissional.
<br><br>
O candidato pesquisa as vagas de emprego de acordo com o seu perfil, seleciona a vaga desejada e registra a sua candidatura.
<br><br>
O recrutador efetua login no site e recebe a notificação do candidato, analisa seu perfil, realiza contato caso o perfil do candidato seja de seu interesse e, assim, inicia a comunicação entre as partes.
<br><br>
O recrutador anuncia suas posições de trabalho no site e pesquisa possíveis candidatos que se enquadrem no perfil desejado. Ele pode exportar o currículo em formato pdf para sua máquina e pode fazer contato com o candidato por meio da plataforma.
<br><br>
Ao preencher a posição de trabalho em sua empresa, o recrutador exclui o anúncio da vaga no site.
<br><br>
O candidato e o recrutador podem avaliar a experiência que tiveram durante o processo e podem enviar dúvidas, sugestões e reclamações para a plataforma.
<br>
<p align = "center">Figura 1 - Diagrama de Casos de Uso</p>

<div align = "center">
<img src="img\usecasediagram.jpg"  width="600" title="persona1">
</div>
<p align = "center">Fonte: Elaborado pelos autores</p>

<br>








