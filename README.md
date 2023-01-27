# Trabajo Práctico N°3

## Ejercicio 1

Implemente el diagrama de clase que está al final del enunciado de este ejercicio. Los
métodos _Correr_ y _Saltar_ de la clase abstracta _Animal_ imprimen por pantalla las cadenas de
texto “corriendo” y “saltando” respectivamente. Cada instancia particular de las subclases
de la clase _Animal_ implementa el método _HacerRuido_ con la impresión por consola de
texto de su sonido característico. Implemente dos subclases de Animal adicionales además
de las presentes.

Al desarrollar este ejercicio utilice un arreglo con los dos tipos de animales suministrándola
a una instancia de la clase _Veterinaria_. Dicha clase en su único método itera el arreglo
pasándole el mensaje _HacerRuido_ a todas las instancias de la clase _Animal_.

Nota: El objetivo de este ejercicio es la demostración de uso de la característica
polimorfismo, por ello no es necesario realizar una fachada. Este ejercicio incurre en una
técnica no recomendable que es la mezcla de código de presentación (la impresión por
consola del sonido) y de código de dominio, pero se realiza por fines educativos y para
mostrar más claramente el concepto.

![Ejercicio 1, diagrama de clases](img/ejercicio1-diagrama-de-clases.jpg)
