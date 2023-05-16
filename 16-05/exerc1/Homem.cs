namespace EXERC1;

class Homem: Animal
{
    public override string Fala(){
        return base.Fala() + "MIAU";
    }
}