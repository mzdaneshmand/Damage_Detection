clc
clear
close all
tic
myTolRate=.8;
myStep=21;
imageNumber=6;
% cIndices=[5,8];
% sIndices=[2,3,1,9];
cIndices=2;
sIndices=3;
ffmpegDir = 'C:\ffmpeg-20161110-872b358-win64-static';
directory='F:\Bittorrent\Car\Video_1';
files=dir(directory);
dirFlags=[files.isdir];
subFolders=files(dirFlags);
[folderNumber,~]=size(subFolders);
for fileIndex=3:folderNumber
    tic
cd([directory,'\',subFolders(fileIndex).name, '\'])
videoList=dir('*.h264');
for myIndex=1:length(videoList)
videoFile=videoList(myIndex).name;
for i=1:length(videoFile)
    if strcmp(videoFile(i),'_')
        j=i;
    end
end
newIndex=videoFile(j+1:end-5);
strIndex=str2num(newIndex);
if ~isempty(find(cIndices==strIndex, 1)) || ~isempty(find(sIndices==strIndex, 1))
delete('myvid.mp4');
cmd = ['"' fullfile(ffmpegDir, 'bin', 'ffmpeg.exe') '" -r 30 -i "' videoFile '" -vcodec copy myvid.mp4'];
system(cmd);
v=VideoReader('myvid.mp4');
video=[];
videoDouble=[];
i=0;
while hasFrame(v)
    i=i+1;
    video{i}=readFrame(v);
    videoDouble{i}=double(video{i});
end
strIndex=str2num(newIndex);
allVideos{strIndex}=video;
clear v
delete('myvid.mp4');
d=[];
j=0;
vLength=length(video);
allVideoLengths(strIndex)=vLength;
intIndices=[];
for i=1:myStep:vLength-myStep
    j=j+1;
    d(j)=mean(mean(mean(abs(videoDouble{i}-videoDouble{i+myStep}))))/myStep;
    intIndices(j)=i;
end
meanD=mean(d);
meanD=myTolRate*meanD;
Start=[];
End=[];
i=0;
j=0;
ld=length(d);
while i<ld
    i=i+1;
    if d(i)>meanD
        j=j+1;
        Start(j)=intIndices(i);
        while d(i)>meanD && i<ld
            i=i+1;
        end
        End(j)=intIndices(i);
    end
end
vLength=End-Start;
[~,myIndex]=max(vLength);
moveStart=Start(myIndex);
moveEnd=End(myIndex)+myStep;
allMoveStarts(strIndex)=moveStart;
allMoveEnds(strIndex)=moveEnd;
moveLength=moveEnd-moveStart;
allMoveLengths(strIndex)=moveLength;
imwrite(video{moveStart},[num2str(0),'_',newIndex,'.jpg']);
imwrite(video{moveEnd},[num2str(imageNumber+1),'_',newIndex,'.jpg']);
for i=1:imageNumber
    frameIndex=round(moveStart+(i/(imageNumber+1))*(moveEnd-moveStart));
    allSampleIndices(i,strIndex)=frameIndex;
    imFile=[num2str(i),'_',newIndex,'.jpg'];
    delete(imFile);
    imwrite(video{frameIndex},imFile);
    allImages{i}{strIndex}=video{frameIndex};
end
end
end
toc
tic
lc=length(cIndices);
ls=length(sIndices);
numComp=ls/lc;
for id=1:lc
    cIndex=cIndices(id);
    for jd=numComp*(id-1)+1:numComp*id
        currentSide=sIndices(jd);
        video=allVideos{currentSide};
        moveLength=allMoveLengths(currentSide);
        moveStart=allMoveStarts(currentSide);
        moveEnd=allMoveEnds(currentSide);
        matchIndex=moveStart-1;
        for kd=1:imageNumber
            myImage=allImages{kd}{cIndex};
myT=[inf,inf];
for i=3:moveLength
    myT(i)=ceil((i-2)/4)*floor(log10(moveLength)/log10(i-1));
end
[~,numSamples]=min(myT);
allNumSamples(kd,id,jd)=numSamples;
currentIndices=[];
currentIndices(1)=matchIndex+1;
currentIndices(numSamples)=moveEnd;
tempValues=[moveStart,moveEnd];
parfor i=1:2
    tempSSIM(i)=ssim(video{tempValues(i)},myImage);
end
mySSIM=[];
mySSIM(1)=tempSSIM(1);
mySSIM(numSamples)=tempSSIM(2);
while currentIndices(end)-currentIndices(1)>numSamples-1
    myRate=(currentIndices(end)-currentIndices(1))/(numSamples-1);
    for i=2:numSamples-1
        currentIndices(i)=round((i-1)*myRate)+currentIndices(1);
    end
    parfor i=2:numSamples-1
        mySSIM(i)=ssim(video{currentIndices(i)},myImage);
    end
    avgIntSSIM=mySSIM(1:end-1)+mySSIM(2:end);
    [~,maxIndex]=max(avgIntSSIM);
    finalIndices=currentIndices;
    finalSSIM=mySSIM;
    currentIndices(1)=currentIndices(maxIndex);
    currentIndices(numSamples)=currentIndices(maxIndex+1);
    mySSIM(1)=mySSIM(maxIndex);
    mySSIM(numSamples)=mySSIM(maxIndex+1);
end
[~,ssimIndex]=max(finalSSIM);
matchIndex=finalIndices(ssimIndex);
imFile=[num2str(kd),'_',num2str(cIndex),'_',num2str(currentSide),'.jpg'];
delete(imFile)
imwrite(video{matchIndex},imFile)
allMatchIndices(kd,id,jd)=matchIndex;
        end
    end
end
toc
end
toc