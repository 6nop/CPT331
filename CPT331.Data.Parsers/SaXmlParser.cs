﻿#region Using References

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

using CPT331.Core.Extensions;
using CPT331.Core.Logging;
using CPT331.Core.ObjectModel;

#endregion

namespace CPT331.Data.Parsers
{
	public class SaXmlParser : XmlParser
	{
		public SaXmlParser(string dataSourceDirectory)
			 : base(dataSourceDirectory, SA)
		{
		}

		internal const string SA = "SA";

		protected override void OnParse(string fileName, List<Crime> crimes)
		{
			OutputStreams.WriteLine($"Parsing {SA} data...");

			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);

			State state = StateRepository.GetStateByAbbreviatedName(SA);
			List<LocalGovernmentArea> localGovernmentAreas = LocalGovernmentAreaRepository.GetLocalGovernmentAreasByStateID(state.ID);

			Dictionary<string, Offence> offences = new Dictionary<string, Offence>();
			OffenceRepository.GetOffences().ForEach(m => offences.Add(m.Name.ToUpper(), m));

			XmlNodeList workSheetXmlNodeList = xmlDocument.SelectNodes("/Workbook/Worksheet");
			foreach (XmlNode workSheetXmlNode in workSheetXmlNodeList)
			{
				string localGovernmentAreaName = workSheetXmlNode.Attributes["Name"].Value;
				if (localGovernmentAreaName.Contains("(") == true)
				{
					localGovernmentAreaName = localGovernmentAreaName.Substring(0, localGovernmentAreaName.IndexOf("(")).Trim();
				}

				LocalGovernmentArea localGovernmentArea = localGovernmentAreas.Where(m => (m.Name.EqualsIgnoreCase(localGovernmentAreaName) == true)).FirstOrDefault();

				XmlNodeList xmlNodeList = workSheetXmlNode.SelectNodes("Table/Row[count(Cell) = 6]");

				foreach (XmlNode xmlNode in xmlNodeList)
				{
					string offenceName = xmlNode.ChildNodes[0].InnerText.ToUpper();
					if ((String.IsNullOrEmpty(offenceName) == false) && (offenceName.StartsWith("-") == true))
					{
						offenceName = offenceName.Substring(offenceName.IndexOf("-") + 1).Trim();

						Offence offence = null;
						if ((String.IsNullOrEmpty(offenceName) == false) && (offences.ContainsKey(offenceName) == true))
						{
							offence = offences[offenceName];
						}

						for (int i = 1, j = 2009; i < 6; i++, j++)
						{
							int count = Convert.ToInt32(xmlNode.ChildNodes[i].InnerText);

							crimes.Add(new Crime(count, localGovernmentArea.ID, 1, offence.ID, j));
						}
					}
				}
			}

			base.OnParse(fileName, crimes);
		}
	}
}
