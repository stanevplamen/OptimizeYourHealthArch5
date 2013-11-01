using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using MessageBox = WPFMessageBox.MessageBox;

namespace ProjectHealth
{
    public class MyData
    {
        /// <summary>
        /// Saves items to MyData.xml file in bin folder.
        /// </summary>
        /// <param name="items"></param>
        public void Save(System.Windows.Data.CollectionView items)
        {
            XDocument xdoc = new XDocument();

            XElement xeRoot = new XElement("Data");
            XElement xeSubRoot = new XElement("Rows");

            foreach (var item in items)
            {
                StringNode operatedNode = (StringNode)item;

                XElement xRow = new XElement("Row");
                xRow.Add(new XElement("col1", operatedNode.Date));
                xRow.Add(new XElement("col2", operatedNode.Title));
                xRow.Add(new XElement("col3", operatedNode.Description));

                xeSubRoot.Add(xRow);
            }
            xeRoot.Add(xeSubRoot);
            xdoc.Add(xeRoot);

            xdoc.Save("MyData.xml");
        }

        /// <summary>
        /// Gets data from MyData.xml as rows.  
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetRows()
        {
            List<StringNode> rows = new List<StringNode>();

            if (File.Exists("MyData.xml"))
            {
                try
                {
                    // Create the query 
                    var rowsFromFile = from c in XDocument.Load(
                        "MyData.xml").Elements(
                        "Data").Elements("Rows").Elements("Row")
                                select c;

                        // Execute the query 
                    foreach (var row in rowsFromFile)
                    {
                        rows.Add(new StringNode(row.Element("col1").Value, row.Element("col2").Value, row.Element("col3").Value));
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        throw new Exception("Error occured while reading the events archive.\nClick on details for more information.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.ShowError(ex);
                    } 
                    //MessageBox.Show("Error occured while reading the events archive");
                }
            }
            return rows;
        }
    }
}
