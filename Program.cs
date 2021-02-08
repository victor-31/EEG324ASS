using System;


public override string Tostring()
{
    return string.Format("{1}: \n{2}: \n{3}: \n{4}:", "openingSqlconnection", "closingSqlconnection", "openingOracleconnection", "closingOracleconnection");
}

public override string Tostring()
{
    return string.Format("{5}:", "opening XYZ Sqlconnection");
}

public class DbconnectionTest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("openimgSqlconnection is {1}:");
        Console.WriteLine("closingSqlconnection is {2}:");
        Console.WriteLine("openingOracleconnection is {3}:");
        Console.WriteLine("closingOracleconnection is {4}:");
        Console.WriteLine("opening XYZ Sqlconnection is {5}:");
    }
}