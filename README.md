🖼🗜↩ Unity Texture DeCruncher
==============================

Following a change in [VRChat Guidelines](https://ask.vrchat.com/t/developer-update-16-march-2023/16950#sdk-warning-improvements-6) about the use of Crunch Compressed textures in projects, I wanted a script to quickly update all texture files in my project to turn off Crunch Compression.

While this feature will likely be built in to future versions of the SDK, this stand-alone script can check every file of your project, regardless of if it is part of your avatar or world currently, and fix the setting in advance.

## ✅ Requirements

* Tested in `Unity 2019.4.31f1`

## 💾 Installation

Download this repo using GIT or by clicking **Code** and then **Download ZIP** above.

In your project, create a folder called `Editor`, and copy the `DeCrunchTextures.cs` file from this repository or the ZIP file into that folder.

**Important:** Unity treats files within folders called *Editor* as special and knows that the script should be run as an Editor Add-On, not part of the project's game code, so don't just stick the file anywhere!

## ▶ Running the Tool

### ⚠ ***Backup your Projects!!!***

If this tool does something unexpected due to a conflict with another script, power loss or bug and corrupts your project, that's on you!

### How to Run

Once imported, an item named **Turn Off Crunch Compression** will be added to Unity's **Tools** menu. Select this menu option to begin the process.

A progress dialog will appear with the number of files to process, if you have a lot of image files in your project and a slow system, this may take some time.

Once the progress dialog is complete, all files will now be set uncrunched. You can now remove the script file from the project by just deleting the script file.