# Digital Finance Buddy

A browser-based **budget and expense tracker** built with plain **HTML, CSS, and JavaScript** — no framework, no build step, no dependencies. Set a total budget, add expenses, and watch the remaining balance update instantly.

---

## Overview

A front-end budgeting application. It has three parts: a **budget** panel where you set your total, an **expenses** panel where you add costs, and an **output** bar showing total budget, total expenses, and remaining balance. Every expense you add is also appended to a dynamic list where you can edit or delete it.

---

## Features

- Set a total budget
- Display total budget, total expenses, and remaining balance
- Add expenses with a title and cost
- Edit an existing expense — the entry is removed, its values are loaded back into the inputs, and the balance is recalculated
- Delete expenses with an immediate balance recalculation
- Dynamic expense list built with DOM manipulation
- Input validation on the budget and expense forms

### Validation behaviour
- Budget: rejects empty values and values below zero
- Expenses: rejects submission if the title or cost is empty
- Errors are shown by toggling a `.hide` class, no inline rewriting of the DOM text

---

## Technologies Used

| | |
|---|---|
| Markup | HTML5 |
| Styling | CSS3 — custom properties, flexbox, media queries |
| Logic | Vanilla JavaScript (ES6) |
| Icons | Font Awesome 6.1.1 (CDN) |
| Fonts | Poppins — 400 / 500 (Google Fonts CDN) |

---

## Screenshots

> [ ADD SCREENSHOTS — main view, expense list populated ]

---

## How It Works

### Files

```
index.html   Application structure: budget panel, expenses panel, output bar, list container
style.css    Layout, cards, buttons, typography, responsive behaviour
script.js    All application logic
```

### Logic flow

1. **Set budget** — reads the budget input, rejects empty or negative values, then writes the budget to the output and computes `budget − totalExpenses` for the balance.
2. **Add expense** — validates the title and cost, adds the cost to the running total, recomputes the balance, and calls `listCreator()` to append a new row.
3. **listCreator(expenseName, expenseValue)** — builds a `div.sublist-content` containing the product name, the amount, an edit button, and a delete button, then appends it to the list.
4. **modifyElement(element, edit)** — the shared handler behind both edit and delete. It reverses the expense's effect on the balance (`balance + amount`, `expenses − amount`), then removes the row. When `edit` is `true` it first copies the row's values into the input fields and calls `disableButtons(true)` so other rows can't be edited mid-edit.
5. **disableButtons(bool)** — enables or disables every `.edit` button in the list.

### Design decisions
- All DOM elements are grabbed once at the top of the file into variables, rather than queried repeatedly inside handlers.
- Totals live in the output elements and are read back with `.innerText`, then converted with `parseInt` for arithmetic.
- The balance recalculation logic is shared between add, edit, and delete, so there is a single place where totals change.

---

## How to Run

No build, no install. Either method works:

**Option 1 — open directly**
Open `index.html` in any modern browser.

**Option 2 — local server** (recommended, avoids browser file restrictions)
```bash
python -m http.server 8000
```
Then visit `http://localhost:8000`.

**Live Demo:** [ ADD LIVE DEMO LINK ]

---

## What I Learned

- Semantic HTML structure and how a page is broken into independent components
- CSS layout with CSS Grid for the two-column panel and Flexbox for the output bar and list rows
- Responsive design with media queries and `rem`-based sizing
- DOM manipulation — creating elements, setting classes, appending, and removing nodes
- Event handling with `addEventListener` and `onclick`
- Input validation and using CSS classes to show and hide error messages
- The value of extracting repeated logic (`disableButtons`, `modifyElement`) instead of copying it

---

## Future Improvements

- **Persist data.** State is lost on refresh. `localStorage` would fix this in a few lines.
- **Tighten the validation.** `parseInt` silently turns bad input into `NaN` — validate with `Number.isNaN` and show a real message.
- **Prevent overspending.** Allow a warning when the balance goes negative instead of showing a negative number silently.
- **Add categories** for expenses with a filter.
- Add a spending summary or simple chart.
- Replace `innerHTML` with `textContent` when inserting user input.

---

## Author

**Sir Christian Birot** — Fresh BSIT Graduate, Aspiring Software Engineer

GitHub: [serowan1098](https://github.com/serowan1098)
Email: [christian_birot@sjp2cd.edu.ph](mailto:christian_birot@sjp2cd.edu.ph)
