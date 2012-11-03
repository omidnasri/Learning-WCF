// � 2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net
using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Channels;
using ContentTypes;
using System.Xml;
using System.ServiceModel;


namespace GigEntry
{
    public class SaveGigRequest : Message
    {

        private const string Action = "http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/SaveGig";
        private const string ns = "http://www.thatindigogirl.com/samples/2006/06";

        private Message m_innerMessage;

        private LinkItem m_linkItem = new LinkItem();
        public LinkItem Item
        {
            get { return m_linkItem; }
            set { m_linkItem = value; }
        }

        public SaveGigRequest()
        {
        }

        public SaveGigRequest(LinkItem linkItem, MessageVersion version)
        {
            m_innerMessage = Message.CreateMessage(version, Action);
            this.m_linkItem = linkItem;
        }

        public SaveGigRequest(Message message)
        {
            this.m_innerMessage = message;

            XmlDictionaryReader xmlReader = message.GetReaderAtBodyContents();
            this.m_linkItem = LinkItemHelper.ReadLinkItem(xmlReader);
        }

        public SaveGigRequest(XmlReader reader, MessageVersion version)
        {
            m_innerMessage = Message.CreateMessage(version, Action);

            XmlDictionaryReader xmlReader = XmlDictionaryReader.CreateDictionaryReader(reader);
            this.m_linkItem = LinkItemHelper.ReadLinkItem(xmlReader);
        }

        public override MessageHeaders Headers
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return this.m_innerMessage.Headers;
            }
        }

        protected override void OnWriteBodyContents(System.Xml.XmlDictionaryWriter xmlWriter)
        {
            /* What the message should look like...
             
    <SaveGigRequest xmlns="http://www.thatindigogirl.com/samples/2006/06">
    <Item xmlns:b="http://schemas.thatindigogirl.com/samples/2006/06" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
    <b:Id>xs:int</b:Id>
    <b:Title>xs:string</b:Title>
    <b:Description>xs:string</b:Description>
    <b:DateStart>xs:dateTime</b:DateStart>
    <b:DateEnd>xs:dateTime</b:DateEnd>
    <b:Url>xs:string</b:Url>
    </Item>
    </SaveGigRequest>
*/

            xmlWriter.WriteStartElement("SaveGigRequest", ns);
            xmlWriter.WriteStartElement("Item", ns);

            LinkItemHelper.WriteLinkItem(this.m_linkItem, xmlWriter);

            xmlWriter.WriteEndElement(); //Item
            xmlWriter.WriteEndElement(); //GetGigResponse


        }

        public override MessageProperties Properties
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return this.m_innerMessage.Properties;
            }
        }

        public override MessageVersion Version
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return m_innerMessage.Version;
            }
        }
    }

    public class GetGigResponse : Message
    {

        private const string Action = "http://www.thatindigogirl.com/samples/2006/06/GigManagerServiceContract/GetGigResponse";
        private const string ns = "http://www.thatindigogirl.com/samples/2006/06";

        private Message m_innerMessage;

        private LinkItem m_linkItem = new LinkItem();

        public LinkItem Item
        {
            get { return m_linkItem; }
            set { m_linkItem = value; }
        }

        public GetGigResponse()
        {
        }

        public GetGigResponse(Message message)
        {
            this.m_innerMessage = message;

            XmlDictionaryReader xmlReader = message.GetReaderAtBodyContents();

            xmlReader.MoveToContent();
            xmlReader.Read();
            xmlReader.MoveToContent();
            xmlReader.Read();

            this.m_linkItem = LinkItemHelper.ReadLinkItem(xmlReader);

            xmlReader.Close();

        }

        public GetGigResponse(LinkItem linkItem, MessageVersion version)
        {
            m_innerMessage = Message.CreateMessage(version, Action);

            this.m_linkItem = linkItem;
        }

        public GetGigResponse(XmlReader xmlReader, MessageVersion version)
        {
            m_innerMessage = Message.CreateMessage(version, Action);

            XmlDictionaryReader reader = XmlDictionaryReader.CreateDictionaryReader(xmlReader);
            this.m_linkItem = LinkItemHelper.ReadLinkItem(reader);
        }

        public override MessageHeaders Headers
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return this.m_innerMessage.Headers;
            }
        }

        protected override void OnWriteBodyContents(System.Xml.XmlDictionaryWriter xmlWriter)
        {
            /* What the message should look like...
             
                <GetGigResponse xmlns="http://www.thatindigogirl.com/samples/2006/06">
                <Item xmlns:b="http://schemas.thatindigogirl.com/samples/2006/06" xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
                <b:Id>xs:int</b:Id>
                <b:Title>xs:string</b:Title>
                <b:Description>xs:string</b:Description>
                <b:DateStart>xs:dateTime</b:DateStart>
                <b:DateEnd>xs:dateTime</b:DateEnd>
                <b:Url>xs:string</b:Url>
                </Item>
                </GetGigResponse>
            */

            xmlWriter.WriteStartElement("GetGigResponse", ns);
            xmlWriter.WriteStartElement("Item", ns);

            LinkItemHelper.WriteLinkItem(this.m_linkItem, xmlWriter);

            xmlWriter.WriteEndElement(); //Item
            xmlWriter.WriteEndElement(); //GetGigResponse

        }

        public override MessageProperties Properties
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return this.m_innerMessage.Properties;
            }
        }

        public override MessageVersion Version
        {
            get
            {
                if (m_innerMessage == null)
                {
                    throw new FaultException("Invalid operation. Inner message has not been set.");
                }
                else
                    return m_innerMessage.Version;
            }
        }
    }

    public class LicenseKeyHeader : MessageHeader
    {
        private const string ns = "http://www.thatindigogirl.com/samples/2006/06";

        public override string Name
        {
            get { return "LicenseKey"; }
        }

        public override string Namespace
        {
            get { return ns; }
        }

        public LicenseKeyHeader(string licenseKey)
        {
            this.m_licenseKey = licenseKey;
        }

        private string m_licenseKey;
        public string LicenseKey
        {
            get { return m_licenseKey; }
            set { m_licenseKey = value; }
        }

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion version)
        {
            writer.WriteString(this.m_licenseKey);
        }
    }
}
