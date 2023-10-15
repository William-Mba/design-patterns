using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite;

interface IEmployee
{
    float GetSalary();
    string GetName();
    string GetRole();
}

class Developer : IEmployee
{
    private string _name;
    private float _salary;

    public Developer(string name, float salary)
    {
        _name = name;
        _salary = salary;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetRole()
    {
        return "Developer";
    }

    public float GetSalary()
    {
        return _salary;
    }
}

class Designer : IEmployee
{
    private string _name;
    private float _salary;

    public Designer(string name, float salary)
    {
        _salary = salary;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetRole()
    {
        return "Designer";
    }

    public float GetSalary()
    {
        return _salary;
    }
}

class Organization
{
    protected List<IEmployee> Employees;

    public Organization()
    {
        Employees = new();
    }

    public void AddEmployee(IEmployee employee)
    {
        Employees.Add(employee);
    }

    public float GetNetSalaries()
    {
        float netSalary = 0;

        foreach (var employee in Employees)
        {
            netSalary += employee.GetSalary();
        }
        return netSalary;
    }
}