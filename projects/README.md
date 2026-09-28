# Repositories

Project source material and READMEs, organized for upload to GitHub.

| Folder | Language | Tech | Status |
|---|---|---|---|
| `enrollment-system-csharp/` | C# | Windows Forms | ✅ Source verified — **needs upload** |
| `digital-finance-buddy/` | HTML / CSS / JS | Vanilla front-end | ✅ Source verified — **needs upload** |
| `number-system-converter-vb/` | Visual Basic .NET | Windows Forms | ✅ Source verified — **needs upload** |
| `lookit-uiux/` | — | Figma | ✅ Prototype link live — screenshots needed |
| `tagay-shop-oop/` | Java | OOP | ⚠️ **Source not provided** — README is a placeholder |
| `binary-calculator-cpp/` | C++ | Console | ⚠️ **Source not provided** — README is a placeholder |

The source folders for the first two projects also still live in the parent `BIROT` folder
(`THEFINAL_ENROLLMENTSYSTEM/` and the web app files). Copy them into their matching
folder here before uploading.

---

## Upload order

```bash
# 1. Profile repo — this README plus your photo
cd serowan1098-profile
git init && git add . && git commit -m "Add GitHub profile README"
gh repo create serowan1098 --public --push

# 2..4. One repo per project
cd ../projects/enrollment-system-csharp
git init && git add . && git commit -m "Initial commit: C# enrollment system"
gh repo create enrollment-system-csharp --public --push

# ...same pattern for:
#   digital-finance-buddy
#   number-system-converter-vb
#   lookit-uiux
```

Add a `.gitignore` before committing Visual Studio projects:

**C# / Visual Basic .NET**
```gitignore
bin/
obj/
*.user
*.suo
.vs/
```

---

## Still needed

- [ ] Upload source for `tagay-shop-oop` (Java)
- [ ] Upload source for `binary-calculator-cpp` (C++)
- [ ] Screenshots for every project
- [ ] Live demo URL for `digital-finance-buddy`
- [ ] GitHub repository URLs to paste back into the profile README
