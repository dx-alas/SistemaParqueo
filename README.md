# Sistema de Gestión de Parqueo - UNAB

Este repositorio contiene la solución integral para un sistema de control de estacionamiento, desarrollado bajo una arquitectura en capas utilizando **C# (.NET)** y **SQL Server**.

---

## 1. Instrucciones de Ejecución

Para clonar y ejecutar el proyecto en su entorno local:

1. Abrir **Visual Studio Community**.
2. Seleccionar **Clonar un repositorio**.
3. Ingresar la URL:
   ```
   https://github.com/dx-alas/SistemaParqueo.git
   ```
4. Elegir la carpeta local y presionar **Clonar**.

---

## 2. Configuración de la Base de Datos

El sistema puede trabajar con **dos modalidades de base de datos**:

### Opción A: Base de Datos Local (SQL Server)

1. Abrir **SQL Server Management Studio (SSMS)**.
2. Ejecutar el script `Sistema_Parqueo_Script_Completo.sql` ubicado en:
   ```
   https://github.com/dx-alas/SistemaParqueoBD
   ```

Este script crea la base de datos, tablas, datos de prueba y procedimientos almacenados.

---

### Opción B: Base de Datos Remota

1. Abrir `App.config` dentro de **SistemaParqueo.Desktop**.
2. Ubicar `<connectionStrings>`.
3. Reemplazar `Data Source` con el servidor remoto:

```
"Server=db50446.public.databaseasp.net; Database=db50446; User Id=db50446; Password=B=h7r9-GA#k6; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"
```

El servidor debe permitir conexiones remotas.

---

## 3. Ejecución del Proyecto

1. Abrir el proyecto en Visual Studio.
2. Seleccionar **SistemaParqueo.Desktop** como proyecto de inicio.
3. Ejecutar con **F5**.

---

## 4. Login de Prueba

- Usuario: daniel.alas
- Contraseña: daniel

---

## 5. Desarrolladores

- Daniel Alexander Alas Sánchez  
- Edward Edenilson Martínez Rodríguez  
- Josué Enrique Guzmán Bonilla  
- Katherine Jeannette Hernández Canizález  
- Bryan Ernesto García Sánchez  

---

## © 2026 - UNAB
