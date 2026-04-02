**KCS 258: Programming with Visual Basic Dot Net**.
***
# KCS 258: VB.NET Advanced Programming Projects
### KAAF University | Instructor: Mr. Bernard A. Buckman
This repository contains a suite of applications developed to demonstrate mastery of
**fundamental programming concepts** using the **.NET framework**. The projects
transition from structured console-based logic to sophisticated, event-driven Graphical User
Interfaces (GUIs).
## Applications Overview
### 1. KAAF Academic Performance Analyzer (Console)
A robust command-line tool designed for batch processing student data and performing
complex academic analytics.
* **Logical Architecture:** Uses a **Counter-Controlled loop** (`For...Next`) to manage
multiple student entries and a **Pretest loop** (`Do While`) for input validation.
* **Data Analysis:** Implements **Accumulators** to calculate class averages and the
**Select Case** structure to categorize grades based on specific ranges (e.g., 80-100 for &#39;A&#39;).
* **Type Integrity:** Employs **Type Conversion functions** (`CDec`, `CInt`) to ensure data
precision during user input processing.
### 2. Smart Admissions &amp; Finance Portal (Windows Forms)
A professional-grade GUI application built using the **Rapid Application Development
(RAD)** strategy, focusing on university branding and student financial management.
* **User Interface Design:**
* **Branding:** Features a **PictureBox** utilizing `StretchImage` mode to accommodate
the high-resolution KAAF logo (2274px x 1113px).
* **Layout:** Uses **GroupBox** containers to organize &quot;Personal Information&quot; and
&quot;Residency Status,&quot; creating an intuitive flow.
* **Controls:** Integrated **ComboBox** for course selection, **CheckBoxes** for
optional fees, and **RadioButtons** for mutually exclusive residency choices.
* **Logic &amp; Validation:**
* **Event-Driven Programming:** Operations are triggered by the `Click` event of the
processing button.
* **Robustness:** Uses **Short-circuiting logical operators** (`AndAlso`, `OrElse`) and
`TryParse` methods to prevent runtime errors during financial calculations.
## ��️ Technical Implementation Standards
To ensure code quality and maintainability, these projects adhere to industry-standard
development principles taught in the course:
* **Ground Rules:** Mandatory use of `Option Explicit On` to force variable declaration and
`Option Strict On` to prevent implicit data loss during conversions.

* **Precision Math:** All financial calculations utilize the **Decimal data type** with the `D`
literal character to ensure 128-bit precision for currency.
* **Assignment Abbreviation:** Uses efficient operators like `+=` and `-=` for updating
counters and totals.
* **UI Aesthetic:** Controls are styled using gainesboro and white backgrounds with
maroon and gold accents to align with university branding.
Environment &amp; Setup
* **Language:** Visual Basic .NET
* **Framework:** .NET 10
* **IDE:** Visual Studio 2026
* **Execution:**
1. Open the `.sln` file in Visual Studio.
2. Press **Ctrl+F5** to run the project without debugging.# KayasaVbasicMidSemProject2
