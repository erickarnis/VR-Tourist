# VR Tourist
The VR Tourism system has two parts: a controller application, called the VR Tour Guide, and the viewing application, called the VR Tourist. The apps and some videos can be found in [this google drive folder](https://drive.google.com/drive/folders/0B92_UwrdAWrqRmx2TWl2enVWUTA?usp=sharing).

## Installing the VR Tourist app

The VR Tourist app should only be installed on Samsung Gear VR capable devices. The installation process is mostly the same as above, but with a few crucial differences starting at step 4.
1. To install the VR Tourist app, just download the latest vr-tourist.apk file onto the phone you want to install it on. You can also download it onto your computer, then drag and drop it onto your phone.
2. Go into the settings on that device and ensure that the option “install apps from unknown sources” is ticked. Doing this can differ from device to device.
	* You may also have to enable developer options, which also can differ from device to device.
3. Open the file manager app on your phone, and navigate to where you left the vr-tourist.apk file. Tap the file, then tap install. Once it is installed, tap open or go to your home screen or app drawer, there will be an app called “VR Tourist” there.
4. Create a folder called “VR-Tourism” at the same level as common folders like Download or documents. When you connect the phone to your computer and open it in Finder or File Explorer, this should be in the first visible level. The exact location of the folder must be “storage/emulated/0/VR-Tourism”. If the folder is in a different location the app will not be able to find the videos.
5. In the folder “VR-Tourism”, place the videos that you want the user to be able to watch. The videos must have name of the format “videoX.mp4”, with X being a number. Examples of properly named video files would be “video1.mp4”, or “video86.mp4”
6. The app is now installed and ready to use!

## How to Use the VR Tourist and VR Tour Guide apps

1. Install the VR Tourist app on any number of Gear VR capable devices.
2. Install the VR Tour Guide app on one android device.
3. Insure that all devices involved have an internet connection
	* This can be cellular or wifi.
4. Launch the VR Tourist app on every Gear VR capable phone you intend to use.
5. Have the users put on the Gear VR’s.
6. Launch the VR Tour Guide app.
7. Wait for the status area to change from “Connecting” to “Connected” on the Tour Leader device and on each Gear VR.
8. Wait for buttons with numbers and the text “Ready” to appear on the Tour Leader
9. Launch a video for each device individually or for all devices
	* To do this, tap the button for an individual device, or tap the button for all devices.
  	* Then, type a number into the field at the top of the page that just came up
    * i.e. if you want to launch video12.mp4, type in 12.
  	* When you want to launch the video, tap launch.
10. The video should start on the specified Gear VR(s).
11. If anything goes wrong, consult the Common Problems section below



## Common Problems
The first thing you should do if something goes wrong with either app is restart them. If this doesn’t solve the problem, see the list below.

1. I launched the VR Tourist and VR Tour Guide apps but no buttons appeared on the VR Tour Guide app.
    1. Ensure the VR Tour Guide app’s status area says “Connected”
    2. Sometimes it takes a few minutes to register properly.
      1. If no buttons appear, restart the VR Tour Guide app and check the internet connections of all devices
2. I launched a video from the VR Tour Guide app, and the screen went black on the VR Tourist, but no video started playing.
	1. This could be a problem with the folder containing the videos
		1. Ensure the folder is named “VR-Tourism”
		1. Ensure the folder is at the same level as other common folders, like Music, Movies, or Pictures. The exact location of the folder should be: “storage/emulated/0/VR-Tourism”.
	1. It could also be a problem with the videos
		1. Ensure that the number you type in matches a video on the device. i.e. if you typed in 56 but there is no file called video56.mp4 on the phone you tried to launch that video on, the screen will turn black and no video will play.
		1. Ensure that the video was originally an mp4 video. Renaming a .wav or other file type to .mp4 will not work.
1. I tried to launch the VR Tourist app, but when I tapped the icon or tapped or open there was an error and the app crashed.
	1. This is probably because the device you tried to use the app on is not registered with the developer. Open or download the Sideload VR app, and find the device id for your device. Send the device id to Eric Karnis, and he will add it to the vr-tourist.apk and send you a link to download it. Then, download the latest vr-tourist.apk and try again
1. There are two apps on my device, VR Tour Guide and VR Tour Leader. Which one should I use?
	1. Use VR Tour Guide. VR Tour Leader is an older version that might work unpredictably or not at all.
	2.
 If you have a problem that is not on this list or that is not solved by this list, try restarting the phone that is having the problems. If that doesn’t work, contact Eric Karnis.
