
# Projeto de Interface


## Diagrama de Fluxo

A estrutura da aplicação bem como seu alcance estão evidenciados no Diagrama de Fluxo, elaborado para relacionar os dados e os processos resultantes da transformação destes.

A seguir, o quadro 9, expositivo dos principais requisitos funcionais que direcionam o fluxo:

<p align = "center">Quadro 9 - Fluxo do usuário</p>
<div align = "center">

|FLUXO DO USUÁRIO    | DESCRIÇÃO   | RF |
|------|----------------------------------------------------------------------------------------------------------|------------|
|Cadastro de usuário | O usuário deve conseguir realizar um cadastro na aplicação, como candidato ou como empresa recrutadora.                                  | RF-01 E RF-02       | 
|Cadastro de vagas | O usuário deverá estar logado na aplicação. Caso não esteja, na página inicial, deverão ser preenchidos os campos de login e senha. Se o cadastro já existir, o sistema validará o acesso e redirecionará o usuário para a página personalizada com suas informações. A empresa recrutadora acessará a tela de anúncio de vagas e incluirá a posição de trabalho com sua descrição e requisitos.                          | RF-03      |
|Candidatura para vagas | O usuário deverá estar logado na aplicação. Se esse não for o caso, na página inicial, deverão ser preenchidos os campos de login e senha. Se o cadastro já existir, o sistema validará o acesso e redirecionará o usuário para a página personalizada com suas informações. O candidato poderá utilizar os campos de pesquisa para procurar vagas e se candidatar nas que definir serem de seu interesse.                                             | RF-06       |
|Pesquisa de candidatos | O usuário deverá estar logado na aplicação. Caso não esteja, na página inicial, deverão ser preenchidos os campos de login e senha. Se o cadastro já existir, o sistema validará o acesso e redirecionará o usuário para a página personalizada com suas informações. A empresa recrutadora poderá utilizar os campos de pesquisa para buscar candidatos que estejam dentro do perfil para a posição de emprego que deseja preencher.                                                  | RF-07      |

</div>
<p align = "center">Fonte: Elaborado pelos autores</p>
<br>

A representação gráfica pode ser visualizada na Figura 2:

<p align = "center">Figura 2 - Diagrama de fluxo</p>

<div align = "center">

<img src="img\flowchart.png"  width="1000" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

## Wireframes

Conforme fluxo de telas do projeto, apresentado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem.

### Tela - Login 

A tela inicial de login (Figura 3) permite ao usuário fazer login na aplicação, preenchendo suas credenciais conforme orientado. Além disso, o usuário pode ser direcionado para se cadastrar na opção “Não tem acesso? Cadastre-se” e para redefinir a senha da conta na opção "Esqueceu sua senha?".

<p align = "center">Figura 3 - Tela inicial</p>

<div align = "center">

<img src="img\Tela de login Destop.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Cadastro do Usuário 

O fluxo de Cadastro de Usuário ilustrado permite ao usuário se cadastrar na aplicação caso este ainda não possua uma conta, seguindo um formulário solicitando informações obrigatórias de acordo com o tipo de perfil a ser criado. Existindo duas opções como usuário padrão ou recrutador, sendo alternada através de um botão recrutador.

O cadastro usuário padrão é apresentado na Figura 4:

<p align = "center">Figura 4 - Cadastro do usuário padrão</p>

<div align = "center">

<img src="img\Tela de cadastro de usuário.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>


<p align = "center">Figura 5 - cadastro do usuário recrutador</p>

<div align = "center">

<img src="img\Tela de cadastro de recrutador.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>



### Tela - Homepage (Usuário padrão)

Depois de fazer o login na aplicação, o usuário é redirecionado para uma homepage, podendo clicar nas opções na barra de menu, localizada na parte superior, com os links para todas as páginas possíveis de serem utilizadas por ele. Na tela de início o usuário também poderá pesquisar por novas vagas, como apresentado nas Figuras 5 e 6.

<p align = "center">Figura 6 - Homepage do usuário padrão</p>

<div align = "center">

<img src="img\busca.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 7 - Homepage do usuário padrão após pesquisa</p>

<div align = "center">

<img src="img\resultado busca.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela - Homepage - fluxo para candidatar a uma vaga (Usuário padrão)

Após pesquisar vagas, o usuário pode se candidatar clicando sobra a vaga desejada e, posteriormente, em candidatar–se, como nas Figuras 7, 8 e 9.

<p align = "center">Figura 8 - Página com as vagas pesquisadas</p>

<div align = "center">

<img src="img\resultado busca.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 9 - Detalhes sobre a vaga</p>

<div align = "center">

<img src="img\visualizar vaga.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 10 - Candidatura realizada com sucesso</p>

<div align = "center">

<img src="img\Candidatura realizada com suceeso.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>


### Tela – Vagas candidatas (Usuário padrão)

A tela de permite ao usuário ver as vagas em que ele se candidatou.

<p align = "center">Figura 11 - Vagas candidatadas</p>

<div align = "center">

<img src="img\Vagas Candidatadas.jpg"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela – Salvas (Usuário padrão)

A tela permite que o usuário veja as vagas por ele salvas.

<p align = "center">Figura 12 - Vagas salvas</p>

<div align = "center">

<img src="img\Vagas salvas.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela – Meu currículo (Usuário padrão)

A tela permite que usuário crie seu currículo preenchendo os campos do formulário conforme solicitado e clicando em Salvar.

<p align = "center">Figura 13 - Meu currículo</p>

<div align = "center">

<img src="img\Meu currículo.png"  width="800" title="flowchart">
  
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela - Homepage (Usuário recrutador)

Depois de fazer o login na aplicação, o usuário é redirecionado para a homepage, ele possui a opção de clicar nas opções na barra de menu localizada na parte superior, com os links para todas as páginas possíveis de serem utilizadas por ele. Na tela de início existe um link que leva o recrutador para a página para criar uma nova vaga.

<p align = "center">Figura 14 - Homepage Recrutador</p>

<div align = "center">

<img src="img\Tela inicial Recrutador.png"  width="800" title="flowchart">
  
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela - Criação de nova vaga (Usuário recrutador)

A tela permite ao recrutador que ele faça a inclusão de uma nova vaga, preenchendo o formulário com as informações solicitadas.

<p align = "center">Figura 15 - Criação de vaga</p>

<div align = "center">

<img src="img\Postar Vaga.png"  width="800" title="flowchart">
  
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 16 - Vaga postada</p>

<div align = "center">
<img src="img\Vaga postada.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela – Vagas postadas (Usuário recrutador)
A tela permite ao recrutador visualize as vagas postadas, clicando sobre a vaga poderá ver mais detalhes sobre ela. Também poderá editar a vaga ou visualizar todos os candidatos para aquela vaga.

<p align = "center">Figura 17 - Vagas postadas</p>

<div align = "center">

<img src="img\vagas postadas.png"  width="800" title="flowchart">
  
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 18 - Detalhes vaga</p>

<div align = "center">
<img src="img\detalhe vaga.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 19 - Edição de vaga</p>

<div align = "center">
<img src="img\edicao de vaga.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>


<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 20 - Candidatos da vaga</p>

<div align = "center">
<img src="img\candidados determinada vaga.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>

### Tela – Candidatos (Usuário recrutador)
A tela permite ao recrutador visualize os candidatos e para qual vaga ele se candidatou, o fluxo também permite ver o currículo do candidato e a opção de fazer a exportação do currículo do candidato. 

<p align = "center">Figura 21 - Candidatos</p>

<div align = "center">
<img src="img\candidatos.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>


<div align = "center">
<img src="img\seta.png"  width="150" title="flowchart">
</div>

<p align = "center">Figura 22 - Currículo do candidato</p>

<div align = "center">
<img src="img\curriculo candidato.png"  width="800" title="flowchart">
</div>

<p align = "center">Fonte: Elaborado pelos autores</p>








