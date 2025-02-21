using System.IO;
using System.Xml.Serialization;

namespace DataBusinessLogicLibrary.Context.Common.DB_Configuration
{
	[XmlRoot(ElementName = "MerkStaticConfiguration")]
	public class MerkConfiguration
	{
		private static string _userName = "merkuser";
		private static string _password = "m3rkus3r";

		[XmlIgnore]
		public static string MerkConfigurationFilePath = @"C:\ProgramData\Merk\MerkConfiguration.xml";

		[XmlElement(ElementName = "DBServer")]
		public string DBServer { get; set; }

		[XmlElement(ElementName = "MerkDBName")]
		public string MerkDBName { get; set; }

		public static void CreateMerkConfigurationXMLFile()
		{
			MerkConfiguration merkConfiguration = new MerkConfiguration();
			merkConfiguration.DBServer = "Override with DB Server";
			merkConfiguration.MerkDBName = "Override with Merk DB Name";

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(MerkConfiguration));
			string direcotryPath = Path.GetDirectoryName(MerkConfigurationFilePath);
			if (!Directory.Exists(direcotryPath))
				Directory.CreateDirectory(direcotryPath);
			using (FileStream stream = new FileStream(MerkConfigurationFilePath, FileMode.Create))
				xmlSerializer.Serialize(stream, merkConfiguration);
		}

		public static TXmlType LoadXmlFile<TXmlType>()
		{
			TXmlType xmlFile;

			using (FileStream stream = new FileStream(MerkConfigurationFilePath, FileMode.Open))
			{
				XmlSerializer xml = new XmlSerializer(typeof(TXmlType));
				xmlFile = (TXmlType)xml.Deserialize(stream);
				stream.Close();
			}

			return xmlFile;
		}

		public static bool LoadConfiguration()
		{
			MerkConfiguration configuration = LoadXmlFile<MerkConfiguration>();
			GetMerkSolutionsConnectionString(configuration.DBServer, configuration.MerkDBName, false);
			return true;
		}

		private static string GetMerkSolutionsConnectionString(string serverName, string databaseName, bool userMerkCred)
		{
			if (userMerkCred)
				return string.Format(
					@"metadata=res://*/MerkSolutionsEntities.csdl|res://*/MerkSolutionsEntities.ssdl|res://*/MerkSolutionsEntities.msl;
				provider=System.Data.SqlClient;
				provider connection string=""data source={0};
				initial catalog={1};
				persist security info=True;
				user id={2};password={3};
				MultipleActiveResultSets=True;
				App=EntityFramework"""
					, serverName, databaseName, _userName, _password);

			return string.Format(
				@"metadata=res://*/Context.MerkFinanceEntities.csdl|res://*/Context.MerkFinanceEntities.ssdl|res://*/Context.MerkFinanceEntities.msl;
					provider=System.Data.SqlClient;
					provider connection string=&quot;
					data source={0};
					initial catalog={1};
					integrated security=True;
					MultipleActiveResultSets=True;
					App=EntityFramework&quot;"" providerName = ""System.Data.EntityClient""", 
				serverName,
				databaseName);
		}
	}
}
