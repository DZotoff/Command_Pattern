using com_strat;
using System;
using System.Collections.Generic;

// Command interface
public interface Command
{
    void Ex();
}
// Main class
class Program
{
    static void Main()
    {
        // Setup IoT devices
        var light = new Light();
        var thermostat = new Thermostat();

        // Create commands for the devices
        var lightOnCm = new LightOn(light);
        var lightOffCm = new LightOff(light);
        var thermIncCm = new ThermInc(thermostat);
        var thermDecCm = new ThermDec(thermostat);

        

        // Setup invokers
        var Controller1 = new Invoker();
        var Controller2 = new Invoker();
        

        
        // UI
        Console.WriteLine("The List of commands: 1 - Turn Off the light, 2 - Turn On the light, 3 - Increase thermostat temperature, 4 - Decrease thermostat temperature");

        // Simulate user interaction
        while (true)
        {
            Console.Write("Enter a command (0 to exit): ");
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    break;
                }

                switch (userInput)
                {
                    case 1:
                        Controller1.SetCommand(lightOffCm); // Set command to turn off light
                        Controller1.PressButton(); // Turn off light
                        break;
                    case 2:
                        Controller1.SetCommand(lightOnCm); // Set command to turn on light
                        Controller1.PressButton(); // Turn on light
                        break;
                    case 3:
                        Controller2.SetCommand(thermIncCm); // Set command to increase thermostat temperature
                        Controller2.PressButton(); // Increase thermostat temperature
                        break;
                    case 4:
                        Controller2.SetCommand(thermDecCm); // Set command to decrease thermostat temperature
                        Controller2.PressButton(); // Decrease thermostat temperature
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            catch { continue; }
            // Display device status
            Console.WriteLine($"Light status: {(light.Is ? "ON" : "OFF")}");
            Console.WriteLine($"Thermostat temperature: {thermostat.Temp}");
        }
    }
}
