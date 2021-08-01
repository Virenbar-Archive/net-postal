using System;

namespace NetPostal
{
	public static class Parser
	{
		public static string Parse(string address)
		{
			using (var h = libpostal.libpostal_get_address_parser_default_options())
			using (var f = libpostal.libpostal_parse_address(address, h))
			{
				var t = f.components;
				var tt = t;
			}
			return "";
		}
	}
	public static class ParserA
	{
		public static string Parse(string address)
		{
			LibPostalNet.libpostal.LibpostalSetup();
			LibPostalNet.libpostal.LibpostalSetupParser();
			LibPostalNet.libpostal.LibpostalSetupLanguageClassifier();

			using (var h = LibPostalNet.libpostal.LibpostalGetAddressParserDefaultOptions())
			using (var response = LibPostalNet.libpostal.LibpostalParseAddress(address, h))
			{
				var t = response.Results;
				var tt = t;

				LibPostalNet.libpostal.LibpostalAddressParserResponseDestroy(response);

				// Teardown (only called once at the end of your program)
				LibPostalNet.libpostal.LibpostalTeardown();
				LibPostalNet.libpostal.LibpostalTeardownParser();
				LibPostalNet.libpostal.LibpostalTeardownLanguageClassifier();
			}
			return "";
		}
	}
}