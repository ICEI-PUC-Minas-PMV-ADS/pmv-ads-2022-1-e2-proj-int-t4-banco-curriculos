# Plano de Testes de Software

<div align = "center">
  
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste |CT 01 - Cadastrar usuários no site (empresas e candidatos) | 
|--------------------|------------------------------------|
| RF 01 | O sistema deve permitir o cadastro de empresas recrutadoras | 
| RF 02 | O sistema deve permitir o cadastro de pessoas candidatas a posições de trabalho | 
| Passos	| 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão "Registrar-se" 5) Completar o formulário de informações. |
| Critérios de Êxito | As informações dos usuários devem ser salvas no banco de dados - Os dados salvos devem ser passíveis de visualização antes de serem salvos. | 
| Entradas | Usuário, senha e uma das caixas: candidato ou empresa|
| Objetivo do teste | Constatar se o usuário consegue inserir e salvar suas informações no banco. | 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|Caso de Teste | CT-02 - Publicação e pesquisa de vagas de emprego |
|--------------------|------------------------------------|
| RF 03 | O sistema deve permitir a publicação de posições de trabalho|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botao "registrar vaga" |
|Critérios de Êxito | Conseguir salvar e compartilhar o link de uma vaga registrada pela empresa.|
|Entradas| Usuário, senha e característica da vaga|
|Objetivo do teste | Constatar se a pessoa que está ofertando a vaga vai conseguir registrá-la no banco.                                         |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 03 - Pesquisar vagas de emprego |
|--------------------|------------------------------------|
| RF 04 | O sistema deve permitir a pesquisa por vagas de emprego|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botao "pesquisar vaga".|
|Critérios de Êxito | Ter resultado de vagas após a pesquisa.|
|Entradas| Usuário, senha, filtro e(ou) palavra-chave|
|Objetivo do teste | Constatar se as vagas foram salvas no banco.|

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 04 - Candidatura para vagas |
|--------------------|------------------------------------|
| RF 06 | O sistema deve permitir ao usuário a candidatura para as vagas de trabalho |
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botão "pesquisar vaga" 6) Selecionar a vaga desejada 7) Clicar em "Candidatar-se" |
|Critérios de Êxito | A candidatura deve ser salva no banco com as informações do candidato e apresentar as informações à empresa que registrou a vaga.|
|Entradas |  Usuário, senha, filtros e(ou) palavra-chave|
|Objetivo do teste | Constatar se as informações do usuário foram incluídas como candidatura na vaga desejada.|

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 05 - Filtragem nas buscas |
|--------------------|------------------------------------|
| RF 08 | O sistema deve possuir filtro de busca para critérios conforme demanda| 
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botão "pesquisar vaga" 6) Selecionar os filtros desejados para a vaga 7) Clicar em "Pesquisar"|
|Critérios de Êxito | Apresentar no resultado de pesquisa apenas vagas que condizem com os critérios filtrados anteriormente|
|Entradas| Filtros e(ou) palavra-chave|
|Objetivo do teste | Constatar se os filtros estão coletando somente as informações desejadas|
  
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 06 - Recebimento de informaçoes de vagas |
|--------------------|------------------------------------|
| RF 12 | O sistema deve permitir o cadastro de email para recebimento de vagas de trabalho|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão "Registrar-se" 5) Completar o formulário de informações 6) Clicar no botão "receber informações sobre vagas relacionadas ao meu currículo"|
|Critérios de Êxito | Chegar no email do candidato vagas que correspondem as informações do curriculo que ele registrou|
|Entradas| Usuário, senha e email|
|Objetivo do teste | Constatar se o usuário ficará vinculado a uma tipagem de filtros, e sempre que correspondida a tipagem, se ele vai receber o email de uma nova vaga|

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 07 - Recebimento de informações de candidatos|
|--------------------|------------------------------------|
| RF 13 | O sistema deve permitir o cadastro de email para recebimento de pessoas candidatas|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão "Registrar-se" 5) Completar o formulário de informações 6) Clicar no botão "receber informações sobre candidatos registrados".|
|Critérios de Êxito | Chegar aviso no email da empresa com candidatos que se registraramna vaga|
|Entradas| Usuário, senha e email|
|Objetivo do teste | Constatar se a pessoa que registrou a vaga vai receber as notificações sobre quem está se candidatando|

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 08 - Registro de dúvidas e ajuda para candidatos e empresas|
|--------------------|------------------------------------|
| RF 17 | O sistema deve conter uma página com espaço para envio de dúvidas, sugestões, elogios e/ou reclamações|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Rolar até o rodapé da página 5) Clicar em "Ajuda"|
|Critérios de Êxito | Chegar email para os mantenedores do site com as mansagens de quem entrou em contato|
|Entradas| Usuário e senha|
|Objetivo do teste | Constatar se são registradas as dúvidas de quem precisa de ajuda para entrar em contato e resolver as pendências|
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
