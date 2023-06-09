# GameFramework-at-YooAsset

[![UnityVersion](https://img.shields.io/badge/Unity%20Ver-2019.4.12++-blue.svg?style=flat-square)](https://github.com/ALEXTANGXIAO/GameFramework-at-YooAsset)
[![License](https://img.shields.io/github/license/ALEXTANGXIAO/GameFramework-at-YooAsset)](https://github.com/ALEXTANGXIAO/GameFramework-at-YooAsset)
[![License](https://img.shields.io/github/last-commit/ALEXTANGXIAO/GameFramework-at-YooAsset)](https://github.com/ALEXTANGXIAO/GameFramework-at-YooAsset)
[![License](https://img.shields.io/github/issues/ALEXTANGXIAO/GameFramework-at-YooAsset)](https://github.com/ALEXTANGXIAO/GameFramework-at-YooAsset)

GameFramework +luban + hybridclr + YooAsset + UniTask

实现初衷：YooAsset确实十分好用，但是市面上较大的开源框架只有ET接入较多。且GameFramework的资源模块存在一定的设计过度问题。故在此首次把YooAsset接入GF并实现热更新。（HybridCLR热更新流程已经实现）

``` json
//程序集划分设计
Assets/GameMain/Scripts
├── Editor              // 编辑器程序集
├── HotFix              // 游戏热更程序集目录 [Folder]
|   ├── GameBase        // 游戏基础框架程序集 [Dll]
|   ├── GameProto       // 游戏配置协议程序集 [Dll]  
|   ├── BattleCore      // 游戏核心战斗程序集 [Dll] 
|   └── GameLogic       // 游戏业务逻辑程序集 [Dll]
|           ├── GameApp.cs                  // 热更主入口
|           └── GameApp_RegisterSystem.cs   // 热更主入口注册系统
└── Runtime             // Runtime程序集
```
---
## 日志记录编辑器下运行
![image](Books/Src/Editor.png)

---
## Win64位包运行

![image](Books/Src/PC.png)

## <strong>特别鸣谢
#### <a href="https://github.com/tuyoogame/YooAsset"><strong>YooAsset</strong></a> - YooAsset是一套商业级经历百万DAU游戏验证的资源管理系统。

#### <a href="https://github.com/EllanJiang/GameFramework"><strong>GameFramework</strong></a> - Game Framework 是一个基于 Unity 引擎的游戏框架。
