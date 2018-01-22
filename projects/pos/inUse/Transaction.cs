// V0.10 17-Ene-2018, Sabater, Pestana, Saorin, Santana
//          Created class Transaction

using System;

class Transaction
{
    protected Product[] products;
    DateTime date;

    public Transaction(Product[] products, DateTime date)
    {
        this.date = date;
        this.products = products;
    }

    public void Add()
    {
        // TODO
    }

    public DateTime GetDate() { return date; }

    public void SetDate(DateTime date) { this.date = date; }

    public Product[] GetProducts() { return products; }

    public void SetProducts(Product[] products) { this.products = products; }
}
