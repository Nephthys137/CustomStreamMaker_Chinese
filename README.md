# 自定义直播生成器

![image](https://github.com/Nephthys137/CustomStreamMaker_Chinese/assets/168308430/5aba9162-663c-4279-bdd6-440850660895)


Custom Stream Maker是一个**仅限Windows的**程序，允许您使用游戏中的音频、动画等制作自己的Needy Streamer Overload直播!

这个程序还有一个配套的游戏模组, [Custom Stream Loader](https://github.com/amazeedaizee/CustomStreamLoader), 它允许您在游戏本身上查看您的自定义直播!

#### 请注意：该程序本身不附带资产，您需要自己的Needy Streamer Overload才能预览游戏中的任何资产.

该程序还支持自定义背景和图片/动画!

**自定义背景** 使用 png 和 jpg 图像.

**自定义图片/动画** 使用您自己制作的Asset Bundles，并搜索任何有效的动画以用于预览。您也可以从您创建的Addressables中使用资产包，尽管您需要一个有效的目录来这样做.

**注意：当使用Asset Bundle选项添加自定义动画时，程序无法区分Asset Bundles和Addressable Bundles；虽然这在程序中是次要的，但在配套游戏模组中读取捆绑包时可能会导致问题，因此请确保在添加自定义动画时为要使用的捆绑包类型选择正确的选项。**

## Libraries

#### This program uses:
  
- [AssetTools.NET](https://github.com/nesrak1/AssetsTools.NET) <br/>
- [AssetRipper.TextureDecoder](https://github.com/AssetRipper/TextureDecoder) <br/>

For extracting the assets from the game.

Files from the Resources folders are taken from https://github.com/AssetRipper/Tpk.

-----

- [Fmod5Sharp](https://github.com/SamboyCoding/Fmod5Sharp) <br/> 
- [NAudio](https://github.com/naudio/NAudio) <br/>
- [NVorbis](https://github.com/NVorbis/NVorbis) <br/>
- [OggVorbisEncoder](https://github.com/SteveLillis/.NET-Ogg-Vorbis-Encoder) <br/>

For creating audio previews from the game.

-----

- [ImageSharp](https://github.com/SixLabors/ImageSharp) (Apache 2.0 version since this software is visible-source) <br/>

For creating image previews from the game, and from any custom images/sprites uploaded to the program.

## Licensing

**AssetExtractor.cs**, and **CustomAssetExtractor.cs** are licensed under the MIT License. You can find these licenses in their respective files. 

The rest of the code in this repository is All Rights Reserved (c) 2023 amazeedaizee.

## Other 

This program is fan-made and is not associated with xemono and WSS Playground. All properties belong to their respective owners.

Haven't downloaded Needy Streamer Overload yet? 
Get it here: https://store.steampowered.com/app/1451940/NEEDY_STREAMER_OVERLOAD/
