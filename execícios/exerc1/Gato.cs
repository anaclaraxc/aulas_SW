namespace EXERC1;

class Gato: Animal
{
    public override string Fala(){
        return base.Fala() + "MIAU";
    }
}