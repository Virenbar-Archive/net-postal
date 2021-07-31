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
}