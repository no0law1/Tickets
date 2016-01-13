
namespace L_IckEtS_EF.utils
{
    class XMLUtils
    {
        //static internal XElement ticketToXml(ticket t)
        //{
        //    return new XElement("ticket",
        //            new XAttribute("type", t.id_type),
        //            new XAttribute("ticketID", t.code),
        //            new XAttribute("status", t.STATE));
        //}

        //static internal XElement ownerToXml(client c)
        //{
        //    return new XElement("owner",
        //            new XAttribute("ownerID", c.id),
        //            new XAttribute("name", c.NAME),
        //            new XAttribute("email", c.email),
        //            c.NAME);
        //}

        //static internal XElement supervisorToXml(administrator admin)
        //{
        //    return new XElement("supervisor",
        //            new XAttribute("technicianID", admin.id),
        //            new XAttribute("name", admin.NAME),
        //            new XAttribute("email", admin.email),
        //            admin.NAME);
        //}

        //static internal XElement typeToXml(type tp)
        //{
        //    if (tp == null)
        //    {
        //        return new XElement("type");
        //    }

        //    return new XElement("type",
        //            new XAttribute("typeID", tp.id),
        //            new XAttribute("name", tp.NAME),
        //            tp.NAME);
        //}

        //static internal XElement actionsToXml(IEnumerable<action> actions)
        //{
        //    XElement actions_xml = new XElement("actions");
        //    foreach (action a in actions)
        //    {
        //        actions_xml.Add(actionToXml(a));
        //    }
        //    return actions_xml;
        //}

        //static internal XElement actionToXml(action a)
        //{
        //    return new XElement("action",
        //            new XAttribute("orderNum", a.step_order),
        //            new XAttribute("beginDate", a.created_at.ToShortDateString()),
        //            new XAttribute("endDate", a.ended_at==null?"":a.ended_at.GetValueOrDefault().ToShortDateString()));
        //}
    }
}
