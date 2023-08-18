
using Vehicles.Core.Interfaces;
using Vehicles.IO;
using Vehicles.IO.Interfaces;
using VehiclesExtension.Core;
using VehiclesExtension.Factories;
using VehiclesExtension.Factories.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IVehicleFactory vehicleFactory = new VehicleFactory();

IEngine engine = new Engine(reader, writer, vehicleFactory);

engine.Run();