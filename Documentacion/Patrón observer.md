---
theme: night
---

# Patrón observer

---
### Descripción
Es un patrón de diseño, que define una dependencia de 1,* entre objetos

![[imgdiapo2.png|500]]
---
Cuando un objeto "sujeto" cambia de estado, se lanza una notificación, actualizando los objetos dependientes

![[imgdiapo3.png]]
---
### Casos de uso
- Una abstracción tiene dos aspectos, donde uno depende del otro
- Cuando un cambio de objeto requiere cambiar otros, sin saber cuantos objetos tienen que ser cambiados
- Cuando un objeto debería ser capaz de notificar a otros sin hacer suposiciones sobre quienes son dichos objetos.
---
### Ventajas
- Ayuda con el desacoplamiento de objetos
- Cada observer puede implementar su propia lógica para manejar el evento
- C# cuenta con eventos y delegados, haciendo la implementación del patrón más sencilla
---
### Desventajas
- Añade complejidad adicional
- Los observadores requieren de una referencia a la clase que define el evento
- Pueden afectar a la performance de la solución
---
Diagrama de clases de mi implementación
![[diagrama clases patrón observer.png]]