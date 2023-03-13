using System;
using System.Collections.Generic;

public class solver{

    private static double frequency;
    private static double capacitance;
    private static double Vi;
    private static double resistance;
    private static double Xc;
    private static double Vo;

    static void Main(string[] args){
        Console.WriteLine("Frequency:");
        frequency = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Capacitance:");
        capacitance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input Voltage:");
        Vi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Resistance:");
        resistance = Convert.ToDouble(Console.ReadLine());
        Xc = calc_Xc(frequency, capacitance);
        Vo = calc_Vo(Xc, Vi, resistance);
        Console.WriteLine("Output Voltage is: " + Vo.ToString());
        Console.WriteLine("Capacitor Reactance is: " + Xc.ToString());
        Console.ReadKey();
    }

    private static double calc_Xc(double frequency, double capacitance){
        double res;
        res = 1/(2*Math.PI*frequency*capacitance);
        return res;
    }

    private static double calc_Vo(double Xc, double Vi, double resistance){
        double res;
        res = (Xc*Vi)/Math.Sqrt(resistance*resistance + Xc*Xc);
        return res;
    }
}