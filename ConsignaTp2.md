# labnet2021
LabNet2021 | NET + ANGULAR | Bootcamp

Crear una Aplicación de Consola, Windows Forms o Unit Test.



1) Realizar una método que al ingresar un valor genere una simple excepción al intentar hacer una división por cero. 
Esta misma excepción deberá ser capturada, mostrando el mensaje de la excepción y siempre deberá avisar cuando terminó de realizarse la operación haya sido exitosa o no.


2) Realizar un método que permita ingresar 2 números (dividendo y divisor) y realice la división de los mismos. 
Se deberán mostrar el resultado (Si es un Unit Test tener en cuenta los Assert).
Si hay una excepción de división por cero se deberá mostrar el siguiente mensaje: “Solo Chuck Norris divide por cero!” más el mensaje de la excepción propia, 
También se deberá capturar una excepción si el usuario no ingresa ningún número o el mismo no es un número válido, informando con un mensaje al estilo “Seguro Ingreso una letra o no ingreso nada!”.


3) Realizar un método en una clase “Logic”, llamado desde la “presentación” (Consola, UnitTest, Etc.), que dispare una excepción. La misma deberá ser capturada por la UI. 
Deberá mostrar el mensaje de la excepción y el tipo de la excepción.

4) Volver a realizar el ejercicio anterior pero esta vez la lógica deberá simplemente devolver un tipo de excepción personalizada y ser capturada por la misma aplicación.

Tip: Para ello se deberá agregar una clase al proyecto. Esta clase deberá heredar de tipo Excepción. La misma clase tendrá un constructor con un parámetro del tipo string donde se permitirá ingresar un mensaje personalizado. También se debe hacer una sobrecarga al “Message” Agregando algún mensaje al comienzo del mensaje de la clase base. Mostrar el mensaje de la excepción en una caja de texto.

*Recordar crear una nueva branch para realizar este ejercicio.

*Se valorará quien se anime a trabajar con Unit Test (no es obligatorio)
