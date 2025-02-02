<a id="readme-top"></a>
## Video preview:
[![Teacher Admin Winform](https://img.youtube.com/vi/enfOm_v7_uI/0.jpg)](https://www.youtube.com/watch?v=enfOm_v7_uI)

## About The Project: Teacher's Admin

A teacher's mini learning management tool with create / delete functionality and ability to export utilizing streamwriter to create text files of highest GPA students or students within an honor roll range. 

<b>Project Objective:</b> Explore [Stystem.IO StreamWriter](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-9.0) Class.

### Built With
 [![Csharp][csharp-badge]][csharp-url]
 [![Dotnet][dotnet-badge]][Dotnet-url]
 [![Winforms][winforms-badge]][winforms-url]

## Getting Started

<a id="prereqs"></a>
### Prerequisites
Before you can run this application locally, make sure you have the following tools and software installed:

* **Visual Studio 2022** (or higher) with the **.NET Desktop Development** workload enabled
   - Download from [Visual Studio](https://visualstudio.microsoft.com/)
* Configure a path for storing text files
  - Within Admin.cs line 67: update path
    ```
    const string path = @"Your file path";
    ``` 

### Installation
1. Clone the repo
   ```
   > git clone https://github.com/MMdevworks/TeacherAdmin_Winform.git
   > cd TeacherAdmin_Winform
   ```
3. Open the project
   ```
   Open TeacherAdmin_Winform.sln in Visual Studio
   ```
5. Run the application
   ```
   Run the program via play button or press f5 in Visual Studio
   ```
   
### Interface Instructions:

* <b>Login:</b>

  * Use Teacher / Admin credentials to login to the program. 

* <b>Add a Student:</b>
  * Enter student information > Press Add to add student to the system

* <b>Delete a Student:</b>

  * Select a student in the table > Press Delete to remove the student from the system

* <b>Export Text File:</b>

  * Select either radio button: 
    1. Highest GPA - to export student or students with the highest GPA
    2. Honor roll - to export all students above 4.0 GPA in descending order
       >  With radio button selected > Press Export, the selected text file will be exported to the configured file path  
       > (<a href="#prereqs">see prerequisites</a>)

<p align="right">(<a href="#readme-top">Back to top</a>)</p>

[dotnet-badge]: https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
[Dotnet-url]: https://dotnet.microsoft.com/
[csharp-badge]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/
[winforms-badge]: https://img.shields.io/badge/WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white
[winforms-url]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-9.0
