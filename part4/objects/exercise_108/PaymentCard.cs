namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here

      this.balance = openingBalance;
    }

    public void EatLunch()
    {
        double lunch = 10.60;

        if ( lunch <= this.balance )
        { 
        this.balance = this.balance - lunch;
        }
    }

    public void DrinkCoffee()
    {
        double coffee = 2.0;

        if ( coffee <= this.balance )
        { 
        this.balance = this.balance - coffee;
        }
    }

    public override string ToString()
    {
      // write code here

      return "The card has a balance of " + this.balance + " euros";
    }
  }
}