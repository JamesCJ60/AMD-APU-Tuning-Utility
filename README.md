# [Development has now moved to a new project that covers both Intel and AMD](https://github.com/JamesCJ60/Universal-x86-Tuning-Utility)

# AMD APU Tuning Utility

If you come across any issues or errors with AATU please open an issue or ping `@JamesCJ#2022` or `@sbski#2700` in our [discord community server](https://discord.gg/M3hVqnT4pQ). 

If you would like to support the development of AMD APU Tuning Utility by donating, you can do so via [Patreon](https://www.patreon.com/uxtusoftware) or [PayPal](https://www.paypal.me/JamesCJ60)

[![Github All Releases](https://img.shields.io/github/downloads/JamesCJ60/AMD-APU-Tuning-Utility/total.svg)]() [![Windows](https://svgshare.com/i/ZhY.svg)]() [![GitHub stars](https://img.shields.io/github/stars/JamesCJ60/AMD-APU-Tuning-Utility?style=social&label=Star&maxAge=2592000)]() [![GitHub forks](https://img.shields.io/github/forks/JamesCJ60/AMD-APU-Tuning-Utility?style=social&label=Fork&maxAge=2592000)]()


## Readme Index
- [What is AATU?](#what-is-aatu)
- [Benefits](#benefits-of-using-aatu)
- [Installation](#installation)
- [Disclaimers & Cautions](#disclaimers-&-cautions)
- [Source Code](#source-code)
- [Basic CPU/APU Support List](#basic-apu-support-list)

## What is AATU?
- It's a new Ryzen APU tuning utility created by one of the developers of [Ryzen Controller](https://gitlab.com/ryzen-controller-team/ryzen-controller).
- It's a little lightweight Ryzen Master for laptops that allows you to control the power limits of your APU.
- Works best on 2xxx, 3xxx, 4xxx, and 5xxx series Ryzen Mobile with experimental 6xxx series support and can also work on Desktop APUs.
- Tutorial created by ETA Prime: https://www.youtube.com/watch?v=UGvTtqHPuHU

### What is adaptive eco?
Adaptive eco is a mode built into AMD APU Tuning Utility that uses an algorithm to lower your APU's power limit over time as your battery life decreases. In short, adaptive eco allows you to keep as much performance as possible while also attempting to improve battery life over time. Adaptive eco does this by constantly monitoring the battery life of your laptop. That data is then used to make adjustments based on that, for example, how much should be removed or added to the APUs power limit while also changing windows power plan settings to further the impact.

### What is adaptive performance - Adpative TDP?
Adaptive performance is another mode built into AMD APU Tuning Utility that does the opposite of adaptive eco. This mode uses an algorithm that aims to find the best possible power limits for your APU to get the best possible performance. This is done by monitoring the temperatures of the APU and then using this data to balance off the power limits to find the most stable settings for performance.

### What is adaptive performance - Turbo Boost Overdrive?
Adaptive performance TBO is a modification of the existing power management algorithms used within AMD APU Tuning Utility. The difference is that instead of adjusting TDPs based on just APU temperatures, it adjusts clocks based on load, power limits, and temperatures. 

Turbo Boost Overdrive iGPU is the first to be released. TBO iGPU does what has been stated before, but as you can guess, to the iGPU clocks of supported APUs using an offset to calculate the max clock the APU's iGPU can run under load. This mode also solves the static nature of iGPU clocks when manually overclocking them. Thanks to the load-based adjustments to the clock speed, this flaw is worked around.

As a result, this allows the APU to find the best clock speed for that moment in time, saving on power, increasing battery life, while reducing temperatures when the highest clocks are not needed when aiming to keep peak performance.

## Benefits of using AATU
Benefits of using AMD APU Tuning Utility/Ryzen Controller on your laptop:
- You can gain anywhere from as little as 5% to as much as 35%+ extra performance for absolutely free without having to buy a new laptop, prolonging the life of your existing Zen-based mobile APU.

![alt text](https://cdn.discordapp.com/attachments/772164404598276135/870293764688715776/Screenshot_2021-07-29_at_14.png)
*stock power limits and results will vary depending on the laptop make, model and specifications. This data is here to prove that you can gain extra performance when allowing more power draw.

You can also gain more performance on unlocked HX/G APUs (4000 series and newer) by using Apative Performance mode with Turbo Boost Overdrive CPU enabled.

![image](https://user-images.githubusercontent.com/20888782/158470309-5c489e11-1920-4373-a589-eff03d79d4d8.png)



## Installation
- Go to [release page](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/releases)
- Download the your chosen AATU varients .zip file starting with AATU Stable or AATU Light depending on your chose
- Extract the zip using 7Zip or Winrar
- Have fun!!!

## Disclaimers & Cautions
- If you intend to use AMD APU Tuning Utility in a video/text post online (e.g. YouTube, Reddit) please credit the AMD APU Tuning Utility team by linking to the AMD APU Tuning Utility GitHub release page! We ask this so that viewers/readers can download the software from a trusted source and so the developers get the proper recognition for their work.
- AMD APU Tuning Utility Team is not liable for any damages that my occur from using AMD APU Tuning Utility or RyzenADJ, Please use at your own risk!
- "AMD", "APU", "Ryzen", and "AMD Ryzen" are trademarked by and belong to Advanced Micro Devices, Inc. "ROG", and "Armoury Crate" are trademarked by and belong to AsusTek Computer, Inc. AMD APU Tuning Utility Team makes no claims to these assets and uses them for informational purposes only.
- If you wish to gain developer access to AMD APU Tuning Utility, ping `@JamesCJ#2022` or `@sbski#2700` in our [discord community server](https://discord.gg/M3hVqnT4pQ). 


## Source Code
You can find all the source code for the many different versions and elements of AATU below:
- [AATU Semi-custom Libryzenadj](https://github.com/JamesCJ60/RyzenAdj)
- [AATU V3](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V3-Source-Code)
- [AATU V2](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V2-Source-Code)
- [AATU V2 Notification Pop-up](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V2-Notification-Source-Code)
- [AATU V1](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V1-Source-Code)

## Debugging missing file errors
In the event you get an error from windows that you are missing files, for example, VCRuntime140.dll or ucrtbased.dll try installing/reinstalling Visual C++ found [here](https://support.microsoft.com/en-us/topic/the-latest-supported-visual-c-downloads-2647da03-1eea-4433-9aff-95f26a218cc0)

## Basic APU Support List:
This list does not include "Pro", "Embedded" APUs or custom APUs that may be supported like found in the Steam Deck.
### 200 Series:
200G:
- Athlon 200GE
- Athlon 220GE
- Athlon 240GE

### 300 Series:
300G:
- Athlon 300GE
- Athlon 320GE

### 2000 Series:
2000U:
- Ryzen 3 2200U
- Ryzen 3 2300U
- Ryzen 5 2500U
- Ryzen 7 2700U

2000H:
- Ryzen 5 2600H
- Ryzen 7 2800H

2000G:
- Ryzen 3 2200G/GE
- Ryzen 5 2400G/GE

### 3000 Series:
3000U:
- Ryzen 3 3200U
- Ryzen 3 3300U
- Ryzen 5 3500U
- Ryzen 7 3700U

3000H:
- Ryzen 5 3550H
- Ryzen 7 3750H

3000G:
- Athlon 3000GE
- Ryzen 3 3200G/GE
- Ryzen 5 3400G/GE

### 4000 Series:
4000U:
- Ryzen 3 4300U
- Ryzen 5 4500U
- Ryzen 5 4600U
- Ryzen 7 4700U
- Ryzen 7 4800U

4000H:
- Ryzen 5 4600H/HS
- Ryzen 7 4800H/HS

4000G:
- Athlon Gold 4100GE
- Ryzen 3 4300G/GE
- Ryzen 5 4600G/GE
- Ryzen 7 4700G/GE

4000:
- Ryzen 3 4100
- Ryzen 5 4500
- Ryzen 7 4700

### 5000 Series:
5000U:
- Ryzen 3 5300U
- Ryzen 3 5400U
- Ryzen 3 5425U
- Ryzen 5 5500U
- Ryzen 5 5600U
- Ryzen 5 5625U
- Ryzen 7 5700U
- Ryzen 7 5800U
- Ryzen 7 5825U

5000H:
- Ryzen 5 5600H/HS
- Ryzen 7 5800H/HS
- Ryzen 9 5900HX/HS
- Ryzen 9 5980HX/HS

5000G:
- Ryzen 3 5300G/GE
- Ryzen 5 5600G/GE
- Ryzen 7 5700G/GE

5000:
- Ryzen 3 5300
- Ryzen 5 5500
- Ryzen 7 5700

### 6000 Series:
6000U:
- Ryzen 5 6600U
- Ryzen 7 6800U

6000H:
- Ryzen 5 6600H/HS
- Ryzen 7 6800H/HS
- Ryzen 9 6900HX/HS
- Ryzen 9 6980HX/HS

6000G:
- TBA
