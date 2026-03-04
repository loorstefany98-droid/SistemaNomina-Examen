# Sistema de Nómina - Examen Integración de Software

Este repositorio contiene el código fuente del Sistema de Nómina desarrollado como examen práctico del segundo parcial de la asignatura de Integración de Software. El proyecto está construido bajo el patrón arquitectónico MVC utilizando ASP.NET Core y C#.

##  Arquitectura y Estructura del Proyecto
Cumpliendo con las indicaciones del proyecto, el repositorio está estructurado en dos directorios principales:
* **/app**: Contiene el código fuente del proyecto web ASP.NET Core MVC (Modelos, Vistas, Controladores, y configuración del DbContext).
* **/db**: Espacio destinado para scripts SQL y control de base de datos.

##  Estrategia de Ramas (Git Flow)
Para el desarrollo colaborativo se implementó la siguiente estrategia:
* **`main`**: Rama bloqueada, contiene únicamente la versión estable y final para entrega.
* **`develop`**: Rama principal de integración donde se fusionó el trabajo del equipo.
* **`feature/*`**: Ramas individuales creadas por cada desarrollador para trabajar módulos específicos sin generar conflictos.

##  Instrucciones de Ejecución
Para que el sistema funcione correctamente en un entorno local, siga estos pasos:

1. **Clonar el repositorio:**
   git clone https://github.com/loorstefany98-droid/SistemaNomina-Examen.git

2. **Posicionarse en la rama de entrega :**
   git checkout main

3. **Configurar la Cadena de Conexión:**
   Abra el proyecto en Visual Studio 2022. Diríjase al archivo `appsettings.json` ubicado en la carpeta `/app` y modifique la sección `DefaultConnection` para que apunte a su servidor SQL Server local.
   Ejemplo: `"Server=localhost\SQLEXPRESS
 ;Database=NominaDB;Trusted_Connection=True;MultipleActiveResultSets=true"`

4. **Aplicar Migraciones (Base de Datos):**
   Abra la Consola del Administrador de Paquetes en Visual Studio (Herramientas > Administrador de paquetes NuGet) y ejecute el siguiente comando para generar las 8 tablas en su SQL Server local:
   `Update-Database`

5. **Ejecutar el proyecto:**
   Presione `F5` o el botón "Iniciar" en Visual Studio. El proyecto compilará y abrirá el sistema en su navegador web (`localhost`).

##  Equipo de Desarrollo
* **Josselyn**: Líder Técnica, Arquitectura MVC, Gestión de Repositorio (Git/GitHub) e Integración.
* **Evelyn**: Desarrollo de Backend, Modelos de Datos (Entity Framework) y Reglas de Negocio.
* **Bryan / Sebastian**: Desarrollo de Backend, Controladores, Configuración de Servidor y DbContext.
* **Rocío Josselyn y Sebastian**: Desarrollo Frontend, Diseño de Vistas (Razor), Ruteo y UI/UX.
