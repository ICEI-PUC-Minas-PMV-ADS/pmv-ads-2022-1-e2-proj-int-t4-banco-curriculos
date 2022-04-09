# Plano de Testes de Software

|CT 01 | Cadastrar usuarios no site (empresas e candidatos)|
|rf 01 | O sistema deve permitir o cadastro de empresas recrutadoras
|rf 02 | O sistema deve permitir o cadastro de pessoas candidatas a posições de trabalho
|Passos	| 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao "Registrar-se" 5) Completar o fomrulario de informações.|
|Critérios de Êxito | As informaçoes dos usuarios devem ser salvas no banco de dados - Os dados salvos devem ser passiveis de visualização antes de serem salvos.|
|Entradas|
|Objetivo do teste | Saber se o usuario consegue inserir e salvar suas informaçoes no banco.|




CT-02 - Publicação e pesquisa de vagas de emprego
rf 03 - O sistema deve permitir a publicação de posições de trabalho
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao Vagas 5) clicar no botao "registrar vaga" 
Critérios de Êxito - Conseguir salvar e compartilhar o link de uma vaga registrada pela empresa.
Entradas
Objetivo do teste - Saber se a pessoa que esta ofertando a vaga vai cosneguir registrar ela no banco.




CT 03 - Pesquisar vagas de emprego
rf 04 - O sistema deve permitir a pesquisa por vagas de emprego
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao Vagas 5) clicar no botao "pesquisar vaga" 
Critérios de Êxito - Ter resultado de vagas apos a pesquisa.
Entradas
Objetivo do teste - Saber se as vagas foram salvas no banco.





CT 04 - Candidatura para vagas
rf 06 - O sistema deve permitir o usuário a candidatura para as vagas de trabalho
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao Vagas 5) clicar no botao "pesquisar vaga" 6) Selecionar a vaga desejada 7) clicar em "candidatar-se" 
Critérios de Êxito - A candidatura ser salva no banco com as informaçoes do candidato e apresentar as informações a empresa que registrou a vaga.
Entradas
Objetivo do teste - Saber se conseguimos pegar as infos do usuario e anexar como candidatura na vaga desejada.




CT 05 - Filtragem nas buscas
rf 08 - O sistema deve possuir filtro de busca para critérios conforme demanda
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao Vagas 5) clicar no botao "pesquisar vaga" 6) Selecionar os filtros desejados para a vaga 7) clicar em "pesquisar"
Critérios de Êxito - Aparecer no resultado de pesquisa apenas vagas que condizem com os objeitos filtrados anteriormente
Entradas
Objetivo do teste - Saber se os filtros estão realmente fazendo seu dever e assim facilitar as buscas.

CT 06 - Recebimento de informaçoes de vagas
rf 12 - O sistema deve permitir o cadastro de email para recebimento de vagas de trabalho
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao "Registrar-se" 5) Completar o fomrulario de informações 6) Clicar no botao "receber informaçoes sobre vagas relacionadas ao meu curriculo"
Critérios de Êxito - Chegar aviso no email do candidato com vagas que correspondem as informaçoes dos curriculo que ele registrou.
Entradas
Objetivo do teste - Saber se o usuario vai ficar vinculado a uma tipagem de filtros, e sempre que correspondida a tipagem, se ele vai receber o email de uma nova vaga.




CT 07 - Recebimento de infirmacoes de candidatos
rf 13 - O sistema deve permitir o cadastro de email para recebimento de pessoas candidatas
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Clicar no botao "Registrar-se" 5) Completar o fomrulario de informações 6) Clicar no botao "receber informaçoes sobre candidatos registrados"
Critérios de Êxito - Chegar aviso no email da empresa com candidatos que se registraramna vaga.
Entradas
Objetivo do teste - Saber se a pessoa que registrou a vaga vai receber as notificações sobre quem esta se candidatando.




CT 08 - Registro de duvidas e ajuda para candidatos e empresas.
rf 17 - O sistema deve conter uma página com espaço para envio de dúvidas, sugestões, elogios e/ou reclamações
Passos 1) Acessar o navegador 2) Informar o endereço do site 3) Visualizar a página principal 4) Rolar ate o rodapé da pagina 5) Clicas em "ajuda"
Critérios de Êxito - Chegar email para os mantenedores do site com as solicitaçoes de quem entrou em contato.
Entradas
Objetivo do teste - Saber se conseguimos registrar as duvidas e o quem precisa de ajuda, para entrar em contato e resolver as pendencias.
