# Registro de Testes de Software

Para garantir a confiabilidade da plataforma, foram executados os testes de software que serão apresentados em seguida. O registro dos testes de software assegurou as funcionalidades previstas nos Planos de Testes.

## CT 01 - Cadastrar usuários no site (empresas e candidatos)

Para testar a funcionalidade da tela de cadastro do usuário, utilizou-se dois cenários. No primeiro, campos obrigatórios do formulário deixam de ser preenchidos e ao clicar no botão “Cadastrar”, a mensagem “Por favor, preencha o campo” é vista sob todos os inputs presentes na tela.  Essa constatação é ilustrada na Figura 34.

<p align="center">Figura 34 – Teste do cadastro incompleto</p>

![image](https://user-images.githubusercontent.com/26911388/175816948-14f0857a-c4ab-4005-8322-62657ba39ab9.png)
![image](https://user-images.githubusercontent.com/26911388/175816965-d2baf059-0074-4ea0-ab1e-005a54e252a9.png)

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

![image](https://user-images.githubusercontent.com/26911388/175817205-7f52aa7c-e24d-4d0e-bd6a-9b5f74094f60.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Em seguida, também pela navegação no menu, encontra-se a aba "Formação acadêmica" onde resgistra-se os cursos realizados pelo usuário ao clicar no botão "Salvar". Situação ilustrada na Figura 38.

<p align="center">Figura 38 – Preenchimento de formação acadêmica</p>

![image](https://user-images.githubusercontent.com/26911388/175817243-961910ae-d203-4f4d-89cd-843c5d7b0bfd.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Completando os dados cadastrais, a Figura 39 registra a inserção da experiência profissional do candidato.

<p align="center">Figura 39 – Preenchimento de experiência profissional</p>

![image](https://user-images.githubusercontent.com/26911388/175817267-09bc8666-64b9-4af7-8560-5c26e24d469a.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Caso o perfil seja de recrutador, a Figura 40 registra a inserção das informações sobre a empresa

<p align="center">Figura 40 – Preenchimento de dados da empresa</p>

![image](https://user-images.githubusercontent.com/26911388/175817299-1c39c8d9-8525-46f6-940c-a9d1d0959d40.png)

<p align="center">Fonte: Elaborado pelos autores</p>

## CT 02 - Publicação de vagas de emprego (empresas)

Para verificar a aplicabilidade da opção de postagem de vagas na plataforma, o usuário acessa "Vagas" no menu e "Criar nova vaga" respectivamente. A ilustração é vista na Figura 41.

<p align="center">Figura 41 – Página index das vagas</p>

![image](https://user-images.githubusercontent.com/26911388/175817327-9f2881f6-e871-43eb-b52a-97c692337e93.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Conforme a Figura 42, o usuário é direcionado para a tela onde os campos de "Cargo", "Descrição", "Quantidade de vagas" e "Encerramento da vaga" devem ser preenchidos obrigatoriamente. Caso esses requisitos não sejam atendidos e o botão "Salvar" seja clicado, mensagens "Por favor, preencha o campo" aparecem sob os campos.

<p align="center">Figura 42 – Teste criação de vagas incompleto </p>

![image](https://user-images.githubusercontent.com/26911388/175817355-6254fb93-2b8d-43fb-bced-ad4405015e91.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Na Figura 43, exemplifica-se o preenchimento dos campos para inserção da posição de trabalho a ser divulgada.

<p align="center">Figura 43 – Teste criação de vagas completo </p>

![image](https://user-images.githubusercontent.com/26911388/175817476-b05ee5c5-fc2b-4422-9ace-b8bb4c8d2760.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Nesse cenário, quando o usuário clica no Botão "Salvar" ele é direcionado para a tela "Vagas" onde a vaga salva e é possível visualizá-la no card. A constatação é vista na Figura 44.

<p align="center">Figura 44 – Teste criação de vagas completo </p>

![image](https://user-images.githubusercontent.com/26911388/175817497-c2a6760d-acf7-48da-a42d-7579a6d1fed2.png)

<p align="center">Fonte: Elaborado pelos autores</p>

## CT 03 - Edição das vagas de emprego (empresas)

É possivel realizar a edição de uma vaga já postada. Para isso o usuário clica em "Mais detalhes" no card da vaga que deseja fazer a alteração. O usuário visualiza 3 opções que o levam a ações posteriores. São elas: "Excluir", "Editar" e "Voltar". Deve-se clicar em "Editar" para prosseguir. Essa opção pode ser visualizada na Figura 45

<p align="center">Figura 45 – Detalhes da vaga </p>

![image](https://user-images.githubusercontent.com/26911388/175817528-b295845e-6cb9-4cf4-bae5-2e464908d663.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Em seguida visualiza-se a tela (Figura 46) onde o usuário realiza as modificações que deseja e clica no botão "Salvar" posteriormente.

<p align="center">Figura 46 – Edição da vaga </p>

![image](https://user-images.githubusercontent.com/26911388/175817558-e63b1e8a-6ea8-4484-ac06-336060c36d12.png)

<p align="center">Fonte: Elaborado pelos autores</p>

O êxito é comprovado imediatamente quando o usuário é direcionado para a tela "Vagas" e a vaga alterada consta no card com a devidas modificações. A Figura 47 faz esse registro.

<p align="center">Figura 47 – Resultado da edição da vaga </p>

![image](https://user-images.githubusercontent.com/26911388/175817612-b2e3e578-62cb-4ec3-ba16-4c09255ad673.png)

<p align="center">Fonte: Elaborado pelos autores</p>

## CT 04 - Excluir vagas de emprego (empresas)

Para verificar a funcionalidade da exclusão de vagas, o usuário acessa "Vagas" e clica em "Mais detalhes" no card da vaga. Utilizou-se o exemplo da vaga de QA nesse teste. A tela com detalhes da vaga é exibida e o usuário clica no botão "Excluir" como apresentado na Figura 48.

<p align="center">Figura 48 – Detalhes da vaga </p>

![image](https://user-images.githubusercontent.com/26911388/175817649-89dde511-b608-426f-99af-f98fb043dffa.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Ao clicar em "Excluir" o usuário é direcionado para a tela de "Vagas" e constata que a ação foi validada quando a devida vaga  de QA não é mais vista na Figura 49.

<p align="center">Figura 49 – Index vagas após exclusão </p>

![image](https://user-images.githubusercontent.com/26911388/175817657-b74e3d0b-0ac1-42f0-a241-9892397b3337.png)

<p align="center">Fonte: Elaborado pelos autores</p>

## CT 05 - Pesquisar vagas de emprego (candidatos)

Quando o usuário acessa "Buscar Vagas" no menu, uma tela de pesquisa é apresentada e é possível usar o campo de pesquisa para encontrar uma vaga desejada. No caso de teste digitou-se "Desenvolver" e clicou-se no botão "Buscar" (Figura 50).

<p align="center">Figura 50 – Teste pesquisa de vagas </p>

![image](https://user-images.githubusercontent.com/26911388/175817692-d4e1e783-50c5-4c04-aec7-d308764044fa.png)

<p align="center">Fonte: Elaborado pelos autores</p>

A ação é concluída com êxito quando a aplicação retorna o resultado da pesquisa. No exemplo deste teste 2 vagas foram retornadas como resultado da pesquisa (Figura 51).

<p align="center">Figura 51 – Resultado pesquisa </p>

![image](https://user-images.githubusercontent.com/26911388/175817702-c7c51333-eccb-444d-82ec-a11f6739a508.png)

<p align="center">Fonte: Elaborado pelos autores</p>


## CT 06 - Candidatar a uma vaga de emprego (candidatos)

Quando o usuário acessa "Buscar Vagas" no menu, uma tela de pesquisa é apresentada com as vagas de emprego adicionadas mais recentemente e é possível usar o campo de pesquisa para encontrar uma vaga desejada. Para visualizar uma vaga específica, basta clicar em "Mais detalhes".

<p align="center">Figura 52 – Overview das vagas </p>

![image](https://user-images.githubusercontent.com/26911388/175817692-d4e1e783-50c5-4c04-aec7-d308764044fa.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Após escolher uma vaga específica, o candidado é redirecionao a uma página onde poderá ver todos os detalhes da mesma. Para candidatar-se na vaga, basta clicar no botão "Candidatar-se".

<p align="center">Figura 53 – Candidatar para uma vaga </p>

![image](https://user-images.githubusercontent.com/26911388/175817733-98c3e31a-7213-4d97-8bee-45addf774eb7.png)

<p align="center">Fonte: Elaborado pelos autores</p>


## CT 07 - Editar informações do currículo (candidatos)

Quando o usuário acessa "Meu currículo" no menu, é apresentada uma tela com todas informações
pessoais e referentes ao currículo do candidato. Ao lado das informações são apresentados dois ícones, de um lápis e de uma lixeira, e para editar uma informação, basta o usuário clicar no ícone de lápis.

<p align="center">Figura 54 – Teste editar informações do currículo </p>

![image](https://user-images.githubusercontent.com/26911388/175817798-5897d771-9adb-45bf-be0a-d5cd323f9dc3.png)
![image](https://user-images.githubusercontent.com/26911388/175817899-412486af-c0a7-483c-928f-077dc6b8bf3e.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Após clicar no ícone de lápis, o usuário é redirecionado a uma página onde poderá fazer as alterações necessárias.

<p align="center">Figura 55 – Página de edição do currículo </p>

![image](https://user-images.githubusercontent.com/26911388/175817946-8f8f71e8-2af8-4979-84bb-616e6b921db3.png)

<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 56 – Currículo atualizado </p>

![image](https://user-images.githubusercontent.com/26911388/175817798-5897d771-9adb-45bf-be0a-d5cd323f9dc3.png)
![image](https://user-images.githubusercontent.com/26911388/175817985-f02aede8-e985-4962-9afa-7f18570d0f35.png)

<p align="center">Fonte: Elaborado pelos autores</p>

## CT 08 - Excluir informações do currículo (candidatos)

Quando o usuário acessa "Meu currículo" no menu, é apresentada uma tela com todas informações
pessoais e referentes ao currículo do candidato. Ao lado das informações são apresentados dois ícones, de um lápis e de uma lixeira, e para excluir uma informação, basta o usuário clicar no ícone de lixeira.

<p align="center">Figura 57 – Teste excluir informações do currículo </p>

![image](https://user-images.githubusercontent.com/26911388/175817798-5897d771-9adb-45bf-be0a-d5cd323f9dc3.png)
![image](https://user-images.githubusercontent.com/26911388/175817985-f02aede8-e985-4962-9afa-7f18570d0f35.png)

<p align="center">Fonte: Elaborado pelos autores</p>

Após clicar no ícone de lixeira, o usuário é redirecionado a uma página de confirmação de exclusão do item selecionado.

<p align="center">Figura 58 –  Página de exclusão de informação do currículo </p>

![image](https://user-images.githubusercontent.com/26911388/175818036-defdbf41-6237-451d-931d-ef10c755cba3.png)

<p align="center">Fonte: Elaborado pelos autores</p>

<p align="center">Figura 59 – Currículo atualizado </p>

![image](https://user-images.githubusercontent.com/26911388/175818071-75b54b31-0613-48a9-b13b-dbafde5cf7c1.png)

<p align="center">Fonte: Elaborado pelos autores</p>





