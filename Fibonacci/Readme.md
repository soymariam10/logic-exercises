# Secuencia Fibonacci en C#

Este es un programa simple en C# que calcula y muestra la secuencia Fibonacci utilizando dos métodos: uno basado en recursión y memorización, y otro utilizando un bucle.

## Instrucciones de Ejecución

1. abre la consola desde el IDE
2. ingresa a la carpeta correspondiente, en este caso ./Fibonacci
3. para ejecutar utilizamos el comando 'dotnet run'

## Detalles del Código

### 1. Método Recursivo con Memorización

1. utiliza un diccionario ('memo') para almacenar y reutilizar datos previamente calculados
2. Calcula Fibonacci recursivamente para n - 1 y n - 2, suma los resultados y almacena el resultado en el diccionario memo. Devuelve el resultado.

### 2. Método principal (Main)

1. do-while Loop: Ejecuta el cuerpo del programa al menos una vez y pregunta al usuario si desea continuar al final de cada iteración.
2. cuerpo del programa: Contiene la lógica principal del programa, que incluye la solicitud del número de términos de Fibonacci, el cálculo y la impresión de la secuencia, y la pregunta para continuar.

### 3. Ejemplos
