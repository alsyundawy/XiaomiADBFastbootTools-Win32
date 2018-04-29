# XiaomiADBFastbootTools

**Features:**

* **Debloater** \- Remove unnecessary apps and services
* **Camera2 API Enabler** \- Enable the camera2 API of Android (only works in TWRP)
* **Get device properties** \- Retrieve tons of statistics and information about your phone
* **Image Flasher** \- Flash the boot/cust/modem/persist/recovery/system partition with an image
* **Wiper** \- Wipe the cache or perform a factory reset
* **Bootloader Unlocker** \- Lock or unlock the bootloader of the Mi A1 \(OEM unlocking must be enabled\)
* **ADB Rebooter** \- Advanced rebooting options using ADB
* **Fastboot Rebooter** \- Advanced rebooting options using fastboot

[Screenshot](https://i.imgur.com/Ui0VdzI.png)

**Warning: Use the tool at your own risk. Removing factory apps which aren't in the list may break your phone.**

[Download](https://drive.google.com/open?id=1HYfHg6DlAUf2WBJdgUj_ql_RLpzNQh1Z)

Changelog:

    Update v2.0.0.0
    - Added new apps to the Debloater
    - Added the ability to uninstall any app using the Debloater
    - Added the Camera2 API Enabler
    - Cleaned up the code and optimised some algorithms
    
    Update v1.2.0.0
    - Added new apps to the Debloater
    - Optimised the algorithm of the Debloater
    - The tinted buttons are now red
    
    Update v1.1.0.0
    - Tinted the text on buttons that perform irreversible actions
    - Fixed some minor bugs, optimised code
    
    Update v1.0.5.0
    - Fixed an issue with codename reading in ADB mode
    - Added Hangouts to the Debloater
    
    Update v1.0.4.0
    - Fixed an issue with serial number reading in fastboot mode
    
    Update v1.0.3.0
    - Added App Vault and Xiaomi SIM Activate Service to the Debloater
    
    Update v1.0.2.0
    - Optimised device loading algorithms
    - Bootloader status is now displayed in ADB mode
    - Leftover processes get killed on exit
    
    Update v1.0.1.0
    - Fixed scaling issues caused by higher scaling settings

**Questions and Answers:**

**Q:** Chrome says the archive may be dangerous. Why is that?

**A:** The ZIP contains three executables \(the tool, ADB and Fastboot\) and two DLLs which could be seen as potentially dangerous. That's the only thing I can think of.

**Q:** The tool is called Xiaomi ADB/Fastboot Tools. Does that mean it only works with Xiaomi devices?

**A:** Well, ADB and Fastboot are universal interfaces for Android devices but some of the algorithms and methods used in the app are Xiaomi specific so yes.

**Q:** Does this replace MiFlash or MiUnlock?

**A:** No. Implementing their functionality in such a simple tool would only make it unnecessarily complex, and there's no need for that anyways, since these are easy to use, fully developed tools maintained by Xiaomi.
