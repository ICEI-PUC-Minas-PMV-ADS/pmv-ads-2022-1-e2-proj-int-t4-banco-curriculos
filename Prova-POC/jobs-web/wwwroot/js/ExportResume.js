function Export() {
    var getData = document.getElementById('export').innerHTML;

    var janela = window.open('', '', 'landscape');
    janela.document.write('<html><head>');
    janela.document.write('<title>Resume</title></head>');
    janela.document.write('<body>');
    janela.document.write(getData);
    janela.document.write('</body></html>');
    janela.document.close();
    janela.print();
}