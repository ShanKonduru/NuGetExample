// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Text.RegularExpressions;
using System.Xml;

string currentValue = "1.23.456";
Version  curVersion = new(currentValue);
Console.WriteLine("Current verion " + curVersion.ToString());
Version  newVersion = MyVersion.AddMajorVersion(curVersion);
Console.WriteLine("After Updating Major " + newVersion.ToString());
newVersion = MyVersion.AddMinorVersion(curVersion);
Console.WriteLine("After Updating Minor " + newVersion.ToString());
newVersion = MyVersion.AddBuildVersion(curVersion);
Console.WriteLine("After Updating Build " + newVersion.ToString());
newVersion = MyVersion.AddBuildVersion(curVersion, 1000);
Console.WriteLine("After Updating Build " + newVersion.ToString());

/*
using System.Text.RegularExpressions;
using System.Xml;

string specFilePath = @"..\ScientificCalculator.csproj.nuspec";
// instantiate XmlDocument and load XML from file
XmlDocument doc = new XmlDocument ();
doc.Load (specFilePath);

// get a list of nodes - in this case, I'm selecting all <AID> nodes under
// the <GroupAIDs> node - change to suit your needs
XmlNodeList aNodes = doc.SelectNodes ("/package/metadata/");

// loop through all AID nodes
foreach (XmlNode aNode in aNodes) {
    // grab the "version" attribute
    XmlAttribute attribute = aNode.Attributes["version"];

    // check if that attribute even exists...
    if (attribute != null) {
        // if yes - read its current value
        string currentValue = attribute.Value;

        // here, you can now decide what to do - for demo purposes,
        // I just set the ID value to a fixed value if it was empty before
        if (string.IsNullOrEmpty (currentValue)) {
            attribute.Value = "1.0.0";
        } else {
            // (?<Major>\d*)\.(?<Minor>\d*)(\.(?<Build>\d*)(\.(?<Revision>\d*))?)?
            var regularExpression = @"^(\d+\.)?(\d+\.)?(\d+\.)?(\*|\d+)$";
            var regex = Regex.IsMatch (currentValue, regularExpression, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            Console.WriteLine (regex);
        }
    }
}

// save the XmlDocument back to disk
doc.Save (specFilePath);
*/