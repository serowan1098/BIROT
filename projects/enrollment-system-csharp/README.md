# Enrollment System

A **C# Windows Forms** desktop application developed as an academic group project — a school enrollment system with role-based access for **Admin**, **Student**, and **Faculty**.

> **Status:** Academic project, Windows desktop app. Data is currently held in memory only (no database).

---

## Overview

The application starts on a **WELCOME** screen with two paths: `SIGN UP` or `LOGIN`. After logging in, the user is routed to a dashboard based on their selected role, and each role sees a different set of screens.

- **Program entry point:** `Program.cs` → `Application.Run(new FRONT())`
- **Namespace:** `WindowsFormsApplication4`
- **Built with:** C# / Windows Forms / Visual Studio 2026

---

## Features

All of the following are implemented in the source.

### Authentication
- Welcome screen with **Sign Up** and **Log in** options
- **Sign up form:** first name, last name, username, email, password, confirm password
  - Validates that required fields are not empty
  - Validates that both passwords match
  - Show/hide password toggles
  - Email field is auto-normalized to an `@sjp2cd.edu.ph` suffix
- **Log in form:** user type selector, username, password
  - Routes to Admin, Student, or Faculty dashboard on success
  - Show/hide password toggle
  - Error message on invalid credentials
  - Link to the sign-up form

### Student
- **Personal Profile** screen with academic information (program, year level) and personal information (name, address, email, phone, date of birth)
- **Enrollment Application** form
  - Academic year, semester, student type, program
  - Personal details (first / middle / last name, age, gender, date of birth, address, email)
  - Submit confirmation screen
- Log out

### Faculty
- **Personal Profile** screen
- **Attendance** management — NEW / ADD / UPDATE / DELETE records
  - Columns: Student ID, Name, Subject, Date, Status
  - Empty-field validation
  - Student ID field restricted to digits
- **Grade Entry** — NEW / ADD / UPDATE / DELETE records
  - Columns: Select Subject, Date, Student ID, Name, Grade, Grading Period
  - Empty-field validation
- Log out

### Admin
- **Dashboard** with navigation
- **Add Students** — NEW / ADD / UPDATE / DELETE student records
  - 15 fields: first, middle, last name, age, gender, date of birth, address, email, contact number, civil status, nationality, region, emergency number, ID number, course
  - Numeric-only validation on age, contact, emergency number, and ID number
- **Add Teachers** — NEW / ADD / UPDATE / DELETE teacher records
  - 7 fields: full name, gender, address, department, email address, status, teacher ID number
- Log out

### Data grid behaviour
- All record tables are `ListView` controls in Details view with grid lines and full-row select
- Selecting a row populates the input fields and enables the **UPDATE** / **DELETE** buttons
- **NEW** clears and re-enables inputs for a fresh entry
- Fields are disabled by default so a record can't be edited without being started

---

## Technologies Used

| | |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.x, Windows Forms |
| IDE | Visual Studio 2026 |
| Controls | `Form`, `ListView`, `TextBox`, `ComboBox`, `DateTimePicker`, `CheckBox`, `PictureBox` |

---

## Screenshots

> [ ADD SCREENSHOTS — login, student dashboard, faculty attendance, admin student table ]

---

## How It Works

The app is a single Windows Forms project containing 15 forms.

```
FRONT (welcome)
  ├─→ SIGNUP ─→ LOGIN
  └─→ LOGIN
        ├─ Admin   → ADMINDB → Form11 (students) / Form12 (teachers)
        ├─ Student → STUDENTDB → Form5 (profile) / Form6 (enrollment)
        └─ Faculty → FACULTYDB → Form8 (profile) / Form9 (attendance) / Form10 (grades)
```

Navigation is handled by instantiating the next form and hiding the current one. Records are created as `ListViewItem` objects and added to the relevant `ListView`.

---

## How to Run

**Requirements:** Windows, Visual Studio 2019 or later (2026 recommended)

1. Clone the repository
2. Open `THEFINAL_ENROLLMENTSYSTEM.sln` in Visual Studio
3. Press **F5** or **Ctrl+F5** to run

**Note:** The solution was last saved by a newer Visual Studio version — if your VS prompts to upgrade or retarget, allow it and build again.

---

## What I Learned

- Building multi-form Windows applications and managing navigation between them
- `ListView` CRUD patterns — populate, select, update, delete
- Enabling and disabling controls to control the state of the UI
- Form validation with `string.IsNullOrWhiteSpace` and `KeyPress` input restriction
- Reading and understanding legacy `.Designer.cs` files
- Working in a group codebase I didn't write from scratch

---

## Future Improvements

These are the honest gaps in the current version:

- **Add a database.** Right now every record lives in a `ListView` and disappears when the app closes. This is the single biggest thing missing.
- **Replace hardcoded credentials.** Login compares typed values against literals inside `LOGIN.cs` instead of checking stored accounts.
- **Make sign-up actually create an account** that the login form can then use.
- **Rename the forms.** `Form5` through `Form12` describe nothing. They should be named `StudentProfileForm`, `AttendanceForm`, `GradeEntryForm`, and so on.
- **Move logic out of event handlers** into separate classes so the UI layer stays thin.
- Add real email and contact validation beyond the school domain suffix.

---

## Author

**Sir Christian Birot** — Fresh BSIT Graduate, Aspiring Software Engineer

GitHub: [serowan1098](https://github.com/serowan1098)
Email: [christian_birot@sjp2cd.edu.ph](mailto:christian_birot@sjp2cd.edu.ph)
