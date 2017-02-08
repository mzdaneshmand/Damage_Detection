clc
clear
close all
ffmpegDir='C:\ffmpeg-20161110-872b358-win64-static';
videoList=dir('*.h264');
for myIndex=1:length(videoList)
    videoFile=videoList(myIndex).name;
    for i=1:length(videoFile)
        if strcmp(videoFile(i),'_')
            j=i;
        end
    end
    newIndex=videoFile(j+1:end-5);
    fileName=[newIndex,'.mp4'];
    delete(fileName);
    cmd = ['"' fullfile(ffmpegDir, 'bin', 'ffmpeg.exe') '" -r 30 -i "' videoFile '" -vcodec copy ' fileName]
    system(cmd);
end