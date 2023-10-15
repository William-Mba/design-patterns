using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight;

// Anything that willbe cached is flyweight
// Type of tea here will be flyweights.
class KarakTea
{
}

// Acts as a factory an save the tea
class TeaMaker
{
    private Dictionary<string, KarakTea> _availableTea = new();

    public KarakTea Make(string preference)
    {
        if (!_availableTea.ContainsKey(preference))
        {
            _availableTea[preference] = new KarakTea();
        }
        return _availableTea[preference];
    }
}

class TeaShop
{
    private Dictionary<int, KarakTea> _orders = new();
    private readonly TeaMaker _teaMaker;

    public TeaShop(TeaMaker teaMaker)
    {
        _teaMaker = teaMaker ??
        throw new ArgumentNullException(nameof(teaMaker), $"{nameof(teaMaker)} cannot be null");
    }

    public void TakeOrder(string teaType, int table)
    {
        _orders[table] = _teaMaker.Make(teaType);
    }

    public void Serve()
    {
        foreach (var table in _orders.Keys)
        {
            Console.WriteLine($"Serving Tea to table # {table}");
        }
    }
}

