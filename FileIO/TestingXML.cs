// replace adding the player to the records list with checking if the player is already on the list.
// we should be able to use some method call to accomplish this.
// records.Add(player);
using System.Xml;
using System.Xml.Serialization;

public List<User> ReadFromXml() {
    StreamReader reader = new StreamReader("./xml");
    var records = (List<User>?)Serializer.Deserialize(reader);
    reader.Close();
    return records;
}

public void existingUser() {
    XmlDocument doc = new XmlDocument();
    doc.Load("./xml");
    XmlNodeList nodeList = doc.SelectNodes("/ArrayOfUser/User");

}

// if userName and passWord DON'T exist in xml, make new user



// else skip newUser,