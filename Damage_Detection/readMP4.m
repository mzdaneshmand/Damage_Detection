function video=readMP4(fileName)
v=VideoReader(fileName);
i=0;
while hasFrame(v)
    i=i+1;
    video{i}=readFrame(v);
end