<div align="center">

  # 🖥️ MiPresentacion — Avalonia UI 11
  
  **Aplicación de escritorio multiplataforma interactiva construida con C# y Avalonia UI 11.**

  [![NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
  [![AvaloniaUI](https://img.shields.io/badge/Avalonia_UI-11.0.10-purple?style=for-the-badge&logo=dotnet&logoColor=white)](https://avaloniaui.net/)
  [![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
  [![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)](LICENSE)

</div>

---

## 📖 Tabla de Contenidos
- [Acerca del Proyecto](#-acerca-del-proyecto)
- [Características Principales](#-características-principales)
- [Estructura del Proyecto](#-estructura-del-proyecto)
- [Casos de Prueba y Validaciones](#-casos-de-prueba-y-validaciones)
- [Instrucciones de Ejecución](#-instrucciones-de-ejecución)
- [Pregunta de Reflexión](#-pregunta-de-reflexión)

---

## 🎯 Acerca del Proyecto

**MiPresentacion** es un taller práctico enfocado en comprender el patrón **Code-Behind**, la arquitectura de interfaz gráfica mediante **XAML** y el procesamiento de **eventos en C#**. La aplicación permite registrar información de un usuario, validar datos en tiempo real y emitir respuestas dinámicas.

> [!NOTE]
> Este proyecto cuenta con la implementación completa del **Reto Adicional**, permitiendo conmutar entre diferentes estilos de saludo dinámicamente sin reiniciar la aplicación.

---

## ✨ Características Principales

- 🎨 **Diseño Limpio con XAML**: Maquetación estructurada mediante `StackPanel`, `Margin` y `Spacing`.
- ⚡ **Enlace e Interacción**: Uso de `x:Name` para vinculación de controles C# <-> XAML.
- 🛡️ **Validaciones Robustas**:
  - Control de campos vacíos o con espacios en blanco.
  - Verificación estricta de edad numérica mediante `int.TryParse()`.
  - Comprobación de números enteros positivos.
- 🎯 **Manejo de Foco**: Retorno de cursor interactivo al campo principal usando `.Focus()`.
- 🔄 **Reto Adicional**: Alternancia de plantilla de saludo mediante un botón de acción dedicado.

---

## 📁 Estructura del Proyecto

```text
MiPresentacion/
│
├── Program.cs           # Punto de entrada de la aplicación Avalonia
├── App.axaml            # Configuración de estilos globales y temas
├── App.axaml.cs         # Inicialización del ciclo de vida de la app
├── MainWindow.axaml     # Interfaz gráfica de la ventana principal (XAML)
├── MainWindow.axaml.cs  # Lógica de negocio y manejadores de eventos (C#)
├── MiPresentacion.csproj# Archivo de proyecto y dependencias NuGet
└── README.md            # Documentación del repositorio

##🧪 Casos de Prueba y Validaciones
Caso,Datos Introducidos,Resultado Esperado,Estado
-1,"Nombre, Apellido y Edad válidos",Muestra la presentación personalizada correctamente.,PASADO
-2,Nombre vacío,Muestra advertencia y enfoca el campo Nombre.,PASADO
-3,Apellido vacío,Muestra advertencia y enfoca el campo Apellido.,PASADO
-4,Edad con letras,Solicita un valor numérico entero válido.,PASADO
-5,Edad negativa o igual a 0,Rechaza el valor indicando que debe ser mayor a 0.,PASADO
-6,Presionar botón Limpiar,Restablece el formulario y vuelve el foco al Nombre.,PASADO

##Pasos de Instalación
Clonar el repositorio:

Bash
git clone [https://github.com/TU-USUARIO/MiPresentacion.git](https://github.com/TU-USUARIO/MiPresentacion.git)
cd MiPresentacion
Restaurar dependencias:

Bash
dotnet restore
Ejecutar la aplicación:

Bash
dotnet run

##🧠 Pregunta de Reflexión
¿Cuál es la función de MainWindow.axaml y MainWindow.axaml.cs, y cómo se relacionan mediante x:Name y los eventos Click para permitir que el usuario interactúe con la aplicación?

##Respuesta:

MainWindow.axaml actúa como la capa visual de la aplicación, donde se define la jerarquía de los elementos gráficos, disposiciones y colores mediante código de marcado XAML. MainWindow.axaml.cs constituye el código subyacente (code-behind) escrito en C#, donde reside la lógica para procesar datos, hacer validaciones y responder a la entrada del usuario.

Ambos se relacionan mediante:

x:Name: Asigna una identidad única a cada control gráfico en el XAML (como TxtNombre o TxtResultado), permitiendo que desde C# podamos manipular sus propiedades (.Text), cambiar estilos o invocar métodos de interfaz (.Focus()).

Eventos Click: Vinculan la interacción del usuario (como presionar el botón Presentarme) con métodos específicos en C# (BtnPresentarme_Click). Al ocurrir el clic, se ejecuta el bloque de código correspondiente que lee las entradas, las valida y actualiza la vista.
