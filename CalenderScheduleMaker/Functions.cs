using System.IO;

namespace CalenderScheduleMaker
{
    public class Functions
    {
        public void ExportUserSettings(string filename, UserSettings userSettings)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(UserSettings));

            StreamWriter streamWriter = new StreamWriter(filename, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(streamWriter, userSettings);
            streamWriter.Close();
        }
        public UserSettings ImportUserSettings(string filePath)
        {
            UserSettings userSettings = new UserSettings();

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(UserSettings));
            StreamReader streamReader = new StreamReader(filePath, new System.Text.UTF8Encoding(false));
            userSettings = (UserSettings)serializer.Deserialize(streamReader);
            streamReader.Close();

            return (userSettings);
        }
    }
}
