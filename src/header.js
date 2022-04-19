const template = document.createElement("template");
template.innerHTML = `
    <style>
      * {
        padding: 0;
        margin: 0;
      }
      header {
        width: 100%;
        height: 75px;
        background-color: #f4b324;
        display: flex;
        align-items: center;
      }
      a {
        font-family: "Inter";
        font-style: normal;
        font-weight: 400;
        font-size: 14px;
        line-height: 18px;
        text-decoration: none;
        color: #000000;
        text-transform: uppercase;
      }
      .logo {
        display: flex;
        align-items: center;
        justify-content: center;
        height: 60px;
        width: 60px;
        border-radius: 100px;
        background-color: gray;
        margin-left: 26px;
      }
      .vertical-line {
        height: 30px;
        border: 1px solid #000000;
      }
      .links {
        display: flex;
        justify-content: space-evenly;
        align-items: center;
        width: 70%;
        margin-left: 150px;
      }
    </style>

   <header>
      <div class="logo">LOGO</div>
      <div class="links">
        <a href="index.html">Inicio</a>
        <a href="">Meu Currículo</a>
        <a href="">Vagas Salvas</a>
        <a href="">Candidaturas</a>
        <div class="vertical-line"></div>
        <a href="">Dúvidas</a>
        <a href="">FAQ</a>
      </div>
      <div class="logo">
        <img src="img/user.png" alt="">
      </div>
    </header>

`;

class Header extends HTMLElement {
  constructor() {
    super();
    console.log("BATATA");

    this.attachShadow({ mode: "open" });
    this.shadowRoot.appendChild(template.content.cloneNode(true));
  }
}

window.customElements.define("comp-header", Header);
