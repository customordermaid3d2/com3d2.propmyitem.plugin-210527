# 이게 뭐지 what is?

로딩시간동안 겜이 멈추는걸 방지  
겜 시작시 바로 데이터 로딩이 스레드로 진행됨  

# 넣는곳 setup

COM3D2.PropMyItem.Plugin.dll 는 UnityInjector 폴더
System.Threading.dll 는 COM3D2\BepInEx\plugins 폴더

# 필요한거 need

- BepInEx https://github.com/BepInEx/BepInEx  
- SybarisLoader https://github.com/BepInEx/BepInEx.SybarisLoader.Patcher  
- UnityInjectorLoader https://github.com/BepInEx/BepInEx.UnityInjectorLoader  

- COM3D2.API.dll  https://github.com/DeathWeasel1337/COM3D2_Plugins/releases/download/v3/COM3D2.API.v1.0.zip
- System.Threading.dll  어지간하면 탐색기에서 발견 가능. https://github.com/customordermaid3d2/COM3D2.Lilly.BepInExPlugin/releases/download/210409/System.Threading.dll



# COM3D2.PropMyItem.Plugin

Fixed issues caused by 1.48+.  
Prevent accidental activation when typing in IMGUI text boxes.  
Remove scene limitations so feel free to activate PropMyItem wherever you want.  

All credits go to the original developer.
