# Gestion de Biblioteca

## Clonacion del repositorio

```
cd /ruta/proyecto
~/ruta/proyecto/git clone https://github.com/borisumss/biblioteca.git
```

## Contrucction de la aplicacion consola
Intalacion de .NET en el maquina.
https://dotnet.microsoft.com/en-us/download

### Restaura los paquetes NuGet

```
~/ruta/proyecto/biblioteca> dotnet restore
```

### Compila el proyecto

```
~/ruta/proyecto/biblioteca> dotnet build
```

### Ejecuta el proyecto

```
~/ruta/proyecto/biblioteca/biblioteca> dotnet run
```

## Principios SOLID:

- **S: Single Responsibility Principle (SRP)** – Cada clase en el proyecto tiene una única responsabilidad.
- **O: Open/Closed Principle (OCP)** – Las interfaces permiten extender funcionalidades sin modificar el código existente. La clase `Book` puede extenderse por clases las cuales generos de libros como `FantasyBook`, `HorrorBook`, `SciFiBook`.
- **L: Liskov Substitution Principle (LSP)** – Las clases pueden tener comportamientos distintos. La clase `Student` y `LibraryChief` tienen en comun como autenticarse en el sistema, atributos como nombre, edad pero su poder en el sistema es distinto como ser que `Student` realiza operacion de prestacion y devolucion de libros mientras que `LibraryChief` tiene operaciones mas avanzadas como la gestion de usuarios, la gestion de libros, la gestion de los prestamos, etc. 
- **I: Interface Segregation Principle (ISP)** – Se crean interfaces específicas para cada funcionalidad. Como `ILibraryManager` gestiona las operaciones en la biblioteca y `IUserManager` gestiona las operaciones de los usuarios.
- **D: Dependency Inversion Principle (DIP)** – Las clases de alto nivel no dependen de clases de bajo nivel, sino de abstracciones o interfaces. Como ser `IUserManager`, `ILibraryManager`, `Book` es una clase abstracta, `IBookObservable`, `IUserObserver`.

## Patrones de Diseño:

- **Creational:** FactoryMethod (para la implementación de `BookFactory`).
- **Estructural:** Adapter (para la implementación de `LibraryPanelAdapter`, `ILibraryPanel`).
- **Comportamiento:** Observer (para la implementación de `IUserObserver`, `IBookObservable`).
## Arquitectura en 3 capas:

- **Capa de acceso a datos:** Contiene las clases que representan los datos y modelos del proyecto.
- **Capa de negocio:** Contiene la lógica de negocio y los patrones de diseño.
- **Capa de presentación:** Contiene la interfaz de usuario y los elementos visuales.
