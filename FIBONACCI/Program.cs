// primeia e segunda posição são 1
//o valor de uma posição é o valor da anterior mais a ante anterior

// 1
var f  = new Fibonacci();
Console.WriteLine("qual posição voce deseja saber o valor?");
var posicaoDesejada = Console.ReadLine();
var position = double.Parse(posicaoDesejada);
Console.WriteLine(f.getByPosition(position));

class Fibonacci{
    private Dictionary<double,double> hash = new Dictionary<double,double>{};
    public double getByPosition(double posicao){

        hash.Add(1,1);
        hash.Add(2,1);
        var len = this.hash.Count();
        for(var i = 3; i <= posicao; i++){ 
            this.hash[i] = hash[i-1] + hash[i-2];
        }
        return this.hash[posicao];
    }
}