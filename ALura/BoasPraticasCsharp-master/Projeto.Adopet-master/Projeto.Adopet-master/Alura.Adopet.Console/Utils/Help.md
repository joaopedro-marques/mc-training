# Understanding the `Help` Class (Teenager Friendly)

## What is this file about?
The **Help** class is part of a small command‑line app called **Adopet**.  It’s the part that shows you a *cheat‑sheet* when you type `adopet help` in the terminal.

## Main pieces of the code

### 1. The `docs` dictionary
```csharp
private Dictionary<string, DocComando> docs;
```
* **Dictionary** – Think of it as a phone book where the *key* is the command name (like `import`) and the *value* is a `DocComando` object that holds the description of that command.

### 2. Building the dictionary in the constructor
```csharp
public Help()
{
    docs = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.GetCustomAttributes<DocComando>().Any())
        .Select(t => t.GetCustomAttributes<DocComando>().First())
        .ToDictionary(d => d.Instrucao, d => d);
}
```
* **Assembly.GetExecutingAssembly().GetTypes()** – grabs every class in the current program.
* **Where … Any()** – keeps only the classes that have the **`[DocComando]`** attribute (those are the commands we care about).
* **Select … First()** – pulls out the actual `DocComando` attribute from each class.
* **ToDictionary** – turns the list of attributes into a dictionary where the key is the command name (`Instrucao`) and the value is the whole attribute.

### 3. Showing the help text
```csharp
public void ExibeDocumentacao(string[] parametros)
{
    if (parametros.Length == 1) { /* show all commands */ }
    else if (parametros.Length == 2) { /* show one specific command */ }
}
```
* If you just type `adopet help`, the method prints a friendly list of all commands.
* If you type `adopet help import`, it prints the description for **only** the `import` command.

## Why the code needed fixing
The original version tried to assign the result of `GetTypes()` (an array of **types**) directly to a `Dictionary`. That’s like trying to put a whole list of phone numbers into a single phone‑book entry – it just doesn’t work. The fix:
1. Removed a stray `]` after `GetTypes()`.
2. Picked a single `DocComando` attribute from each type with `.First()`.
3. Built the dictionary with both a **key** (`Instrucao`) and a **value** (`DocComando`).

## TL;DR (Too Long; Didn’t Read)
* The **Help** class gathers all command‑info objects (`DocComando`) at startup.
* It stores them in a dictionary for fast lookup.
* When you ask for help, it prints either the whole list or a single command’s description.
* The recent fix makes the code  compile and actually work.

---

*Happy coding!*

