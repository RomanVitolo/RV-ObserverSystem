# RV-ObserverSystem

## Overview

**RV-ObserverSystem** is a Unity package that provides a **customizable Observer Pattern utility**. It helps Unity developers structure their projects efficiently by implementing the Observer design pattern to manage event-driven systems.

By using RV-ObserverSystem, you can:

- Implement **event-driven architecture** with the **Observer Pattern**.
- Reduce boilerplate work when setting up new **Unity projects or features**.
- Ensure a **consistent and clean project structure** for modular game development.

## Features

- **Observer Pattern Support**: Set up Subject-Observer communication with structured scripts.
- **Decoupled Event System**: Reduce dependencies between game components.
- **Multiple File Type Support**: Easily create C# scripts, Unity scenes, JSON files, materials, and more.
- **No External Dependencies**: Works with pure C# and Unity’s built-in features.

## Installation

### 1. Download or Clone the Repository

```sh
git clone https://github.com/RomanVitolo/RV-ObserverSystem.git
```

### 2. Import into Unity

- Move the `RV - Observer Package` folder into your Unity project's `Assets` directory.
- Ensure the package is inside an `Editor` folder (if not already structured that way).
  
## Importing via Unity Package Manager (UPM)

You can also import **RV-ObserverSystem** using the Unity Package Manager (UPM):

1. Open **Unity** and navigate to **Window > Package Manager**.
2. Click on the **+** button and select **Add package from git URL**.
3. Enter the following URL and click **Add**:
   ```
   https://github.com/RomanVitolo/RV-ObserverSystem.git#upm
   ```
4. The package will be installed and available in the **Packages** section of the Unity Editor.

### Importing Samples

To access the provided **Samples**, follow these steps:

1. In Unity, go to **Window > Package Manager**.
2. Locate **RV-ObserverSystem** in the package list.
3. Expand the package details and find the **Samples** section.
4. Click **Import** to add the sample assets to your Unity project.

### Sample Information

The provided samples demonstrate how to effectively use the **Observer Pattern** in Unity. These examples include:

- **Basic Observer Pattern Implementation**: A simple subject-observer setup using C# events.
- **Game Event System**: Demonstrates using ScriptableObject-based events for decoupled communication.
- **UI Event Handling**: Shows how UI elements can subscribe to game state changes dynamically.
- **Advanced Observer Setup**: Implements multiple subjects and observers in a modular system.

These samples help you quickly understand how to integrate the **RV-ObserverSystem** into your own projects.

## Usage

### 1. Implement Observer Pattern

- Use the provided `Subjects` and `Observers` scripts to set up event-driven communication.
- Implement C# events, UnityEvents, or ScriptableObject-based event management.



## Dependencies

- **Unity Engine (6000.0)** – But you can modify the project and downgrade it to previous versions.
- **No third-party libraries** – Uses Unity’s built-in APIs.

## License

**MIT License** – You are free to use, modify, and distribute this package. See `LICENSE` for details.

## Contribution & Contact

- Developed by **Roman Vitolo**
- Issues & feedback: [GitHub Issues](https://github.com/RomanVitolo/RV-ObserverSystem/issues)
- Contributions are welcome via pull requests!

---

Start using **RV-ObserverSystem** today to **streamline your Unity development** with structured event-driven systems and the **Observer Pattern**! 🚀

