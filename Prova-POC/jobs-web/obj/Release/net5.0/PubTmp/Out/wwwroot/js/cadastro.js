const tel = document.getElementById('telefone')

tel.addEventListener('keyup', (e) => mascaraTelefone(e.target.value))
tel.addEventListener('change', (e) => mascaraTelefone(e.target.value))

const mascaraTelefone = (valor) => {
    valor = valor.replace(/\D/g, "")
    valor = valor.replace(/^(\d{2})(\d)/g, "($1) $2")
    valor = valor.replace(/(\d)(\d{4})$/, "$1-$2")
    tel.value = valor
}

const cel = document.getElementById('celular')

cel.addEventListener('keyup', (e) => mascaraCelular(e.target.value))
cel.addEventListener('change', (e) => mascaraCelular(e.target.value))

const mascaraCelular = (valor) => {
    valor = valor.replace(/\D/g, "")
    valor = valor.replace(/^(\d{2})(\d)/g, "($1) $2")
    valor = valor.replace(/(\d)(\d{4})$/, "$1-$2")
    cel.value = valor
}

const senha = document.getElementById('password')
const confirmacao = document.getElementById('confirmationPassword')
let span = document.getElementById('msgConfirmationPassword')

confirmacao.addEventListener('keyup', (e) => validacaoSenha(e.target.value))

function validacaoSenha() {

    if (confirmacao.value != senha.value) {
        return span.classList.remove('invisible');
    } else {
        return span.classList.add('invisible');
    }

}