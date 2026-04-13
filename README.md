# Proyecto: Sistema de Gestión de Parqueo - UNAB

Este repositorio contiene la solución integral para el sistema de control de estacionamiento, desarrollado bajo una arquitectura de capas utilizando **C# (.NET)** y **SQL Server**.

## 1. Instrucciones de Lanzamiento

Para clonar y configurar el proyecto en su entorno local, siga estos pasos:

1. Inicie **Visual Studio Community**.
2. Seleccione la opción **Clonar un repositorio**.
3. Ingrese la URL del repositorio: `https://github.com/dx-alas/SistemaParqueo.git`
4. Defina la ruta local y presione **Clonar**.

## 2. Configuración de la Base de Datos

El sistema requiere una base de datos SQL Server para su funcionamiento. Siga este procedimiento:

1. Acceda al repositorio de la base de datos: [SistemaParqueoBD](https://github.com/dx-alas/SistemaParqueoBD/).
2. Localice el archivo `LoginDemoSetup.sql` y copie su contenido.
3. Abra **SQL Server Management Studio (SSMS)** y cree una nueva consulta (**New Query**).
4. Pegue el código y ejecute el script completo. Este paso creará las tablas, cargará datos de prueba y generará los procedimientos almacenados necesarios para probar el Login.

## 3. Configuración del Entorno de Desarrollo

Antes de ejecutar la aplicación, es necesario vincularla con su instancia local de base de datos:

1. En Visual Studio, abra el proyecto `SistemaParqueo.Desktop`.
2. Busque el archivo `App.config`.
3. Modifique la cadena de conexión (`connectionString`) ajustando el nombre del servidor o usuario según su configuración local de SQL Server.
4. Haga clic derecho sobre el proyecto **SistemaParqueo.Desktop** en el Explorador de Soluciones y seleccione **Establecer como proyecto de inicio**.
5. Presione el botón **Iniciar** (o la tecla F5).

## 4. Acceso al Sistema (Prueba de Login)

Una vez iniciada la aplicación, utilice las siguientes credenciales para validar el acceso:

* **Usuario:** admin
* **Contraseña:** 123

---

## Desarrolladores

El desarrollo de este sistema ha sido realizado por:

* **Daniel Alexander Alas Sánchez**
* **Edward Edenilson Martínez Rodríguez**
* **Josué Enrique Guzmán Bonilla**
* **Katherine Jeannette Hernández Canizález**
* **Bryan Ernesto García Sánchez**

---
© 2026
