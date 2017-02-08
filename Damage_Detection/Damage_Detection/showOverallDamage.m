function [refImage,refImage_1]=showOverallDamage(refImage,CM,cColor,FM,fColor,BM,bColor,oColor)
OM=CM.*FM.*BM;
[m,n,~]=size(refImage);
refImage_1=refImage;
for i=1:m
    for j=1:n
        if CM(i,j)==1 || FM(i,j)==1 || BM(i,j)==1
            refImage(i,j,:)=cColor*CM(i,j)+fColor*FM(i,j)+bColor*BM(i,j);
        end
        if OM(i,j)==1
            refImage_1(i,j,:)=oColor;
        end
    end
end
refImage=uint8(refImage);
refImage_1=uint8(refImage_1);