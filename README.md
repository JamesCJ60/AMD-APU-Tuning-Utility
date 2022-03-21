# AMD APU Tuning Utility

If you come across any issues or errors with AATU please open an issue or ping `@JamesCJ#2022` or `@sbski#2700` in our [discord community server](https://discord.gg/M3hVqnT4pQ). 

Thanks to the [RyzenADJ Team](https://github.com/FlyGoat/RyzenAdj). If you would like to support the development of AMD APU Tuning Utility, you can do so [here](https://www.patreon.com/aatusoftware)

## Readme Index
- [What is AATU?](#what-is-aatu)
- [Benefits](#benefits-of-using-aatu)
- [Installation](#installation)
- [Disclaimers & Cautions](#disclaimers-&-cautions)
- [Source Code](#source-code)

## What is AATU?
- It's a new Ryzen APU tuning utility created by one of the developers of [Ryzen Controller](https://gitlab.com/ryzen-controller-team/ryzen-controller).
- It's a little lightweight Ryzen Master for laptops that allows you to control the power limits of your APU.
- Works best on 2xxx, 3xxx, 4xxx, and 5xxx series Ryzen Mobile with experimental 6xxx series support and can also work on Desktop APUs.
- As seen in: https://www.youtube.com/watch?v=UGvTtqHPuHU (Thanks ETA Prime for making the video 🥰)

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
- [AATU Extreme](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility-Extreme)
- [AATU V2](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V2-Source-Code)
- [AATU V2 Notification Pop-up](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V2-Notification-Source-Code)
- [AATU V1](https://github.com/JamesCJ60/AMD-APU-Tuning-Utility/tree/AATU-V1-Source-Code)

## Debugging missing file errors
In the event you get an error from windows that you are missing files, for example, VCRuntime140.dll or ucrtbased.dll try installing/reinstalling Visual C++ found [here](https://support.microsoft.com/en-us/topic/the-latest-supported-visual-c-downloads-2647da03-1eea-4433-9aff-95f26a218cc0)
