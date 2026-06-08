# ARcpr — AR 心肺復甦術急救訓練應用程式

> 以擴增實境（AR）引導使用者學習正確的 CPR 與 AED 操作流程

---

## 專案簡介

ARcpr 是一款以 **Unity + Vuforia** 開發的行動應用程式，透過 AR 技術將 3D 人體模型疊加在真實環境中，一步一步引導使用者完成心肺復甦術（CPR）的標準急救程序，並整合 AED 除顫器使用教學與最近 AED 地點查詢。

---

## 功能特色

- **AR 場景引導** — 22 個場景依序引導完整 CPR 流程（確認意識 → 呼叫 119 → 開放呼吸道 → 胸部按壓 → AED 使用）
- **3D 動作示範** — 拍肩、抬下巴、聽呼吸等動作以 FBX 動畫呈現
- **Virtual Button 互動** — 用手指遮擋 AR 標記觸發按鈕，免碰螢幕操作
- **AED 地點查詢** — 整合地圖顯示附近 AED 位置
- **影片示範** — 內嵌示範影片，強化胸部按壓節奏學習
- **語音指令** — 支援 VoiceCommander 語音控制
- **GPS 定位** — 定位使用者位置並回傳後端

---

## 技術架構

| 技術 | 版本 / 說明 |
|------|------------|
| Unity | 遊戲引擎、UI、場景管理 |
| Vuforia | AR 辨識、Virtual Button |
| C# | 全部邏輯腳本 |
| FBX / Blender | 人體 3D 模型與動畫 |
| VideoPlayer | Unity 內建影片播放 |
| VoiceCommander | 語音指令套件 |
| UnityWebRequest | GPS 座標回傳後端 |

---

## 專案結構

```
ARcpr/
├── 3D建模/                    # Blender / FBX 原始模型
│   ├── AED/
│   ├── 人材質/
│   ├── 動畫/
│   ├── 貼片材質/
│   ├── 人體和貼片.fbx         # 主角人體 + AED 電極貼片
│   ├── 抬下巴.fbx / L / R     # 開放呼吸道動作
│   ├── 拍肩膀.fbx             # 確認意識動作
│   └── 聽呼吸.fbx             # 確認呼吸動作
│
└── cpr/                       # Unity 專案根目錄
    ├── Assets/
    │   ├── script/            # 主要 C# 腳本
    │   │   ├── ARscene1.cs ~ ARscene8.cs   # AR 場景邏輯
    │   │   ├── ChangeScenes.cs             # 場景導航（核心）
    │   │   ├── SceneControl.cs             # 開始/離開遊戲
    │   │   ├── gps.cs                      # GPS 定位回傳
    │   │   ├── call911.cs                  # 撥打 119 UI
    │   │   ├── Takeaed.cs                  # 取得 AED UI
    │   │   └── menu.cs                     # 選單開關
    │   ├── aed scene scripts/  # AED 場景專用腳本
    │   │   ├── vb1.cs / vb2.cs            # Virtual Button 互動
    │   │   ├── sound1.cs / sound3.cs       # 音效觸發
    │   │   └── mb左.cs / mb右.cs           # 左右按鈕控制
    │   ├── Scenes/            # Unity 場景檔（.unity）
    │   ├── Materials/         # 材質球
    │   ├── model/             # 模型資源
    │   ├── 動畫/              # 動畫控制器
    │   ├── VoiceCommander/    # 語音指令套件
    │   └── Photon/            # 多人連線套件（備用）
    ├── Packages/
    └── ProjectSettings/
```

---

## 場景流程

```
[主頁 Scene 22]
       │
       ▼
[Scene 1] 啟動 Logo（5秒自動跳轉）
       │
       ▼
[Scene 2] 引導開始（5秒後顯示按鈕）
       │
       ├──[Scene 3] 確認意識（拍肩、呼喊）
       │      ├── Y → 下一步
       │      └── N → 呼叫119
       │
       ├──[Scene 4~7] 開放呼吸道 / 確認呼吸
       │
       ├──[Scene 8] 胸部按壓示範
       │      ├── 5s：隱藏提示面板
       │      ├── 20s：播放按壓示範影片
       │      ├── 32s：顯示結束面板
       │      └── 44s：跳至 Scene 9
       │
       ├──[Scene 9] 選單（PlayGame / QuitGame）
       │
       ├──[Scene 20] AED 使用教學
       └──[Scene 21] AED 地圖查詢
```

---

## 授權

本專案為學術研究用途，3D 模型與程式碼版權歸作者所有。
