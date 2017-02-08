function finalImage=showDamage(fixedColorCopy_1,damage_1,myColor)
[m,n,~]=size(fixedColorCopy_1);
for i=1:m
    for j=1:n
        if damage_1(i,j)==1
            fixedColorCopy_1(i,j,:)=myColor;
        end
    end
end
finalImage=uint8(fixedColorCopy_1);