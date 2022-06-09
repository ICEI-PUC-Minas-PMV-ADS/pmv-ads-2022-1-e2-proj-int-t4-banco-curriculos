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

## CT 02 - Publicação de vagas de emprego (empresas)

<p align="center">Figura 40 – Página index das vagas</p>
<div align="center">
    <img src="img\IndexVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 41 – Teste criação de vagas incompleto </p>
<div align="center">
    <img src="img\ErrorCreateVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 42 – Teste criação de vagas completo </p>
<div align="center">
    <img src="img\CreateVagas.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 43 – Teste criação de vagas completo </p>
<div align="center">
    <img src="img\IndexVagasAfterCreate.png">
</div>
<p align="center">Fonte: Elaborado pelos autores</p>





