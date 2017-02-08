clc
clear
close all
iterationsNumber=1;
[optimizer,metric]=imregconfig('multimodal');
optimizer.InitialRadius=optimizer.InitialRadius/3.5;
optimizer.MaximumIterations=300;
cd('F:\Bittorrent\Car\Video\1')
myStep=1;
ffmpegDir = 'C:\ffmpeg-20161110-872b358-win64-static';
videoList=dir('*.h264');
imageNumber=6;
for myIndex=1:length(videoList)
videoFile=videoList(myIndex).name;
for i=1:length(videoFile)
    if strcmp(videoFile(i),'_')
        j=i;
    end
end
newIndex=videoFile(j+1:end-5)
delete('myvid.mp4');
cmd = ['"' fullfile(ffmpegDir, 'bin', 'ffmpeg.exe') '" -r 30 -i "' videoFile '" -vcodec copy myvid.mp4'];
system(cmd);
v=VideoReader('myvid.mp4');
i=0;
while hasFrame(v)
    i=i+1;
    video{i}=readFrame(v);
    videoDouble{i}=double(video{i});
end
myRate=v.Framerate;
clear v
delete('myvid.mp4');
for k=1:iterationsNumber
    k
    registered={};
    for i=1:length(video)-1
        i
        fixedColor=video{i};
        movingColor=video{i+1};
        [m,n,~]=size(fixedColor);
        onesMatrix=ones(m,n);
        rAverageM=mean(mean(movingColor(:,:,1)));
        gAverageM=mean(mean(movingColor(:,:,2)));
        bAverageM=mean(mean(movingColor(:,:,3)));
        rAverageF=mean(mean(fixedColor(:,:,1)));
        gAverageF=mean(mean(fixedColor(:,:,2)));
        bAverageF=mean(mean(fixedColor(:,:,3)));
        fixedColor(:,:,1)=fixedColor(:,:,1)-uint8((rAverageF-rAverageM)*onesMatrix);
        fixedColor(:,:,2)=fixedColor(:,:,2)-uint8((gAverageF-gAverageM)*onesMatrix);
        fixedColor(:,:,3)=fixedColor(:,:,3)-uint8((bAverageF-bAverageM)*onesMatrix);
        fixed=rgb2gray(fixedColor);
        moving=rgb2gray(movingColor);
        tformSimilarity=imregtform(moving,fixed,'similarity',optimizer,metric);
        movingRegisteredAffineWithICR=imregister(movingColor(:,:,1),fixedColor(:,:,1),'affine',optimizer,metric,'InitialTransformation',tformSimilarity);
        movingRegisteredAffineWithICG=imregister(movingColor(:,:,2),fixedColor(:,:,2),'affine',optimizer,metric,'InitialTransformation',tformSimilarity);
        movingRegisteredAffineWithICB=imregister(movingColor(:,:,3),fixedColor(:,:,3),'affine',optimizer,metric,'InitialTransformation',tformSimilarity);
        registered{i}=cat(3,movingRegisteredAffineWithICR,movingRegisteredAffineWithICG,movingRegisteredAffineWithICB);
    end
    video=registered;
end
fileName=[newIndex,'.avi'];
delete(fileName);
outputVideo=VideoWriter(fileName);
outputVideo.FrameRate=myRate;
open(outputVideo)
for i=1:length(video)
   writeVideo(outputVideo,video{i})
end
close(outputVideo)
end