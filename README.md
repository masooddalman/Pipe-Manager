# 🔧 Pipe-Manager

A lightweight Unity Editor tool that helps Level Designers build complex pipe networks with just a few clicks.

![Unity](https://img.shields.io/badge/Unity-2020.3%2B-black?logo=unity)
![License](https://img.shields.io/badge/License-Unlicense-blue)

---

## ✨ Features

- **Quick Pipe Building** — Build complex pipe networks by clicking buttons in the Inspector
- **Automatic Connections** — Pipes automatically connect end-to-end, positioned and rotated correctly
- **Extensible Prefab System** — Add your own pipe prefabs and buttons appear automatically
- **Sample Assets Included** — Ready-to-use pipe models and textures from [DJMaesen](https://sketchfab.com/3d-models/modular-pipes-f43677d2d1014669b7c7a9f220d46eb3)

---

## 📦 Installation

1. Download the latest `PipeManager.unitypackage` from the [Releases](../../releases) section
2. In Unity, go to `Assets > Import Package > Custom Package...`
3. Select the downloaded package and import all assets

---

## 🚀 Quick Start

1. Create a new Pipe Manager: `Assets > Create > New Pipe`
2. Select the `PipeManager` object in the Hierarchy
3. Click any button in the Inspector to add pipe segments

| Prefab | Description |
|--------|-------------|
| `pipeStraight` | Straight pipe segment |
| `pipeBend` | 90° bend (small) |
| `pipeBentBig` | 90° bend (large radius) |
| `pipeCurve` | Curved pipe segment |
| `pipeSegment` | Basic connector segment |
| `pipeT` | T-junction (3-way split) |
| `pipeU` | U-turn pipe |

---

## 📁 Project Structure

```
Assets/pipeManager/
├── Editor/
│   └── PipeManagerEditor.cs   # Custom Inspector UI
├── PipeManager.cs             # Main component
├── Pipe.cs                    # Pipe segment component
└── pipeAssets/
    ├── model/                 # 3D models & textures
    └── prefabs/               # Pipe prefabs
```

---

## 🛠️ Customization

### Adding Custom Pipe Prefabs

1. Create your pipe model with **start** and **end** transform markers
2. Add the `Pipe` component to your prefab
3. Assign the `start` and `end` transforms and set `ZRotation` if needed
4. Save the prefab to `Assets/pipeManager/pipeAssets/prefabs/`
5. The new pipe button will appear automatically in the Inspector!

> **Tip:** Watch the video tutorial before creating custom prefabs to understand the transform setup.

---

## 📜 License

This project is released under the [Unlicense](LICENSE) — free to use for any purpose, commercial or personal.

### Asset Credits

Pipe models and textures by [DJMaesen](https://sketchfab.com/3d-models/modular-pipes-f43677d2d1014669b7c7a9f220d46eb3) (Belgium)

---

## 🤝 Contributing

Contributions are welcome! Feel free to submit issues and pull requests.
