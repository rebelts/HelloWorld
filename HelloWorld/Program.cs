// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");

// Load XML document
XmlDocument xmlDoc = new XmlDocument();
xmlDoc.Load("sample.xml"); // Replace with your XML file path

// Get the root node
XmlNode? rootNode = xmlDoc.DocumentElement;

if (rootNode != null)
{
    // Print values of all child nodes
    foreach (XmlNode childNode in rootNode.ChildNodes)
    {
        Console.WriteLine($"Tag Name: {childNode.Name}, Value: {childNode.InnerText}");
    }
}

