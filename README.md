# Scientific Publications Management App

## Overview
This project is a **.NET MAUI application** designed for the Universidad's faculty to manage and keep track of scientific publications created by professors and students. The app stores and organizes publication data in memory, offering a user-friendly interface to interact with it.

---

## Features
The application implements the following core functionalities:

1. **Add New Publications**:
   - Allows users to insert new scientific publications with unique identifiers.
   
2. **Add Authors to Existing Publications**:
   - Supports adding one or multiple authors to an existing publication.

3. **View All Publications**:
   - Displays a list of all publications, showing their titles and types.
   - Users can select a publication to view its detailed information on a new page.

4. **Filter Publications by Type**:
   - Lets users filter and display publications of a specific type during runtime.

5. **Modify Publication Status**:
   - Enables users to change the status of a publication (e.g., "in_review", "accepted", "rejected") by searching for it using various fields.

6. **Filter Publications by Author**:
   - Provides the ability to search and display all publications created by a specific author.

7. **Delete a Publication by Title**:
   - Allows users to delete a publication based on its title.

---

## Design and Implementation
- The app uses a **Shell structure** to configure the visual hierarchy for navigation.
- Includes **hierarchical navigation** in some parts of the application for better user experience.
- Implements **styles** for consistent UI design.
- Uses **mock data** for testing and development purposes.

---

## Technical Details
- Developed using **.NET MAUI** for cross-platform compatibility.
- Publications include the following information:
  - **Unique Identifier**: Ensures no duplicate publications.
  - **Title**: Title of the publication.
  - **Date of Publication**: Records the publication date.
  - **Type of Publication**: Supports predefined types such as:
    - Full book
    - Book chapter
    - Journal article
    - Conference
  - **Publication Status**: Supports values like:
    - In Review
    - Accepted
    - Rejected
  - **Authors**: Stores one or multiple author names.

---

## Pages and Functionality
The application is organized into several pages, each corresponding to the specific functionalities listed above. Navigation and user interactions are designed to be intuitive and responsive.

---

## How to Use
1. Clone the repository:
   ```bash
   git clone https://github.com/Fuguety/Scientific-Publications-Management-App.git

2. Ensure you have the following prerequisites installed:

- [DotNet](https://dotnet.microsoft.com/en-us/)
- [Visual Studio](https://visualstudio.microsoft.com) _(Recommended)_

3. Open terminal or Visual Studio and run:
``` bash
dotnet restore
dotnet build
dotnet run
```
- To run the app locally, ensure you have the necessary Xamarin.Forms development environment set up.

<br>

**Tools used**

![Xamarin](https://img.shields.io/badge/Xamarin-3199DC?style=for-the-badge&logo=xamarin&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![vstudio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)

<br>

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This project is licensed under the **[MIT License](https://opensource.org/license/mit/).**


---

Developed with ❤️ by the team.

_Claudia Rey Izquierdo_ <br>
_Lucas Barreiro_ <br>



