# xr-anthony2.0
Unity Project Demonstrating Collaborative AR

Required Software:
The Latest Version of Xcode
Unity 2019.1.1 or greater
Unity Module for iOS building

Included PLugins:
ARKit Plugin 2.0
Lean Touch SDK
Photon SDK

To start the Photon/LeanTouch Demo with a Protein Structure go to:
Assets/Scenes/PhotonTest

How to Build on Xcode:

Go to:
File/Build Settings

And make sure under "Platform" iOS is selected

Now we need to set up the player settings. We need to access the iPhone or iPad's camera for the AR and then the location services for Photon to detect any local rooms

In File/Build Settings Press Player Settings on the bottom left of the window

Under Other Settings -> Configuration -> Camera Usage Description

Add any message telling the user to give permission.

Then under Other Settings -> Configuration -> Location Usage Description

Add another message for the location settings

Under Other Settings -> Configuration -> Target minimum iOS version

Be sure it is 11.0 or higher

Then in Settings for iOS-> XR settings

Make sure "Virtual Reality Supported" is checked off

{ IF YOU WANT THIS TO BE COMPATABLE WITH ANY OTHER PHOTON APPS:

Go to the scene's heirarchy

In PhotonCameraManager's Inspector Pane:

Go to the Lib Placenote (Script) Component 

and make sure the APP ID is the same for all the devices you are collaborating with in Photon.}

Now we're ready to build

Go to File/BuildSettings -> Build and Run

This will automatically open Xcode







