using _13_OOPPolymorphismTasitlar;

MotorluTasitalar motorlutasitler=new MotorluTasitalar();
motorlutasitler.Git();//motorlu tasit gidor


ARABA araba =new ARABA();
araba.Git();//ARABA GİDİYOR..


Motosiklet motosiklet = new Motosiklet();
motosiklet.Git();


List<MotorluTasitalar>list=new List<MotorluTasitalar>();    
list.Add(araba);
list.Add(motosiklet);
list.Add(motorlutasitler);
list.Add(new Ucak());


foreach(MotorluTasitalar item in list)
{
    item.Git();
}