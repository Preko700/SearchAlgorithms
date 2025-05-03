# Algoritmos de Búsqueda en C#

[![Last Update](https://img.shields.io/badge/última%20actualización-2025--05--03-blue.svg)](https://github.com/Preko700/search-algorithms)
[![GitHub](https://img.shields.io/github/license/Preko700/search-algorithms?color=blue)](https://github.com/Preko700/SearchAlgorithms)

## 📝 Descripción

Este repositorio contiene la implementación de algoritmos de búsqueda fundamentales en C#, desarrollados como parte de un proyecto para el curso de Algoritmos y Estructuras de Datos. Los algoritmos implementados incluyen búsqueda lineal y búsqueda binaria (con versiones iterativa y recursiva).

## 🔍 Algoritmos Implementados

### Búsqueda Lineal

- **Complejidad temporal**: O(n)
- **Descripción**: Recorre el arreglo secuencialmente comparando cada elemento con el valor buscado.
- **Ventaja**: Funciona en arreglos ordenados y no ordenados.

### Búsqueda Binaria

- **Complejidad temporal**: O(log n)
- **Descripción**: Divide el arreglo ordenado a la mitad repetidamente hasta encontrar el elemento.
- **Requisito**: El arreglo debe estar ordenado.
- **Implementaciones**: 
  - Versión iterativa
  - Versión recursiva

## 🏗️ Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

```
search-algorithms/
├── SearchAlgorithms/             # Proyecto de biblioteca de clases
│   └── Search.cs                 # Implementación de los algoritmos
├── SearchAlgorithmsTests/        # Proyecto de pruebas unitarias
│   └── SearchTests.cs            # Pruebas para verificar los algoritmos
└── SearchAlgorithms.sln          # Archivo de solución
```

## 🚀 Cómo Utilizar

### Requisitos Previos

- .NET 6.0 o superior
- Visual Studio 2022 o equivalente

### Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/Preko700/search-algorithms.git
```

2. Abrir la solución `SearchAlgorithms.sln` en Visual Studio.

### Ejemplos de Uso

```csharp
// Búsqueda lineal
int[] array = { 5, 3, 8, 6, 2, 7, 1, 4, 9 };
int target = 7;
int index = Search.LinearSearch(array, target);
Console.WriteLine($"El elemento {target} se encuentra en el índice {index}");

// Búsqueda binaria (el arreglo debe estar ordenado)
int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
target = 7;
index = Search.BinarySearch(sortedArray, target);
Console.WriteLine($"El elemento {target} se encuentra en el índice {index}");

// Búsqueda binaria recursiva
index = Search.BinarySearchRecursive(sortedArray, target);
Console.WriteLine($"El elemento {target} se encuentra en el índice {index}");
```

## 🧪 Pruebas Unitarias

El proyecto incluye un conjunto completo de pruebas unitarias que verifican el funcionamiento correcto de cada algoritmo en diversos escenarios:

- Elementos presentes/ausentes en el arreglo
- Primer/último elemento del arreglo
- Arreglos vacíos
- Elementos duplicados
- Y más...

Para ejecutar las pruebas:

1. En Visual Studio, abra el Explorador de pruebas (Test Explorer)
2. Seleccione "Ejecutar todas las pruebas"

## 📊 Comparación de Rendimiento

| Algoritmo | Mejor Caso | Caso Promedio | Peor Caso | Restricciones |
|-----------|------------|---------------|-----------|---------------|
| Búsqueda Lineal | O(1) | O(n) | O(n) | Ninguna |
| Búsqueda Binaria | O(1) | O(log n) | O(log n) | Arreglo ordenado |

## 💻 Contribuciones

Las contribuciones son bienvenidas. Para contribuir:

1. Haz un fork del repositorio
2. Crea una rama para tu característica
3. Realiza tus cambios
4. Envía un pull request

## 📄 Licencia

Este proyecto está licenciado bajo MIT License - vea el archivo [LICENSE](LICENSE) para más detalles.

## 👤 Autor

- **Adrián Monge Mairena** - [GitHub](https://github.com/Preko700)

---

*Última actualización: 2025-05-03*
```
