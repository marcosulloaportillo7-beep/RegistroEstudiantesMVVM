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

## Capturas

Captura del registro y como se ve, el botón de Guardar no se revela hasta que todos los campos estén llenos

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/31413f5f-6221-4bcb-a1e9-6312b0e2e03c" />

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/9223b403-f4d9-49e5-9450-c878c7460cce" />


Registro de estudiantes en la lista

<img width="200" height="400" alt="image" src="https://github.com/user-attachments/assets/9ae69bb7-2e52-4c0c-8f9e-d14237139a3f" />

