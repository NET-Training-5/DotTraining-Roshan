class Person 
{
    //memebers : methods ,feilds
    public string fullname;
    public DateTime dob;
    public string address; 
    public char gender;
    public float weight;

    public float height;

    public double FindAge()
    {
        var age = DateTime.now;
        ageYears= ageSpan.TotalDays/365;
    }
    
}