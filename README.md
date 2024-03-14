
# Video Settings for Unity

Save System is a framework to manage local and cloud saves. It provides simple interface to save files and configure cloud saves for Steam or Xbox and other platforms via extensions.

## Table of Contents

1. [Installation](#installation)
2. [Getting Started](#getting-started)
   - [Initialization](#initialization)
   - [Creating Graphics Configuration](#creating- Graphics Configuration)
3. [Use case](#How-to-use)


## Installation


### Install via Git URL
You can also use the "Install from Git URL" option from Unity Package Manager to install the package.
```
https://github.com/Studio-23-xyz/com.studio23.ss2.settings.video.git#upm
```

## Getting Started

### Initialization

Create An Empty GameObject and attach the VideoSettingsManager MonoBehaviour to it.
Add Display Controller MonoBehaviour and Graphics Controller MonoBehaviour to that GameObject.
Must have volume component attached to any gameobject and proper tag "GlobalVolume" to that gameobject for this package to work properly.


### Creating Graphics Configuration

Graphics Configuration is used to define which render pipeline will be used for video settings. Example : URP, HDRP
Assign Graphics Configuration in the slot of VideoSettingsManager script's 'PostProcessConfiguration' slot.


## Use case

### How To Use

To use this package properly you need to use either URP or HDRP Graphics Configuration.

Use VideoSettingsManager to access various function of this package.

```csharp
using studio23.ss2.Settings.Video.Core;

public class YourGameManager : MonoBehaviour
{
    private void UpdateResolution()
    {
        VideoSettingsManager.Instance.DisplayController.ChangeResolution(0);
    }
}
```

That's it! You now have the basic information you need to use the **Studio23.SS2.settings.video** library in your Unity project. Explore the library's features and customize it according to your game's needs.