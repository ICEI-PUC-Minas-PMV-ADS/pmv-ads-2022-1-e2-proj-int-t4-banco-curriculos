# Plano de Testes de Software

<div align = "center">
  
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste |CT 01 - Cadastrar usuários no site (empresas e candidatos) | 
|--------------------|------------------------------------|
| RF 01 | O sistema deve permitir o cadastro de empresas recrutadoras | 
| RF 02 | O sistema deve permitir o cadastro de pessoas candidatas a posições de trabalho | 
| Passos	| 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão "Cadastrar" 5) Completar o formulário de informações. |
| Critérios de Êxito | As informações dos usuários devem ser salvas no banco de dados - Os dados salvos devem ser passíveis de visualização antes de serem salvos. | 
| Entradas | Usuário, senha e uma das caixas: candidato ou empresa|
| Objetivo do teste | Constatar se o usuário consegue inserir e salvar suas informações no banco. | 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|Caso de Teste | CT-02 - Publicação de vagas de emprego |
|--------------------|------------------------------------|
| RF 03 | O sistema deve permitir a publicação de posições de trabalho|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botao "Criar nova vaga" |
|Critérios de Êxito | Conseguir salvar uma vaga registrada pela empresa.|
|Entradas| Usuário, senha e característica da vaga|
|Objetivo do teste | Constatar se a pessoa que está ofertando a vaga vai conseguir registrá-la no banco.                                         |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT-03 - Edição das vagas de emprego |
|--------------------|------------------------------------|
| RF 10 | O sistema deve permitir a edição de posições de trabalho|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar em Vagas no menu 5) Clicar no botão "Mais detalhes" 6) Clicar no botão "Editar" |
|Critérios de Êxito | Conseguir editar informações de uma vaga registrada pela empresa|
|Entradas| Usuário, senha e características da vaga|
|Objetivo do teste | Constatar se a pessoa que está ofertando a vaga vai conseguir editar informações da vaga no banco                                         |

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------  
|Caso de Teste | CT-04 - Exclusão das vagas de emprego |
|--------------------|------------------------------------|
| RF 11 | O sistema deve permitir a exclusão de posições de trabalho|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botao "mais detalhes" 6) Clicar no botão "excluir" |
|Critérios de Êxito | Conseguir excluir uma vaga registrada pela empresa|
|Entradas| Usuário, senha |
|Objetivo do teste | Constatar se as informações da vaga foram apagadas do banco.                                         |

----------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
  
|Caso de Teste | CT 05 - Pesquisar vagas de emprego |
|--------------------|------------------------------------|
| RF 04 | O sistema deve permitir a pesquisa por vagas de emprego|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botao "pesquisar vaga".|
|Critérios de Êxito | Ter resultado de vagas após a pesquisa.|
|Entradas| Usuário, senha, palavra-chave|
|Objetivo do teste | Constatar se as vagas foram salvas no banco.|

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 06 - Candidatura para vagas |
|--------------------|------------------------------------|
| RF 06 | O sistema deve permitir ao usuário a candidatura para as vagas de trabalho |
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botão Vagas 5) Clicar no botão "pesquisar vaga" 6) Selecionar a vaga desejada 7) Clicar em "Candidatar-se" |
|Critérios de Êxito | A candidatura deve ser salva no banco com as informações do candidato e apresentar as informações à empresa que registrou a vaga.|
|Entradas |  Usuário, senha, filtros e(ou) palavra-chave|
|Objetivo do teste | Constatar se as informações do usuário foram incluídas como candidatura na vaga desejada.|

---------------------------------------------------------------------------------------------------------------------------------------------------------
|Caso de Teste | CT 07 - Edição de informações no currículo do candidato|
|--------------------|------------------------------------|
| RF 13 | O sistema deve permitir a edição das informações no currículo do candidato|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Realizar o login 4) Visualizar a página principal 5) Clicar em "Visualizar currículo" 6) Clicar no ícone de lápis 7) Alterar as informações 8) Clicar em "Salvar"|
|Critérios de Êxito | Salvar as informações alteradas no currículo|
|Entradas| Usuário, senha e email, dados que serão alterados no currículo|
|Objetivo do teste | Constatar se o candidato conseguirá salvar no banco as alterações feitas em seu currículo|
  
-------------------------------------------------------------------------
|Caso de Teste | CT 08 - Exclusão de informações no currículo do candidato|
|--------------------|------------------------------------|
| RF 14 | O sistema deve permitir a exclusão das informações no currículo do candidato|
|Passos | 1) Acessar o navegador 2) Informar o endereço do site 3) Realizar o login 4) Visualizar a página principal 5) Clicar em "Visualizar currículo" 6) Clicar no ícone de lixeira 7) Clicar em "Excluir"|
|Critérios de Êxito | Excluir as informações no currículo|
|Entradas| Usuário, senha e email|
|Objetivo do teste | Constatar se o candidato conseguirá apagar do banco os dados do seu currículo|

