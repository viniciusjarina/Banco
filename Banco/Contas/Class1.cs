using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banco.Contas
{
	public static class ObjectExtensions
	{
		public static string AsXml (this object resource) 
		{
			var stringWriter = new StringWriter();
			new XmlSerializer (resource.GetType ()).Serialize (stringWriter, resource);
			return stringWriter.ToString ();
		}
	}
}
