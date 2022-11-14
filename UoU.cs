//Achar o erro quando puder revisar isso
using System;

    //Crie um novo programa C# chamado UoU (Uordi ofi Uorcrefiti).
namespace UoU { 
    //Crie uma classe chamada Heroi com base nos atributos e métodos discutidos em aula

    //Transforme a classe Heroi em uma classe abstrata, realizando os ajustes
    //necessários no restante do programa.
 public abstract class Heroi {
    private string Nome;
    protected double Pontos_Vida;
    
    public Heroi (string Nome, double Pontos_vida)
    {
    this.Nome = Nome;
    this.Pontos_Vida = Pontos_Vida;
    }
    //Métodos GET
    public string getNome(){
      return(Nome);     
    }

    public double getPontos_Vida(){
      return(Pontos_Vida);     
    }

    //Métodos SET
    public void setNome(string Nome){
     this.Nome = Nome;    
    }

    public void setPontos_Vida(double Pontos_Vida){
     this.Pontos_Vida = Pontos_Vida;    
    }
    
    //Os métodos LancarMagia() e AtacarComArma() devem ser deixados vazios.
    //Transforme os métodos LancarMagia() e AtacarComArma() em métodos
    //abstratos, realizando os ajustes necessários no restante do programa.
    public virtual void LancarMagia();
    public virtual  void AtacarComArma();

    public virtual void ReduzirVida() {
    this.Pontos_Vida =  this.Pontos_Vida - 20;
    }
    public virtual void AumentarVida() {
    this.Pontos_Vida =  this.Pontos_Vida  + 50;
    }
    
    //Destrutor
    ~Heroi(){
    }
  }

    //Crie uma classe chamada HeroiAlianca herdando da classe Heroi.
   public class HeroiAlianca:Heroi{
    public HeroiAlianca (string Nome,int Pontos_Vida):base(Nome,Pontos_Vida){
    }
    //Sobrescreva o método AumentarVida() para conferir um bônus de 0.2 pontos de vida.
    public override void AumentarVida (){
        base.AumentarVida ();
        this.Pontos_Vida += 0.2;
    }
    public override void LancarMagia(){
        Console.WriteLine ("Chama Divina!");
    }
    public override  void AtacarComArma() {
        Console.WriteLine ("Pela Honra de Grayskull");
    }
   }
    
    //Crie uma classe chamada HeroiHorda herdando da classe Heroi.
    public class HeroiHorda:Heroi{
    public HeroiHorda (string Nome,int Pontos_Vida):base(Nome, Pontos_Vida){
        
    }
    //Sobrescreva o método ReduzirVida() para conferir um bônus de 0.2 pontos de vida.
    public override void ReduzirVida (){
        base.ReduzirVida ();
        this.Pontos_Vida -= 0.2;
    }
    public override void LancarMagia(){
        Console.WriteLine ("Névoa da Morte!");
    }
    public override  void AtacarComArma(){
        Console.WriteLine ("Pela Honra de Khazad-dûm");    
    }    
}
    
     
   public class UoU{
   public static void Main(){
    //18. Declare duas variáveis ali e hor do tipo Heroi. Crie um objeto do tipo
    //HeroiAlianca e outro objeto do tipo HeroiHorda, armazenando as referências
    //de cada um nas variáveis ali e hor respectivamente.
      Heroi ali = new HeroiAlianca("Vax'ildan", 110);
      
      Console.WriteLine("\nHeroi Aliança"); 
      Console.WriteLine("O nome do heroi é: {0}", ali.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", ali.getNome(), ali.getPontos_Vida()); 
      
      Console.WriteLine("{0} um Heroi Comum lhe atacou!", ali.getNome()); 
      ali.ReduzirVida();
      Console.WriteLine("Seus pontos de vida caíram para: {0}", ali.getPontos_Vida()); 
      
      Console.WriteLine("{0} tomou uma poção de cura.", ali.getNome()); 
      ali.AumentarVida();
      Console.WriteLine("Sua vida recuperou para: {0}", ali.getPontos_Vida()); 
      
      Console.WriteLine("{0} conseguiu invocar sua magia divina:", ali.getNome()); 
      ali.LancarMagia();
      
      Console.WriteLine("\nVocê lutou bem bravo héroi! Siga para o acampamento!"); 
      
      //Horda
      Heroi hor = new HeroiHorda("Trinket", 120);
      
      Console.WriteLine("\nHeroi Horda"); 
      Console.WriteLine("O nome do heroi é: {0}", hor.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", hor.getNome(), hor.getPontos_Vida()); 
      
      Console.WriteLine("{0}, um Heroi da Aliança lhe atacou!", hor.getNome()); 
      hor.ReduzirVida();
      Console.WriteLine("Seus pontos de vida caíram para: {0}", hor.getPontos_Vida()); 
      
      Console.WriteLine("{0} tomou uma poção de cura.", hor.getNome()); 
      hor.AumentarVida();
      Console.WriteLine("Sua vida recuperou para: {0}", hor.getPontos_Vida()); 
      
      Console.WriteLine("{0} sem perder tempo lança uma magia", hor.getNome()); 
      hor.LancarMagia();
      
      Console.WriteLine("\nVocê lutou bem bravo héroi! Siga para o acampamento!");       
    //19. A partir das variáveis ali e hor, invoque os métodos LancarMagia() e 
    //AtacarComArma().  
      
    //A partir da classe principal (UoU), crie um herói com nome “Zymmax” 
    //e 100 pontos de vida.  
    //Heroi heroiBase = new Heroi("Vex'ahlia", 100);
    //Exiba o nome e os pontos de vida de Zymmax.
    //Console.WriteLine("Heroi Base"); 
    //Console.WriteLine("O nome do heroi é: {0}", heroiBase.getNome());
    //Console.WriteLine("Seus pontos de vida base são: {0}", heroiBase.getPontos_Vida()); 
    
    //Ainda na classe principal, invoque os métodos ReduzirVida() e AumentarVida()
    //do herói Zymmax, exibindo os pontos de vida que restaram após a execução de
    //cada método. 
   // Console.WriteLine("{0}, um Heroi da Horda lhe atacou!", heroiBase.getNome()); 
    //heroiBase.ReduzirVida();
    //Console.WriteLine("Seus pontos de vida caíram para: {0}", heroiBase.getPontos_Vida()); 
      
    //Console.WriteLine(heroiBase.getNome(), "{0} tomou uma poção de cura."); 
    //heroiBase.AumentarVida();
    //Console.WriteLine("Sua vida recuperou para: {0}", heroiBase.getPontos_Vida());  
      
      
    //A partir da classe principal, crie um herói da Aliança com nome “Zadur” 
    //e 100 pontos de vida.
    Console.WriteLine("\nHeroi Aliança");
   
    HeroiAlianca heroiAli = new HeroiAlianca("Vax'ildan", 110);
    //Exiba o nome e os pontos de vida de Zadur.
    Console.WriteLine("O nome do heroi é: {0}", heroiAli .getNome());
    Console.WriteLine("Seus pontos de vida base são: {0}", heroiAli.getPontos_Vida()); 
    
    //Ainda na classe principal, invoque os métodos ReduzirVida() e AumentarVida()
    //do herói Zadur, exibindo os pontos de vida que restaram após a execução de
    //cada método.  
    Console.WriteLine("{0}, um Heroi da Horda lhe atacou!", heroiAli.getNome()); 
    heroiAli.ReduzirVida();
    Console.WriteLine("Seus pontos de vida caíram para: {0}", heroiAli.getPontos_Vida()); 
      
    Console.WriteLine(heroiAli.getNome(), "{0} tomou uma poção de cura."); 
    heroiAli.AumentarVida();
    Console.WriteLine("Seus pontos de vida agora são: {0}", heroiAli.getPontos_Vida()); 
      
    //A partir da classe principal, crie um herói da Horda com nome “Zodar” 
    //e 100 pontos de vida.
    Console.WriteLine("\nHeroi Horda"); 

    HeroiHorda heroiHord = new HeroiHorda("Trinket", 120);
    //Exiba o nome e os pontos de vida de Zodar.
    Console.WriteLine("O nome do heroi é: {0}", heroiHord.getNome());
    Console.WriteLine("Seus pontos de vida base são: {0}", heroiHord.getPontos_Vida()); 
    
    //Ainda na classe principal, invoque os métodos ReduzirVida() e AumentarVida()
    //do herói Zodar, exibindo os pontos de vida que restaram após a execução de
    //cada método.  
    Console.WriteLine("{0}, um Heroi da Horda lhe atacou!", heroiHord.getNome()); 
    heroiHord.ReduzirVida();
    Console.WriteLine("Seus pontos de vida caíram para: {0}", heroiHord.getPontos_Vida()); 
      
    Console.WriteLine(heroiHord.getNome(), "{0} tomou uma poção de cura."); 
    heroiHord.AumentarVida();
    Console.WriteLine("Seus pontos de vida agora são: {0}", heroiHord.getPontos_Vida()); 
      
      
    }
  }
}
