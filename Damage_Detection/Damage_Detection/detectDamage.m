function damage_1=detectDamage(fixedColor,registered,newTolerance)
for i=1:3
    registered(:,:,i)=histeq(registered(:,:,i),imhist(fixedColor(:,:,i)));
end
doubleRegistered=double(registered);
doubleFixed=double(fixedColor);
differenceDouble=abs(doubleRegistered-doubleFixed);
[m,n,~]=size(doubleRegistered);
zeroImage=zeros(m,n);
flagImage=zeroImage;
newFlagImage=zeroImage;
damage_1=zeroImage;
for i=1:m
    for j=1:n
        if doubleRegistered(i,j,1)>0 || doubleRegistered(i,j,2)>0 || doubleRegistered(i,j,3)>0
            flagImage(i,j)=1;
        end
    end
end
finalDifferenceDouble=cat(3,flagImage.*differenceDouble(:,:,1),flagImage.*differenceDouble(:,:,2),flagImage.*differenceDouble(:,:,3));
for i=1:m
    for j=1:n
        if finalDifferenceDouble(i,j,1)>newTolerance || finalDifferenceDouble(i,j,2)>newTolerance || finalDifferenceDouble(i,j,3)>newTolerance
            newFlagImage(i,j,1)=1;
        end
    end
end
for i=1:m
    for j=1:n
        if newFlagImage(i,j)==1
            damage_1(i,j)=1;
        end
    end
end