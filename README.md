Proyecto de Registro de Trabajadores

Descripción

Este proyecto está diseñado para gestionar el registro de trabajadores a través de una API RESTful. Permite a los usuarios registrar nuevos trabajadores mediante el método HTTP POST y consultar todos los trabajadores registrados utilizando el método GET.

Funcionalidades

- **Registro de Trabajadores**: Permite la creación de nuevos registros de trabajadores a través de un método POST. Los datos necesarios para el registro incluyen información básica como nombre, apellido, Cargo y Fecha y hora de ingreso.
- **Consulta de Trabajadores**: Ofrece la funcionalidad de recuperar todos los registros de trabajadores almacenados en la base de datos a través de un método GET.

Tecnologías Utilizadas

- Visual Studio 2022
- C#
- ASP.NET Core
- Entity Framework Core 

Instalación

1. Clona este repositorio en tu máquina local.
   ```cmd
   git clone https: https://github.com/Argeol/ProyectArg.git  
2. Abre el proyecto en Visual Studio 2022.
3. Restaura los paquetes NuGet necesarios.
4. Configura la cadena de conexión a tu base de datos en el archivo `appsettings.json`.
5. Ejecuta la aplicación y realiza pruebas en la API utilizando herramienta Swagger.

Uso

Para registrar un nuevo trabajador, envía una solicitud POST a `http://localhost:5000/api/trabajadores` con los datos del trabajador en el cuerpo de la solicitud en formato JSON.
Para consultar todos los trabajadores registrados, envía una solicitud GET a `http://localhost:5000/api/trabajadores`.
