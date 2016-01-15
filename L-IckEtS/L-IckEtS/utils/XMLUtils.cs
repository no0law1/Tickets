using L_IckEtS.model;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace L_IckEtS_EF.utils
{
    public class XMLUtils
    {
        public static XElement ticketToXml(Ticket t)
        {
            return new XElement("ticket",
                    new XAttribute("type", t.id_type),
                    new XAttribute("ticketID", t.code),
                    new XAttribute("status", t.STATE));
        }

        public static XElement ownerToXml(Client c)
        {
            return new XElement("owner",
                    new XAttribute("ownerID", c.id),
                    new XAttribute("name", c.name),
                    new XAttribute("email", c.email),
                    c.name);
        }

        public static XElement supervisorToXml(Admin admin)
        {
            return new XElement("supervisor",
                    new XAttribute("technicianID", admin.id),
                    new XAttribute("name", admin.name),
                    new XAttribute("email", admin.email),
                    admin.name);
        }

        public static XElement typeToXml(Type tp)
        {
            if (tp == null)
            {
                return new XElement("type");
            }

            return new XElement("type",
                    new XAttribute("typeID", tp.id),
                    new XAttribute("name", tp.name),
                    tp.name);
        }

        public static XElement actionsToXml(IEnumerable<Action> actions)
        {
            XElement actions_xml = new XElement("actions");
            foreach (Action a in actions)
            {
                actions_xml.Add(actionToXml(a));
            }
            return actions_xml;
        }

        public static XElement actionToXml(Action a)
        {
            return new XElement("action",
                    new XAttribute("orderNum", a.step_order),
                    new XAttribute("beginDate", a.created_at.ToShortDateString()),
                    new XAttribute("endDate", a.ended_at == null ? "" : a.ended_at.GetValueOrDefault().ToShortDateString()));
        }
    }
}
