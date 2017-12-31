using System.Xml;

namespace EldritchHorrorWpf
{
    class BoxContentParser
    {
        public XmlReader Reader;

        public BoxContentParser(string filePath)
        {
            Reader = XmlReader.Create(filePath);
        }

        public string GetFirstName()
        {
            while (Reader.Read())
            {
                if ((Reader.NodeType == XmlNodeType.Element) && (Reader.Name == "Name"))
                {
                    return Reader.ReadElementContentAsString();
                }
            }

            return "";
        }
    }
}