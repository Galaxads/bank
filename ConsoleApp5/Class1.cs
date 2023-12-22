using System;   
using System.Collections.Generic;  
using System.Linq; 
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

class Chetvbanke
{
   public int nom;
   private string fio = "";
   public float sum;
   private void otk(int nom,string fio, float sum) 
   {
        Console.WriteLine($"Введите номер счета (на данный момент номер счета {nom})"); 
        nom=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Введите ФИО владельца (на данный момент ФИО {fio})");
        fio = Console.ReadLine();
        Console.WriteLine($"Введите сумму для пополнения(на данный момент сумма на счету {sum})");
        sum = Convert.ToInt32(Console.ReadLine());
        this.sum = this.sum + sum;
        this.nom = nom;
        this.fio = fio;
   }
   private void Out()  
   { 
    Console.WriteLine($"Ваш номер счета:{nom} \nФИО владельца счета:{fio} \nКоличество денег на счету:{sum}");
   }
   private void dob(float sum)
   {
     float iznachal = this.sum;//переменная для хранения изначального баланса
     Console.WriteLine("На какую сумму пополнить счет?");
     sum = Convert.ToInt32(Console.ReadLine()); 
     sum = iznachal + sum;
     Console.WriteLine($"Ваш обновленный баланс {sum}");
     this.sum = sum;   
   }                                                                                                  
   private void umen(float sum)                                              
   {                                        
    float iznachal = this.sum;//переменная для хранения изначального баланса                                                                                
        Console.WriteLine("На какую сумму снять со счета?");
        sum = Convert.ToInt32(Console.ReadLine());
        if (sum<=iznachal)
        {
          sum = iznachal - sum;
          Console.WriteLine($"Ваш обновленный баланс: {sum}");
          this.sum=sum; 
        }
    else
    {
     Console.WriteLine("Сумма для снятия превышает сумму баланса");
    }
   }                                                            
   private void obnul()                           
   {                                                        
    sum= this.sum-this.sum;                                                   
    Console.WriteLine($"Вы сняли все деньги с баланса.Ваш обновленный баланс {sum}");                               
   }
    public float perenos(int operachet,int schet2)
    {
        float balans1=this.sum;
        
        Console.WriteLine("Сколько денег перевести");
        float perevod = Convert.ToInt32(Console.ReadLine());

        if (perevod < balans1)
        {
            float itogshiclo = this.sum - perevod;
            float balans2 = perevod;// деньги для нового счета
            this.sum = itogshiclo;// остаток на счету 
             
            Console.WriteLine($"С счета {operachet} было переведено на счет {schet2}  {perevod}рублей.");
            return (perevod);

        }
        else
        {
            Console.WriteLine("Сумма перевода больше чем денег на балансе");
            return perevod = 0; ;
        }
    }
    public void zapolneniecheta(int operachet)
    {
        for (int i = 0; i < 100; i++)
        {
            
         
            Out();
            Console.WriteLine($"(нажмите 1)Вы хотите положить/(2)снять/(3)обнулить/(4)выполнить перевод или сменить счет/(5)Перезаполнить данные");
            int otvet2 = Convert.ToInt32(Console.ReadLine());
            int schet2; 

            switch (otvet2)
            {
                case 1:
                    dob(1); break;
                case 2:
                    umen(1); break;
                case 3:
                    obnul(); break;
                case 4:
                    return;
                case 5:
                    otk(this.nom, "1", this.sum);break;
                
            }
        }
    }
}
  