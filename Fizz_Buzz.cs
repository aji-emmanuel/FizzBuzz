namespace Fizz_Buzz
{
    public class Numbers
    {
      static void Main(string[] args)
      {
          for(int i=1; i<=100; i++)
          {
              if(i%3 == 0){
                  console.writeline("Fizz");
              }else if (i%5 ==0){
                  console.writeline("Buzz");
              }else if(i%3==0 && i%5==0){
                  console.writeline("FizzBuzz")
              }else{
                  console.writeline(i)
              }
          }
      }
    
    }
}