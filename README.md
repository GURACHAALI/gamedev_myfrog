# 🐸 Frog Shooter 2D Game

### 🎮 Overview

The Frog Shooter is a 2D mini-game developed in **Unity** where the player controls a shooter that fires bullets at incoming frogs. The goal is to earn points by hitting enemies before they pass the player. The project was built entirely from scratch, featuring custom-designed sprites, responsive movement, collision handling, and sound feedback.

---

### 🧠 Game Features

* **Player Movement:** Smooth vertical control using `Rigidbody2D` and `PlayerMovement.cs`.
* **Shooting Mechanic:** Bullets fire from a defined `FirePoint` with logic handled by `PlayerShooting.cs`.
* **Enemy AI:** Frogs spawn randomly and move toward the player using `BallSpawner.cs` and `BallMovement.cs`.
* **Scoring System:** Each successful hit increases the score, displayed in real time through Unity’s UI system.
* **Game Manager:** Controls game-over conditions, pauses gameplay, and allows restarting with the “R” key.
* **Audio Integration:** Shooting triggers a firing sound for more immersive feedback.

---

### 🧰 Tools & Technologies

* **Unity Engine**
* **C# Scripting**
* **Piskel** (for sprite design)
* **Unity UI System**
* **Audio Source Component**

---

### 🏗️ Project Structure

```
Assets/
 ├── Scripts/
 │    ├── PlayerMovement.cs
 │    ├── PlayerShooting.cs
 │    ├── BallMovement.cs
 │    ├── BallSpawner.cs
 │    └── GameManager.cs
 ├── Prefabs/
 ├── Sprites/
 ├── Audio/
 └── Scenes/
```

---

### 🚀 How to Play

1. Run the game in Unity or as a built build.
2. Move the player vertically using the arrow keys or `W/S`.
3. Shoot bullets using the spacebar.
4. Hit as many frogs as possible before one passes the player.
5. Press **R** to restart after game over.

---

### 📈 Learning Outcome

This project demonstrates core Unity development concepts—physics, scripting, prefab management, UI integration, and audio feedback—forming a solid foundation for more advanced game projects.

---

