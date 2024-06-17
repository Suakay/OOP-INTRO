using _21_OOPStaticFizikKutuphanesi;
//Static Classtan instance alamayız.
FizikKutuphanesi fizikKutuphanesi=new FizikKutuphanesi();
//Normal bir sınıf2IN İNSTANCE NI ALABİLİRİM.
//Normal sınıf içerisinde static üye tanımlayabilirim.

FizikKutuphanesi.YerCekimiKuvveti = 10;
//Static sııfın üyeleri de static olamlıdır.
fizikKutuphanesi.YerCekimiKuvveti = 50;//salt okunur bir fiellda burada atama yapamayız.constructorda yada değişken tanımlanan yerde atama yapılabilir.
