function alertaBotonCancelar() {
document.getElementById('nombre').value = '';
document.getElementById('apellido').value = '';
}

function validacionNombreApellido() {

    let nombre = document.getElementById('nombre').value.trim();
    let apellido = document.getElementById('apellido').value.trim();

    if (nombre.length === 0 || apellido.length === 0) {
        alert("El nombre y apellido deben estar completos");
        return
    }

    if (nombre.length > 10) {
        alert("El nombre debe ser menor a 10 caracteres");
        return
    }

    if (/\d/.test(apellido)) {
        alert("El apellido no debe contener números");
        return
    }

    return alert("Se registró exitosamente");
}
function calcularEdad() {
    const fechaNacimiento = document.getElementById("fechaNacimiento").value;
    const edadSpan = document.getElementById("edad");

    if (fechaNacimiento) {
        const hoy = new Date();
        const fechaNac = new Date(fechaNacimiento);
        let edad = hoy.getFullYear() - fechaNac.getFullYear();
        const m = hoy.getMonth() - fechaNac.getMonth();

        if (m < 0 || (m === 0 && hoy.getDate() < fechaNac.getDate())) {
             edad--;
         }

        edadSpan.textContent = edad + " años";
        } else {
            edadSpan.textContent = "";
    }
}

