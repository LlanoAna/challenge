# challenge

Explicacion del codigo. 

Clase MasterMind: 

En el metodo GetHints: 

Recibe una lista de las jugadas realizadas, dentro del metodo se recorre el primer arreglo de la jugada para obtener la posicion y el color de cada elemento de la lista, de la misma forma es recorrido el segundo arreglo que contiene los elementos o el (codigo) para la comparacion de la jugada realizada. 

Luego de esto se realiza la comparacion de los dos arreglos tanto del codigo como de la jugada, comparando el color y la posicion y que retorne "Black" y luego se realiza la comparacion del color para que el metodo retorne "White" segun las reglas del juego.

Clase Program: 

Metodo Main: 

Se realiza el llenado de las listas de acuerdo a lo que recibe el objeto de la clase "MasterMind" y el metodo GetHints. 

se realiza un foreach para el recorrido del arreglo creado en base al resultado de las jugadas y el mismo muestra el resultado por consola. 



TestUnit 

Se creo un proyecto de Test para probar el codigo en cuestion 

Se creo una variable tipo list que tiene dos valores esperados (segun la prueba unitaria que queremos ejecutar) 
Luego se realiza el llenado de la lista de acuerdo a lo que recibe el objeto de la clase "MasterMind" y el metodo GetHints. 
Luego se hace una comparacion de las colecciones tanto del valor esperado como el resultado que es retornado por el metodo GetHints
