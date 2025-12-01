# CONTRIBUTING.md

## Directrices generales

Este repositorio contiene un proyecto en Visual Basic (.NET 10, WinForms). Las contribuciones deben seguir estas reglas para mantener coherencia y facilitar la integración:

- Mantener compatibilidad con `net10.0-windows` y WinForms.
- Usar VB.NET y respetar las convenciones de nombres descritas más abajo.
- Evitar cambios manuales en archivos generados por el diseñador salvo que sea necesario; documentarlo en el commit.
- Mantener una indentación de 4 espacios.
- Escribir mensajes de commit claros y en español.

## Estándares de codificación

- Variables locales en camelCase (ej. `studentIndex`, `nota`).
- Métodos y eventos en PascalCase (ej. `CalculateAverages`).
- Nombres de controles en el formulario con prefijos: `btn` para botones, `txt` para TextBox, `lst` para listas.
- Constantes en PascalCase (ej. `PassingThreshold`).
- Evitar líneas >120 caracteres.

## Pruebas y ejecución

- Abrir la solución con __File > Open > Project/Solution__ y cargar `daniel_alvarez.vbproj`.
- Ejecutar con __Debug > Start Debugging__.
- Para cambios lógicos, añadir instrucciones breves sobre cómo probar los cambios.

## Flujo de trabajo

- Crear ramas descriptivas: `feature/ex3-promedios`.
- Hacer commits atómicos y abrir Pull Requests contra `master`.

## Ejemplo mínimo de estilo

- Nombres de controles: `btnCalcular`, `txtResultados`.
- Eventos: `Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click`.

## Autoría

- Daniel Alvarez, cédula 31812100.

## Ejercicio 3

- Promedios calculados con notas en rango 0..20.
- Aprobación a partir de 10 (>=10).
- Interfaz: formulario WinForms con botón para iniciar la captura y un cuadro de texto multiline para mostrar resultados.
