function registered=Register(movingColor,fixedColor,optimizer,metric)
for i=1:3
    movingColor(:,:,i)=histeq(movingColor(:,:,i),imhist(fixedColor(:,:,i)));
end
fixed=rgb2gray(fixedColor);
moving=rgb2gray(movingColor);
tformSimilarity=imregtform(moving,fixed,'similarity',optimizer,metric);
tform=imregtform(moving,fixed,'affine',optimizer,metric,'InitialTransformation',tformSimilarity);
Rmoving=imref2d(size(moving));
Rfixed=imref2d(size(fixed));
[movingRegisteredAffineWithICR,~]=imwarp(movingColor(:,:,1),Rmoving,tform,'OutputView',Rfixed, 'SmoothEdges', true);
[movingRegisteredAffineWithICG,~]=imwarp(movingColor(:,:,2),Rmoving,tform,'OutputView',Rfixed, 'SmoothEdges', true);
[movingRegisteredAffineWithICB,~]=imwarp(movingColor(:,:,3),Rmoving,tform,'OutputView',Rfixed, 'SmoothEdges', true);
registered=cat(3,movingRegisteredAffineWithICR,movingRegisteredAffineWithICG,movingRegisteredAffineWithICB);