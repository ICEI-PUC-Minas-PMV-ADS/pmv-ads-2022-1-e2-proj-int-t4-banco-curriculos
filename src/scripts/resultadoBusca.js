function addCard() {
  console.log("entrou");
  let content = document.querySelector(".cards-wrapper");
  let output = "";

  output += `
    <div class="card">
      <div class="star-icon">
        <img class="icon" src="../img/Star 1.svg" alt="" />
      </div>
      <div class="header-card">
        <span>Vaga 1</span>
      </div>
      <div class="info-card">
        <p>
          R. Fulano de Tal da Silva, n° XXX - Bairro Aleatório, Cidade
          Desconhecida - UF, 00000-000
        </p>
      </div>
    </div>
  `;
  content.innerHTML = output;
}
