Descripción:

Este programa lo hice en C# para simular un sistema básico de atención al cliente en una tienda. Usa una cola (Queue) para organizar a los clientes en el mismo orden en que van llegando, como pasa en la vida real.

Agregar un nuevo cliente a la cola
Atender al siguiente cliente (primero en entrar, primero en salir)
Mostrar la lista completa de clientes que están esperando
Menú interactivo por consola
Validación para evitar errores cuando no hay clientes en la cola

¿Cómo funciona?
Al ejecutar el programa aparece un menú bien claro con estas opciones:

Agregar cliente
Atender cliente
Ver cola actual
Salir

Cuando eliges agregar un cliente, te pide su nombre y número de teléfono. Ese cliente se guarda en la cola.
Como es una cola FIFO (First In, First Out), siempre se atiende primero a la persona que llegó antes.
Estructura utilizada
Utilicé la clase Queue<Cliente> de C# para manejar todo. Es muy práctica porque tiene los métodos que necesitaba:

Enqueue() → para agregar clientes
Dequeue() → para atender (quitar) al siguiente cliente
Count → para saber si la cola está vacía
