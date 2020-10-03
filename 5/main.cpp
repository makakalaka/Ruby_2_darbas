#include <iostream>

using namespace std;

int main()
{   setlocale(LC_ALL,"Lithuanian");
    int elektra, kaina=0, sumaelektros;
    cout<<"Áveskite sunaudotos elektros kieká"<<endl;
    cin>>elektra;
    if(elektra>=1 && elektra<=50)
    {
        kaina=elektra*0.5;
        kaina=kaina+kaina*0.2; //Administracinis mokestis 20% pridedamas prie sumos
        cout<<"elektros kaina "<<kaina<<" eur/kW"<<endl;
    }
    if(elektra>50 && elektra<150)
    {
        sumaelektros=elektra-50;
        kaina=sumaelektros*0.75+50*0.5;
        kaina=kaina+kaina*0.2;

        cout<<"elektros kaina "<<kaina<<" eur/kW"<<endl;
    }
    if(elektra>=150 && elektra<=250 )
    {
        sumaelektros=elektra-150;
        kaina=sumaelektros*1.2+100*0.75+50*0.5; //Administracinis mokestis 20% pridedamas prie sumos
        kaina=kaina+kaina*0.2;
        cout<<"elektros kaina "<<kaina<<" eur/kW"<<endl;
    }
    if(elektra>250)
    {
        sumaelektros=elektra-250;
        kaina=sumaelektros*1.5+100*1.2+100*0.75+50*0.5;
        kaina=kaina+kaina*0.2; //Administracinis mokestis 20% pridedamas prie sumos
        cout<<"elektros kaina "<<kaina<<" eur"<<endl;
    }
    return 0;
}
