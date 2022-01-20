// See https://aka.ms/new-console-template for more information
using StructDemo01;

Resolution hdResolution = new(1920, 1080);
var cinemaResolution = hdResolution;
//Using class and not struct, the value is changed for whole class instead of =
//Just the variable
cinemaResolution.Width = 2048;

Console.WriteLine($"HD resolution is {hdResolution.Width} pixels wide and {hdResolution.Height} pixels tall");
Console.WriteLine($"Cinema resolution is {cinemaResolution.Width} pixels wide and {cinemaResolution .Height} pixels tall");
//VideoMode someVideoMode = new();

