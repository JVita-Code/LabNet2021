function validarCampos(){  

var Nombre=document.form.Nombre.value;  
var Apellido=document.form.Apellido.value;

if (Nombre==null || Nombre==""){  
  alert("Debe ingresar su nombre.");  
  return false;}

else if (Apellido==null || Apellido==""){  
  alert("Debe ingresar su apellido.");  
  return false;}
}

function borrarCampos(){

  document.form.Nombre.value = "";  
  document.form.Apellido.value = "";
  document.form.Edad.value = "";
  document.form.Género.value = "";
  document.form.Empresa.value = "";
  
}