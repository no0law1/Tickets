using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using L_IckEtS_EF.utils;
using L_IckEtS.model;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using System.Xml;

namespace L_IckEtSTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Ticket ticket = new Ticket(1, "MyState", "MyDescription", default(DateTime), default(DateTime), "MyPriority", default(DateTime), 1, 1, 1);
            Client client = new Client(1, "MyName", "MyMail");
            Admin admin = new Admin(1, "MyAdminName", "MyAdminName");
            L_IckEtS.model.Type type = new L_IckEtS.model.Type(1, "MyTicketType");
            LinkedList<L_IckEtS.model.Action> actions = new LinkedList<L_IckEtS.model.Action>();
            for (int i = 0; i < 3; i++)
            {
                actions.AddLast(new L_IckEtS.model.Action("MyNote"+i, i, 1, i, 1));
            }

            XElement ticket_xml = XMLUtils.ticketToXml(ticket);
            ticket_xml.Add(XMLUtils.ownerToXml(client));
            ticket_xml.Add(XMLUtils.supervisorToXml(admin));
            ticket_xml.Add(new XElement("description", ticket.description));
            ticket_xml.Add(XMLUtils.typeToXml(type));
            ticket_xml.Add(XMLUtils.actionsToXml(actions));

            XDocument final = new XDocument(new XDeclaration("1.0", "utf-8", null), ticket_xml);

            //StringWriter returns encoding utf-16. No worries :)
            var wr = new StringWriter();
            //TODO: Save into file
            final.Save(wr);

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", XmlReader.Create(new StringReader(File.ReadAllText())));

            final.Validate(schemas,
                (o, e) =>
                {
                    Console.WriteLine("{0}", e.Message);
                });
        }
    }
}
