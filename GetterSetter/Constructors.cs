class Fifa
{
    public string host;
    public DateTime year;

    public string winner;

    public string[] teams;

    public Fifa()  // default constructor. parameterless constructor.
    {



    }
    public Fifa(string h) //parameterized constructor
    {
        host = h;
    }


    public Fifa(string h, DateTime y, string w, string[]tms) //parameterized constructor
    {
        host = h;
        year = y;
        winner = w;
        teams = tms;
    }

    //Garbage  collection

}