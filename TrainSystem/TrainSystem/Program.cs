// See https://aka.ms/new-console-template for more information
using TrainSystem;
using static System.Console;

#region Engine Test
try
{
    // Best case
    Engine engine2 = new("CP 8002", "48807", 147700, 4400);
    WriteLine(engine2);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Missing string
    Engine engine1 = new("", "48807", 147700, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Missing string
    Engine engine1 = new("CP 8002", "", 147700, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Whitespace strings
    Engine engine1 = new("   CP 8002   ", "48807", 147700, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Weight not in 100lbs increments
    Engine engine1 = new("CP 8002", "48807", 147701, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Weight is zero
    Engine engine1 = new("CP 8002", "48807", 0, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // Weight is negative
    Engine engine1 = new("CP 8002", "48807", -147700, 4400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // HP above limit
    Engine engine1 = new("CP 8002", "48807", 147700, 5600);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // HP below limit
    Engine engine1 = new("CP 8002", "48807", 147700, 3400);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

try
{
    // HP not in increments of 100
    Engine engine1 = new("CP 8002", "48807", 147700, 4402);
    WriteLine(engine1);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}
#endregion
WriteLine();
#region RailCar Test
//Best case
try
{
    RailCar railCar1 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    WriteLine(railCar1);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Empty string
try
{
    RailCar railCar2 = new("", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    WriteLine(railCar2);
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}

//Whitespace
try
{
    RailCar railCar2 = new("   18172     ", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//!100lbs increments
try
{
    RailCar railCar2 = new("18172", 38801, 110000, 130200, RailCarType.BOX_CAR, true);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//!100lbs
try
{
    RailCar railCar2 = new("18172", 38800, 110002, 130200, RailCarType.BOX_CAR, true);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//!100lbs
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130203, RailCarType.BOX_CAR, true);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Best Gross weight
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    railCar2.RecordScaleWeight(150000);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Gross weight !100lbs increment
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    railCar2.RecordScaleWeight(150001);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Gross weight < Light Weight
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    railCar2.RecordScaleWeight(15000);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Gross weight > Gross Load Limit
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    railCar2.RecordScaleWeight(1500000);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Gross weight to IsFull (true)
try
{
    RailCar railCar2 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    railCar2.RecordScaleWeight(150000);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//Gross weight to IsFull (false)
try
{
    RailCar railCar2 = new("18176", 38800, 110000, 130200, RailCarType.COVERED_HOPPER, true);
    railCar2.RecordScaleWeight(90000);
    WriteLine(railCar2);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

//More RailCars for Train test
try
{
    RailCar railCar3 = new("69420", 38800, 110000, 130200, RailCarType.COAL_CAR, true);
    railCar3.RecordScaleWeight(150000);
    WriteLine(railCar3);
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}
#endregion
WriteLine();
#region Train Test
try
{
    Engine engine2 = new("CP 8002", "48807", 147700, 4400);
    RailCar railCar1 = new("18172", 38800, 110000, 130200, RailCarType.BOX_CAR, true);
    RailCar railCar2 = new("18176", 38800, 110000, 130200, RailCarType.COVERED_HOPPER, true);
    RailCar railCar3 = new("69420", 38800, 110000, 130200, RailCarType.COAL_CAR, true);

    Train train1 = new(engine2);

    train1.Add(railCar1);
    train1.Add(railCar2);
    train1.Add(railCar3);

    WriteLine($"{train1.GrossWeight},{train1.MaxGrossWeight},{train1.TotalCars}");
}
catch (ArgumentException ex)
{
    WriteLine(ex.Message);
}
#endregion