# Registro de Testes de Software

Para garantir a confiabilidade da plataforma, foram executados os testes de software que serão apresentados em seguida. O registro dos testes de software assegurou as funcionalidades previstas nos Planos de Testes.

## CT 01 - Cadastrar usuários no site (empresas e candidatos)

Para testar a funcionalidade da tela de cadastro do usuário, utilizou-se dois cenários. No primeiro, campos obrigatórios do formulário deixam de ser preenchidos e ao clicar no botão “Cadastrar”, a mensagem “Por favor, preencha o campo” é vista sob todos os inputs presentes na tela.  Essa constatação é ilustrada na Figura 34.

<p align="center">Figura 34 – Teste do cadastro incompleto</p>
<div align="center">
    <img src="img\errocadastro.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

No segundo cenário, todos os campos do formulário são devidamente preenchidos e ao clicar no botão “Cadastrar” há êxito no cadastro.
<br>
<br>
Após a efetivação do cadastro, o usuário é redirecionado para a tela inicial. Caso ele tente logar na aplicação sem preenchimento dos campos, ao clicar em “Cadastrar” a aplicação retorna as seguintes mensagens: “Usuário e/ou senhas inválidos” e "Por favor, preencha o campo" ilustradas na Figura 35 e não é possível acessar a área do usuário.

<p align="center">Figura 35 – Tentativa de login sem preenchimento dos campos</p>
<div align="center">
    <img src="img\errologin.png">
</div>

<p align="center">Fonte: Elaborado pelos autores</p>

Se os campos de e-mail ou senha estiverem incorretos e o usuário tentar se logar clicando no botão “Cadastrar” o resultado será a apresentação da mensagem “Usuário e/ou senhas inválidos” evidenciada na Figura 36.

<p align="center">Figura 36 – Tentativa de login com dados incorretos</p>
<div align="center">
    <img src="img\usuarioinvalido.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Ao inserir corretamente ambos os campos e concluir clicando no botão “Cadastrar” o usuário é direcionado para a área correspondente ao seu perfil cadastrado na aplicação. 
<br><br>
Para o perfil de candidato, no momento em que ele acessa a aba "Meu currículo" no menu da aplicação é possível registrar seus dados pessoais clicando no botão "Salvar". Essa tela é vista na Figura 37.

<p align="center">Figura 37 – Preenchimento de dados pessoais</p>
<div align="center">
    <img src="img\dadospessoais.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Em seguida, também pela navegação no menu, encontra-se a aba "Formação acadêmica" onde resgistra-se os cursos realizados pelo usuário ao clicar no botão "Salvar". Situação ilustrada na Figura 38.

<p align="center">Figura 38 – Preenchiumento de formação acadêmica</p>
<div align="center">
    <img src="img\formacaoacademica.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Completando os dados cadastrais, a Figura 39 registra a inserção da experiência profissional do candidato.

<p align="center">Figura 39 – Preenchimento de experiência profissional</p>
<div align="center">
    <img src="img\experienciaprofissional.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Caso o perfil seja de recrutador, a Figura 40 registra a inserção das informações sobre a empresa

<p align="center">Figura 40 – Preenchimento de dados da empresa</p>
<div align="center">
    <img src="img\CadastroDadosEmpresa.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

## CT 02 - Publicação de vagas de emprego (empresas)

Para verificar a aplicabilidade da opção de postagem de vagas na plataforma, o usuário acessa "Vagas" no menu e "Criar nova vaga" respectivamente. A ilustração é vista na Figura 41.

<p align="center">Figura 41 – Página index das vagas</p>
<div align="center">
    <img src="img\IndexVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Conforme a Figura 42, o usuário é direcionado para a tela onde os campos de "Cargo", "Descrição", "Quantidade de vagas" e "Encerramento da vaga" devem ser preenchidos obrigatoriamente. Caso esses requisitos não sejam atendidos e o botão "Salvar" seja clicado, mensagens "Por favor, preencha o campo" aparecem sob os campos.

<p align="center">Figura 42 – Teste criação de vagas incompleto </p>
<div align="center">
    <img src="img\ErrorCreateVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Na Figura 43, exemplifica-se o preenchimento dos campos para inserção da posição de trabalho a ser divulgada.

<p align="center">Figura 43 – Teste criação de vagas completo </p>
<div align="center">
    <img src="img\CreateVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Nesse cenário, quando o usuário clica no Botão "Salvar" ele é direcionado para a tela "Vagas" onde a vaga salva e é possível visualizá-la no card. A constatação é vista na Figura 44.

<p align="center">Figura 44 – Teste criação de vagas completo </p>
<div align="center">
    <img src="img\IndexVagasAfterCreate.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

## CT 03 - Edição das vagas de emprego (empresas)

É possivel realizar a edição de uma vaga já postada. Para isso o usuário clica em "Mais detalhes" no card da vaga que deseja fazer a alteração. O usuário visualiza 3 opções que o levam a ações posteriores. São elas: "Excluir", "Editar" e "Voltar". Deve-se clicar em "Editar" para prosseguir. Essa opção pode ser visualizada na Figura 45

<p align="center">Figura 45 – Detalhes da vaga </p>
<div align="center">
    <img src="img\DetailsVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Em seguida visualiza-se a tela (Figura 46) onde o usuário realiza as modificações que deseja e clica no botão "Salvar" posteriormente.

<p align="center">Figura 46 – Edição da vaga </p>
<div align="center">
    <img src="img\UpdateVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

O êxito é comprovado imediatamente quando o usuário é direcionado para a tela "Vagas" e a vaga alterada consta no card com a devidas modificações. A Figura 47 faz esse registro.

<p align="center">Figura 47 – Resultado da edição da vaga </p>
<div align="center">
    <img src="img\UpdateVagas2.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

## CT 04 - Excluir vagas de emprego (empresas)

Para verificar a funcionalidade da exclusão de vagas, o usuário acessa "Vagas" e clica em "Mais detalhes" no card da vaga. Utilizou-se o exemplo da vaga de QA nesse teste. A tela com detalhes da vaga é exibida e o usuário clica no botão "Excluir" como apresentado na Figura 48.

<p align="center">Figura 48 – Detalhes da vaga </p>
<div align="center">
    <img src="img\DetailsVagasAfterUpdate.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

Ao clicar em "Excluir" o usuário é direcionado para a tela de "Vagas" e constata que a ação foi validada quando a devida vaga  de QA não é mais vista na Figura 49.

<p align="center">Figura 49 – Index vaags após exclusão </p>
<div align="center">
    <img src="img\IndexVagasAfterDelete.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>


## CT 05 - Publicação de vagas de emprego (candidatos)

<p align="center">Figura 50 – Teste pesquisa de vagas </p>
<div align="center">
    <img src="img\PesquisaVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 51 – Resultado pesquisa </p>
<div align="center">
    <img src="img\PesquisaResultado.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>





