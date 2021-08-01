using System;
using CppSharp;

namespace net_postal_generator

{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ConsoleDriver.Run(new LibPostal());
			Console.WriteLine("Hello World!");
		}
	}
}