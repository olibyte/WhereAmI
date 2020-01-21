using System;
using System.Device.Location;

namespace WhereAmI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting GeoCoordinate Watcher...");

            // 1. Add a Reference to System.Device.dll

            // 2. Use the GeoCoordinate Watcher
            var watcher = new GeoCoordinateWatcher();

            watcher.StatusChanged += (s, e) =>
            {
                Console.WriteLine($"GeoCoordinateWatcher:StatusChanged:{e.Status}");
            };
            watcher.PositionChanged += (s, e) =>
            {
                Console.WriteLine($"GeoCoordinateWatcher:StatusChanged:{e.Position.Location}");
            };

            watcher.MovementThreshold = 100;

            watcher.Start();

            // 3. Use the Map Image REST API

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
