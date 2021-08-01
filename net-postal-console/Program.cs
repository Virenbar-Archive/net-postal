using System;

using NetPostal;

namespace net_postal_console
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var Parsed = Parser.Parse("781 Franklin Ave Crown Heights Brooklyn NYC NY 11216 USA");
			Console.WriteLine("Hello World!");
		}
	}
}