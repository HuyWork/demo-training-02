using AdvanceApp;
using System.Collections;

class SmartPhone
{
    string name = default!;
    string producer = default!;
    float price;

    public string Name { get => name; set => this.name = value; }
    public string Producer { get => producer; set => this.producer = value; }
    public float Price { get => price; set => this.price = value; }

    public SmartPhone() { }
    public SmartPhone(string name, string producer, float price)
    {
        this.Name = name;
        this.Producer = producer;
        this.Price = price;
    }

    public override string ToString()
    {
        return "Name: " + Name + " | Producer: " + Producer + " | Price: " + Price;
    }
}

class SmartPhoneComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        SmartPhone? a = x as SmartPhone;
        SmartPhone? b = y as SmartPhone;

        if(a != null && b != null)
        {
            if (a.Price > b.Price)
            {
                return 1;
            }
            else if (a.Price == b.Price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        else { throw new InvalidOperationException(); }
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        /*#region ArrayList

        ArrayList list = new ArrayList();
        list.Add(5);
        list.Add(10);
        list.Add(3);

        list.Sort();
        foreach (int i in list)
        {
            Console.Write("{0,5}", i);
        }

        #endregion*/

        Person person = new Person("Jason", 18, 1.8f, 50);
        Console.WriteLine(person.ToString());

        Student student = new Student();
        student.Study();

    }

}
