# Number System Converter (Visual Basic .NET)

A **Visual Basic .NET Windows Forms** application developed as a group midterm project. It converts numbers between the **binary**, **decimal**, **octal**, and **hexadecimal** number systems.

> **Status:** Academic midterm project. This is a **Visual Basic .NET** project and is separate from any C++ calculator work.

---

## Overview

A main menu (`Form1`) opens one of four converter forms. Each form accepts a value in its own number system and displays the equivalent values in the other three systems.

| Form | Input | Outputs |
|---|---|---|
| `BINA` | Binary | Decimal, Octal, Hexadecimal |
| `DEC` | Decimal | Binary, Octal, Hexadecimal |
| `OCT` | Octal | Decimal, Binary, Hexadecimal |
| `HEXA` | Hexadecimal | Decimal, Binary, Octal |

---

## Features

- Main menu navigation to all four converter forms
- Conversion between all four number systems
- Input validation per number system with error dialogs
  - **Binary:** rejects any character other than `0` or `1`
  - **Hexadecimal:** accepts `0-9`, `A-F`, and `a-f`; rejects everything else
  - **Decimal / Octal:** validated with `Integer.TryParse`
- Clear button to reset all four text boxes
- Close button on each form

---

## Technologies Used

| | |
|---|---|
| Language | Visual Basic .NET |
| Framework | .NET Framework 4.5, Windows Forms |
| IDE | Visual Studio |
| Core API | `Convert.ToInt32(string, base)`, `Convert.ToString(value, base)` |

---

## Screenshots

> [ ADD SCREENSHOTS — main menu, binary converter, hexadecimal converter ]

---

## How It Works

Conversion is delegated to the .NET `Convert` class, which handles arbitrary bases rather than hand-rolled math.

**Binary input** (`BINA.vb`):
```vb
If Not IsBinary(binaryNumber) Then
    MessageBox.Show("Invalid binary number...")
    Return
End If

Dim decimalNumber As Integer = Convert.ToInt32(binaryNumber, 2)
Dim octalNumber As String = Convert.ToString(decimalNumber, 8)
Dim hexadecimalNumber As String = Convert.ToString(decimalNumber, 16)
```

The same pattern repeats in the other three forms: validate, convert to decimal as the intermediate step, then render the remaining bases from it.

Validation uses a small helper per form:
```vb
Private Function IsBinary(binaryString As String) As Boolean
    For Each c As Char In binaryString
        If c <> "0" AndAlso c <> "1" Then Return False
    Next
    Return True
End Function
```

---

## How to Run

**Requirements:** Windows, Visual Studio

1. Clone the repository
2. Open `Midterm_Calc_grp3fins.vbproj` in Visual Studio
3. Press **F5** to run

---

## What I Learned

- Windows Forms development in Visual Basic .NET
- How number bases work, and using `Convert` instead of manual division/remainder loops
- Input validation written per data type, and why validating *before* converting prevents crashes
- Using an intermediate decimal value to reduce each conversion to one step
- Group project workflow — merging forms from multiple members into one solution

---

## Future Improvements

- **Fix the event handler binding in `BINA.vb`.** `Button4_Click` is wired to `Handles Button2.Click`, so the clear button is bound to the wrong control.
- **Remove the unused `ValidBinary` function.** It is dead code next to the working `IsBinary`.
- **Remove the empty `TextChanged` handlers.** Several are empty stubs.
- **Remove the leftover debug strings** in two error messages ("Pogi kon2x", "Pogi japon kon2x").
- Use `Long` instead of `Integer` — `Integer` caps at ~2.1 billion, so valid binary inputs silently fail.
- Accept lowercase hex without needing the extra branch (already partly handled).
- Rename the forms to meaningful names instead of `BINA`, `DEC`, `OCT`, `HEXA`.
- Show the current base as a label on each form.

---

## Author

**Sir Christian Birot** — Fresh BSIT Graduate, Aspiring Software Engineer

GitHub: [serowan1098](https://github.com/serowan1098)
Email: [christian_birot@sjp2cd.edu.ph](mailto:christian_birot@sjp2cd.edu.ph)
