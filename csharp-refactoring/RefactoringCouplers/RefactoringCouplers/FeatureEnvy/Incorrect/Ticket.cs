﻿namespace RefactoringCouplers.FeatureEnvy.Incorrect;
public class Ticket
{
    public Ticket(bool available, int price)
    {
        IsAvailable = available;
        Price = price;
    }

    public bool IsAvailable { get; private set; }
    public int Price { get; init; }

    public bool CanAfford(int points)
    {
        return points >= Price;
    }

    public void BuyTicket()
    {
        IsAvailable = false;
    }
}