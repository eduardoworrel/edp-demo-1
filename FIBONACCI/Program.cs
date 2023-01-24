// primeia e segunda posição são 1
//o valor de uma posição é o valor da anterior mais a ante anterior

// 1
var f  = new Fibonacci();
Console.WriteLine("qual posição voce deseja saber o valor?");
var posicaoDesejada = Console.ReadLine();
var position = int.Parse(posicaoDesejada);
Console.WriteLine(f.getByPosition(position));

class Fibonacci{
    private Dictionary<int,decimal> hash = new Dictionary<int,decimal>{};
    public decimal getByPosition(int posicao){

        hash.Add(1,1);
        hash.Add(2,1);
        var len = this.hash.Count();
        for(var i = 3; i <= posicao; i++){
            Console.WriteLine(hash[i-1 + i-2]);
            this.hash[posicao] = hash[i-1 + i-2];
            Console.WriteLine(this.hash);
        }
        return this.hash[posicao];
    }
}