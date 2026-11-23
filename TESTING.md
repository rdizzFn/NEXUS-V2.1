# NEXUS - Software Testing & Debugging

## 1. Pruebas de entradas inválidas

Se revisaron las validaciones del sistema para comprobar que los datos ingresados por el usuario cumplan con los valores permitidos.

| ID | Prueba | Entrada | Resultado esperado |
|---|---|---|---|
| PR-01 | Nombre vacío | Texto vacío | Rechazar entrada |
| PR-02 | Nombre con números | Rodrigo123 | Mostrar error |
| PR-03 | Edad inferior al límite | 5 | Rechazar entrada |
| PR-04 | Edad superior al límite | 150 | Rechazar entrada |
| PR-05 | Energía negativa | -10 | Rechazar entrada |
| PR-06 | Estabilidad superior al límite | 120 | Rechazar entrada |
| PR-07 | Opción inválida del menú | 99 | Mostrar opción inválida |
| PR-08 | Entrada no numérica | ABC | Solicitar nuevamente el dato |

### Resultado de la revisión

Las validaciones existentes permiten controlar los datos incorrectos mediante métodos como `int.TryParse` y `double.TryParse`. Se identificó la necesidad de reforzar el control de valores numéricos especiales.

## 2. Pruebas de guardado y recuperación de partidas

Se plantean pruebas para comprobar que el progreso del cadete pueda guardarse y recuperarse sin perder información.

| ID | Prueba | Resultado esperado |
|---|---|---|
| PR-09 | Guardar partida | Conservar el progreso del cadete |
| PR-10 | Cerrar el juego | Mantener la información guardada |
| PR-11 | Recuperar partida | Restaurar el progreso anterior |
| PR-12 | Cargar partida inexistente | Mostrar mensaje de error |
| PR-13 | Recuperar inventario | Conservar los objetos obtenidos |
| PR-14 | Recuperar estadísticas | Restaurar energía, estabilidad y nivel |

### Resultado de la revisión

Se establecen los escenarios necesarios para comprobar la persistencia de los datos del cadete, su inventario y su progreso dentro de las realidades exploradas.

## 3. Pruebas de conexión con SQL Server

Pendiente de implementación y documentación.

Se contemplan pruebas para verificar la conexión con el servidor, la disponibilidad de la base de datos y el manejo de errores cuando no exista conexión.

## 4. Corrección de defectos

Durante la revisión del código se identificó una posible debilidad en la validación de valores numéricos especiales.

| ID | Defecto | Corrección propuesta |
|---|---|---|
| DEF-01 | Aceptación potencial de valores numéricos especiales | Incorporar controles adicionales para validar los valores ingresados. |

## 5. Repetición de pruebas

Después de aplicar las correcciones, se deberán repetir los escenarios correspondientes para comprobar que los defectos hayan sido solucionados y que las funcionalidades mantengan su comportamiento esperado.

## 6. Integración de cambios

Los cambios y la documentación se desarrollarán en la rama `testing-debugging`. Una vez finalizadas las correcciones y revisiones, se integrarán en la rama principal mediante un Pull Request en GitHub.
