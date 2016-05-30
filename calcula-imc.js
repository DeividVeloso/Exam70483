

function montaPaciente(pacienteTr) {
    var tdPeso = pacienteTr.getElementsByClassName("info-peso")[0];
    var tdAltura = pacienteTr.getElementsByClassName("info-altura")[0];
    var tdNome = pacienteTr.getElementsByClassName("info-nome")[0];

    var pacienteAtual = {
        "peso": tdPeso.textContent,
        "altura": tdAltura.textContent,
        "nome": tdNome.textContent,
        "pegaImc": function () {
            if (this.altura != 0) {
                var imc = this.peso / (this.altura * this.altura);
                console.log(imc);
                return imc;

            } else {
                console.log("Altura igual a zero");
            }
        }
    };

    return pacienteAtual;

}



function imprimeEModificaTdDeImc(pacienteTr) {

    var pacienteAtual = montaPaciente(pacienteTr);
    var imc = pacienteAtual.pegaImc();

    var tdImc = pacienteTr.getElementsByClassName("info-imc")[0];
    tdImc.textContent = imc;

    console.log(imc);
}



var botao = document.getElementById("calcula-imcs");
botao.addEventListener("click", function () {
    var trsPacientes = document.getElementsByClassName("paciente");

    percorreArray(trsPacientes, imprimeEModificaTdDeImc);

});
