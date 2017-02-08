clc
clear
close all
cd('C:\Users\morteza\Desktop\4')
myStep=1;
ffmpegDir = 'C:\ffmpeg-20161110-872b358-win64-static';
videoList=dir('*.h264');
imageNumber=6;
videoFile='1_5.h264';
for i=1:length(videoFile)
    if strcmp(videoFile(i),'_')
        j=i;
    end
end
newIndex=videoFile(j+1:end-5);
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
clear v
delete('myvid.mp4');
myNumber=238;
imshow(video{myNumber})
imwrite(video{myNumber},[newIndex,'.jpg'])