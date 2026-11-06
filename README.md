# RegistroEstudiantes

## Descripción

Aplicación desarrollada en .NET MAUI aplicando el patrón de arquitectura MVVM (Model-View-ViewModel).

Permite registrar estudiantes mediante un formulario y mostrarlos en una lista utilizando CollectionView.

---

## Arquitectura MVVM

### Model
Contiene la clase Estudiante con los datos del estudiante:

- Nombre
- Correo
- Teléfono
- Carrera
- Fecha

### View
Corresponde a la interfaz gráfica desarrollada en XAML.

- RegistroPage.xaml

### ViewModel
Contiene la lógica de la aplicación:

- Propiedades observables
- Validación de datos
- GuardarCommand
- ObservableCollection de estudiantes

### Services
Carpeta preparada para servicios de negocio y acceso a datos.

---

## Tecnologías Utilizadas

- .NET MAUI
- CommunityToolkit.Mvvm
- MVVM
- Dependency Injection
- CollectionView
- ObservableCollection

---

## Funcionalidades

- Registro de estudiantes.
- Validación de campos mediante CanExecute.
- Habilitación y deshabilitación automática del botón Guardar.
- Actualización automática de la lista.
- Uso de bindings compilados mediante x:DataType.
- Inyección de dependencias mediante MauiProgram.

---

## Diagrama MVVM

View (RegistroPage)
        |
        v
ViewModel (RegistroViewModel)
        |
        v
Model (Estudiante)

---
