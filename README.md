# Breast Cancer Self-Examination AR App (Unity)

## Overview

This project is a **Unity-based application** designed to guide users through a **breast self-examination process** using an interactive user interface and AR-ready design.
The goal of the application is to help users understand the steps involved in performing a **visual breast examination** and later integrate **physical examination guidance using AR technologies**.

Currently, the application implements the **Visual Evaluation phase**, where users answer guided questions while observing the provided anatomical visual model.

---

## Features Implemented

### 1. Home Screen

* Introductory screen for the application
* Displays:

  * Application title
  * Short description
  * Language selection option
* Users can start the visual examination by selecting **English**.

---

### 2. Visual Evaluation Module

The Visual Evaluation module guides the user through a sequence of questions related to visible breast changes.

#### Implemented Questions

1. Are both sides evenly shaped without swelling?
2. Check for dimpling, puckering, or bulging.
3. Has either nipple changed position?
4. Do you notice a newly inverted nipple?
5. Look for redness, rash, swelling, or discharge.

Each question provides **three response options**:

* Yes
* No / Specific condition
* Not Sure

---

### 3. Progress Indicator

* A **heart icon progress indicator** at the top of the screen tracks the user's progress through the questions.
* The filled heart moves forward as the user proceeds to the next question.

---

### 4. Completion Screen

After answering all questions, the system displays:

```
Visual check completed.
```

The interface then shows two options:

* **Physical Check** (next phase of examination)
* **View Results**

These features are part of the next development phase.

---

## Project Structure

```
Assets
 ├── Scenes
 ├── UI
 │    ├── HomeScreen
 │    └── VisualCheckScreen
 ├── Scripts
 │    └── VisualCheckManager.cs
 ├── TextMesh Pro
 └── Settings

Packages
ProjectSettings
```

---

## Technologies Used

* **Unity 2022**
* **C#**
* **TextMeshPro**
* **Unity UI System**
* **Figma UI Assets (PNG exports)**

---

## Current Development Status

✔ Home screen implemented
✔ Visual evaluation question flow implemented
✔ Progress indicator implemented
✔ Completion screen implemented

 Next steps:

* Implement **Physical Examination Module**
* Add **AR guidance using Unity AR Foundation**
* Implement **result summary and recommendations**
* Improve UI animations and transitions

---

## Purpose

This project is developed as part of a **VR/AR learning module** to demonstrate how interactive applications can assist in **health awareness and self-screening guidance**.

---

## Author

Reshma Sri Chennupati
