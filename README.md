# Trabajo Práctico N°3

## Ejercicio 1

Implemente el diagrama de clase que está al final del enunciado de este ejercicio. Los
métodos Correr y Saltar de la clase abstracta Animal imprimen por pantalla las cadenas de
texto “corriendo” y “saltando” respectivamente. Cada instancia particular de las subclases
de la clase Animal implementa el método HacerRuido con la impresión por consola de
texto de su sonido característico. Implemente dos subclases de Animal adicionales además
de las presentes.
Al desarrollar este ejercicio utilice un arreglo con los dos tipos de animales suministrándola
a una instancia de la clase Veterinaria. Dicha clase en su único método itera el arreglo
pasándole el mensaje HacerRuido a todas las instancias de la clase Animal.
Nota: El objetivo de este ejercicio es la demostración de uso de la característica
polimorfismo, por ello no es necesario realizar una fachada. Este ejercicio incurre en una
técnica no recomendable que es la mezcla de código de presentación (la impresión por
consola del sonido) y de código de dominio, pero se realiza por fines educativos y para
mostrar más claramente el concepto.
