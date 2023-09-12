# Proyecto Test Unitario

## Creacion Proyectos

- Crear Proyecto de Biblioteca

```
dotnet new classlib -n Biblioteca
```

- Crear proyecto de Test Unitario

```
dotnet new xunit -n Tests
```

- Crear archivo solucion

```
dotnet new sln -n EjemploTests
```

- Asociar proyectos a la solucion

```
dotnet sln EjemploTests.sln add Biblioteca/Bibliteca.csproj


dotnet sln EjemploTests.sln add Tests/Tests.csproj
```

- Agregar dependencia de proyecto Bilbioteca al proyecto de Tests


## Configuracion

- Crear clases correspondientes en el proyecto de bilbioteca
- Crear tests unitarios (uno por cada clase del proyecto de biblioteca)
- Recordar colocar la siguiente linea al comienzo de cada tests unitario

```
using Biblioteca;
```

- Ejecutar proyecto de tests unitarios con el siguiente comando:

```
dotnet test
```
