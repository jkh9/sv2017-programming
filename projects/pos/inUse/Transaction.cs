// 
// Point of sale
//

// V0.10 17-Ene-2018, Sabater, Pestana, Saorin, Santana
//          Created class Transaction
// V0.12 02-Mar-2018 Nacho: Added "amount", removed [] in products

using System;

public class Transaction
{
    protected DateTime date;
    protected double amount;
    protected Product product; // Not used yet

    public Transaction(DateTime date, double amount)
    {
        this.date = date;
        this.amount = amount;
    }

    public DateTime GetDate() { return date; }
    public void SetDate(DateTime date) { this.date = date; }
    public double GetAmount() { return amount; }
    public void SetAmount(double amount) { this.amount = amount; }
}
