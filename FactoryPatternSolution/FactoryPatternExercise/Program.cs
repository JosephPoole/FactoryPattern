using FactoryPatternExercise;

Console.WriteLine("Please enter the number of wheels your vehicle has, 2 or 4?");
int userInput = Convert.ToInt32(Console.ReadLine());
var userVehicle = VehicleFactory.GetVehicle(userInput);
userVehicle.Drive();