<div align="center">

<img src="20243076.jpg" alt="Sir Christian Birot" width="180" style="border-radius:50%;">

# Sir Christian Birot

**Fresh BSIT Graduate • Aspiring Software Engineer**

[![GitHub](https://img.shields.io/badge/GitHub-serowan1098-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/serowan1098)
[![Email](https://img.shields.io/badge/Email-christian__birot%40sjp2cd.edu.ph-2b2b2b?style=for-the-badge&logo=gmail&logoColor=white)](mailto:christian_birot@sjp2cd.edu.ph)
[![Figma](https://img.shields.io/badge/Figma-LookIT%20Prototype-ff3d6e?style=for-the-badge&logo=figma&logoColor=white)](https://www.figma.com/design/4FINPzTXyR00MqE3QrRefW/LookIT-Mobile-Prototype?node-id=0-1&t=USeMAP9YYHW7QzOb-1)

</div>

---

Hi — I'm a fresh Information Technology graduate from the Philippines, working toward becoming a Software Engineer.

Everything on this profile came out of school projects and my own practice: a **C# Windows Forms** enrollment system, a **Visual Basic .NET** number system converter, a **Digital Finance Buddy** budget tracker in vanilla HTML/CSS/JavaScript, a **Java** OOP application, a **C++** calculator, and **LookIT**, a mobile UI/UX concept for a home-security app.

I don't have production experience yet, and I won't pretend otherwise. What I do have is the habit of finishing things, and then going back to make them better.

---

## 🧑‍💻 About Me

- 🎓 **Education:** Bachelor of Science in Information Technology (BSIT)
- 🎯 **Goal:** Software Engineer, built through consistent practical work
- 🌱 **Approach:** Learn it, build it, get it wrong, fix it, try again
- 💭 **Mindset:** Perseverance + Continuous Learning
- 📫 **Email:** christian_birot@sjp2cd.edu.ph

I'm still early in my career. What I've built so far is mostly academic, and some of that code is rough — I keep it visible on purpose, because the gap between my first version of a project and the current one is part of the record.

---

## 🛠️ Technologies I've Worked With

Tools I have hands-on experience with from school and personal projects. I'm still building depth in each.

### Languages

![C++](https://img.shields.io/badge/C++-00599C?style=for-the-badge&logo=c%2B%2B&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Java](https://img.shields.io/badge/Java-ED8B00?style=for-the-badge&logo=openjdk&logoColor=white)
![PHP](https://img.shields.io/badge/PHP-777BB4?style=for-the-badge&logo=php&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=white)

### Tools & Platforms

![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)
![VS Code](https://img.shields.io/badge/VS%20Code-007ACC?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)
![Figma](https://img.shields.io/badge/Figma-F24E1E?style=for-the-badge&logo=figma&logoColor=white)
![Canva](https://img.shields.io/badge/Canva-00C4CC?style=for-the-badge&logo=canva&logoColor=white)
![Microsoft Office](https://img.shields.io/badge/Microsoft%20Office-D83B01?style=for-the-badge&logo=microsoft-office&logoColor=white)

---

## 📂 Projects

### 1. Enrollment System — C# / Windows Forms

A role-based school enrollment desktop application built in **C#**, developed as an academic group project. Three user types — **Admin**, **Student**, and **Faculty** — each get their own dashboard and screens.

**Verified from source:**
- Welcome screen → **Sign up** / **Log in**, with role selection and a show/hide password toggle
- **Student:** personal profile, and an enrollment application form (academic year, semester, student type, program, personal details) with a submit confirmation
- **Faculty:** personal profile, **Attendance** and **Grade Entry** — both with NEW / ADD / UPDATE / DELETE record grids
- **Admin:** dashboard, plus **Add Students** (15-field record table) and **Add Teachers** (7-field record table), both with full CRUD
- Record tables are `ListView` controls that populate the input fields on row select and manage button states

`C#` `Windows Forms` `Visual Studio` `ListView` `CRUD`

| Repository | Demo | Screenshots |
|---|---|---|
| [ ADD GITHUB REPOSITORY ] | [ ADD DEMO ] | [ ADD SCREENSHOTS ] |

> **Honest limitation:** data lives in memory only — records disappear when the app closes, and login credentials are hardcoded in the form code rather than checked against a database. Adding persistence is the next thing to build.

---

### 2. Digital Finance Buddy — HTML / CSS / JavaScript

A browser-based **budget and expense tracker**. Set a total budget, add expenses, and the remaining balance updates instantly. No framework, no build step.

**Verified from source:**
- Set and display a total budget
- Add, **edit**, and **delete** expense entries
- Live calculation of total expenses and remaining balance
- Dynamic expense list built with DOM manipulation and per-row action buttons
- Input validation with show/hide error states
- Responsive two-column layout that collapses on smaller screens

`HTML5` `CSS3` `JavaScript` `DOM Manipulation` `Event Handling` `Responsive Design`

| Repository | Live Demo | Screenshots |
|---|---|---|
| [ ADD GITHUB REPOSITORY ] | [ ADD LIVE DEMO ] | [ ADD SCREENSHOTS ] |

> This is a front-end tracker, not a full financial system. There's no database and no back end.

---

### 3. Number System Converter — Visual Basic .NET

A **Windows Forms** application that converts values between **binary**, **decimal**, **octal**, and **hexadecimal**. Main menu opens four dedicated converter forms; each validates its input and shows the value in the other three bases.

**Verified from source:**
- Conversion across all four number systems via `Convert.ToInt32` / `Convert.ToString` with a base argument
- Per-format input validation — binary restricted to `0`/`1`, hex to `0-9` and `A-F`, decimal and octal via `Integer.TryParse`
- Clear and close controls on every form

`Visual Basic .NET` `Windows Forms` `Number Systems`

| Repository | Screenshots |
|---|---|
| [ ADD GITHUB REPOSITORY ] | [ ADD SCREENSHOTS ] |

> **Note:** this is a **Visual Basic .NET** project and is separate from the C++ calculator below. The two are different projects and are not merged.

---

### 4. TAGAY SHOP OOP — Java

A **Java** academic project built around **Object-Oriented Programming** — modelling a shop system using classes, objects, and methods.

`Java` `OOP` `Academic Project`

| Repository | Documentation | Screenshots |
|---|---|---|
| [ ADD GITHUB REPOSITORY ] | [TAGAY SHOP OOP documentation](https://www.facebook.com/share/v/18Q2rcyDLs/) | [ ADD SCREENSHOTS ] |

> **[ NEEDS VERIFICATION ]** — the Java source isn't in my repository yet, so the exact features and which OOP concepts are actually demonstrated (encapsulation, inheritance, polymorphism, abstraction) are unconfirmed. I'd rather say so than describe what I haven't read.

---

### 5. LookIT — UI/UX Design / Figma Prototype

A **mobile UI/UX concept** for a home security app that works with an existing camera and speaker setup.

Most security cameras are something you watch. LookIT proposes the opposite: a two-way voice interaction point, so you can actually *talk* to a visitor or delivery person when you're not home — with AI-assisted voice interaction handling the conversation when you can't answer.

**Focus:** mobile interaction design • home security user flows • voice interaction and user controls • visitor/delivery interaction • AI-assisted voice interaction concept • product concept development

`Figma` `UI/UX Design` `Mobile Interface` `Prototyping` `Product Concept`

### 🔗 [VIEW FIGMA PROTOTYPE](https://www.figma.com/design/4FINPzTXyR00MqE3QrRefW/LookIT-Mobile-Prototype?node-id=0-1&t=USeMAP9YYHW7QzOb-1)

> This is a design prototype and concept, not a released application. Nothing here is implemented or deployed.

---

### 6. Binary Calculator — C++

My **C++** calculator project, built as a course requirement.

`C++` `Calculator` `Academic Project`

| Repository | Demo | Screenshots |
|---|---|---|
| [ ADD GITHUB REPOSITORY ] | [ ADD DEMO ] | [ ADD SCREENSHOTS ] |

> **[ VERIFY FROM C++ SOURCE CODE ]** — the C++ source isn't in my repository yet, so supported operations and concepts demonstrated are unconfirmed. I also want to be explicit that the Visual Basic .NET converter above is **not** evidence for this project. They're separate.

---

## 🌱 Currently Learning

Building on the fundamentals, one at a time:

- **Programming fundamentals** — logic, functions, data structures, and reading my own old code critically
- **C++ and C#** — moving past course exercises toward projects I design myself
- **Java and OOP** — applying encapsulation, inheritance, and polymorphism in designs I choose
- **Web development** — HTML, CSS, JavaScript, and starting PHP
- **Software engineering concepts** — project structure, separation of concerns, and maintainable code
- **Git/GitHub workflow** — meaningful commits, proper READMEs, and documenting work so it's actually reviewable
- **Version control discipline** — branches, and keeping a clean history

I'm not claiming mastery of any of these. This is the current list, and it changes as I progress.

---

## 🔥 Developer Mindset — Perseverance + Continuous Learning

Software development, to me, is a cycle: **learn → build → get it wrong → fix it → try again.**

Perseverance means finishing a project even when the parts I haven't learned yet make it hard — then coming back to rewrite it properly. Continuous learning means the version I finished last week was never the best version I'll write.

That's why this profile is a work in progress rather than a finished product. It's honest about where I am, and it's moving.

---

## 📬 Contact

| | |
|---|---|
| **GitHub** | [serowan1098](https://github.com/serowan1098) |
| **Email** | [christian_birot@sjp2cd.edu.ph](mailto:christian_birot@sjp2cd.edu.ph) |
| **Figma** | [LookIT Prototype](https://www.figma.com/design/4FINPzTXyR00MqE3QrRefW/LookIT-Mobile-Prototype?node-id=0-1&t=USeMAP9YYHW7QzOb-1) |
| **TAGAY SHOP OOP** | [Documentation / certificates](https://www.facebook.com/share/v/18Q2rcyDLs/) |

Open to entry-level Software Engineer roles, internships, and junior developer opportunities.

---

> **Note for recruiters:** any link marked `[ ADD ... ]` is material I haven't published yet. I'd rather leave a visible gap than fill it with something inaccurate. Happy to walk you through any project here in detail — including the parts that need work.
