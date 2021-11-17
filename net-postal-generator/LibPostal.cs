using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using System.IO;

namespace net_postal_generator
{
	internal class LibPostal : ILibrary
	{
		public override void Postprocess(Driver driver, ASTContext ctx)
		{
		}

		public override void Preprocess(Driver driver, ASTContext ctx)
		{
		}

		public override void Setup(Driver driver)
		{
			var Dir = Path.Combine(Directory.GetCurrentDirectory(), "libpostal");
			var PO = driver.ParserOptions;
			//PO.LanguageVersion = CppSharp.Parser.LanguageVersion.C99_GNU;
			PO.Verbose = true;
			//PO.AddIncludeDirs(@"C:\msys64\mingw64\x86_64-w64-mingw32\include");
			//PO.AddSystemIncludeDirs(@"C:\msys64\mingw64\x86_64-w64-mingw32\include");

			var O = driver.Options;
			O.OutputDir = "Postal";
			O.GeneratorKind = GeneratorKind.CSharp;
			O.Verbose = true;

			var M = O.AddModule("NetPostal");
			M.Headers.Add("libpostal.h");
			//M.IncludeDirs.Add(Dir);
			//M.IncludeDirs.Add(@"C:\msys64\mingw64\x86_64-w64-mingw32\include");
			//M.LibraryDirs.Add(@"C:\msys64\mingw64\x86_64-w64-mingw32\include");
			//M.Libraries.Add("libpostal.lib");
		}

		public override void SetupPasses(Driver driver)
		{
		}
	}
}