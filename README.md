## CaptureProgram_1
It can be used for detecting number plates and capturing a configurable number of images and/or videos.
Usage is through running the file "~\CaptureProgram\bin\x64\Debug\CaptureProgram.exe"

## Capturing
Contains python server, client and runstart files for the capturing on the camera side.
They need to be copied to all the cameras, and the runstart file needs to be made to run on startup.

## Damage_Detection
Contains MATLAB files for damage detection/detection+verification, which is run through the main_Single.m/main.m file.

## part1
Damage detection software for a collection of images taken before and after the damage has been made by multiple cameras.

## h264toMp4.m
Converts H264 videos to MP4 format, where the former is output by the camera, and the latter can be imported into MATLAB for further processing.

## Image_Matching_6.m
Finds the closest image to a reference image from a sequence provided in form of a video file based on structural similarity.

## Image_Registration.m
Provides image extraction and registration at the same time.

## readMP4.m
Reads an MP4 video into MATLAB's workspace.

## Further information and questions
shb@icv.tuit.ut.ee
