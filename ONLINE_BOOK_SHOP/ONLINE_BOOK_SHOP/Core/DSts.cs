using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Web;


namespace Core
{
    class DSts
    {
        public int stsID
        {
            get
            {
                return m_stsID;
            }
            set
            {
                m_stsID = value;
            }
        }
        private int m_stsID;
        public int IsOwner
        {
            get
            {
                return m_IsOwner;
            }
            set
            {
                m_IsOwner = value;
            }
        }
        private int m_IsOwner;
        public string sts
        {
            get
            {
                return m_sts;
            }
            set
            {
                m_sts = value;
            }
        }
        private string m_sts;
        public DSts(int sid, string name, int owner)
        {
            this.sts = name;
            this.stsID = sid;
            this.IsOwner = owner;
        }
        public DSts()
        {
        }
        public DSts GetStstusnsme(int sid)
        {
            System.Collections.Generic.List<DSts> lst = new System.Collections.Generic.List<DSts>();
            lst.Add(new DSts(1, "Junk Lead #", 0));
            lst.Add(new DSts(7, "Not Interested#", 0));
            lst.Add(new DSts(8, "Contacted Call Back", 1));
            lst.Add(new DSts(10, "Duplicate Entry #", 0));
            lst.Add(new DSts(11, "Not relevant #", 0));
            lst.Add(new DSts(12, "Existing Client #", 0));
            lst.Add(new DSts(13, "Appointment Fixed", 0));
            lst.Add(new DSts(25, "Do Not Disturb#", 0));
            lst.Add(new DSts(26, "Outstation Not Interested#", 0));
            lst.Add(new DSts(38, "Finds Expensive #", 0));
            lst.Add(new DSts(67, "Book Sold #", 0));
            lst.Add(new DSts(68, "Will GetBack on Own#", 0));
            lst.Add(new DSts(69, "Denies Request #", 0));
            lst.Add(new DSts(70, "Wrong Number #", 0));
            lst.Add(new DSts(71, "Service Not Available #", 0));
            lst.Add(new DSts(72, "Inquiry Call #", 0));
            lst.Add(new DSts(73, "Mistaken Inquire #", 0));
            lst.Add(new DSts(74, "No Requirement #", 0));
            lst.Add(new DSts(75, "Language Barrier #", 0));
            lst.Add(new DSts(76, "Test Lead #", 0));
            lst.Add(new DSts(77, "Other #", 0));
            lst.Add(new DSts(78, "Invalid Number #", 0));
            lst.Add(new DSts(79, "Will call back on own", 1));
            lst.Add(new DSts(81, "Center Related", 0));
            lst.Add(new DSts(82, "RPC - Not Connected", 0));
            lst.Add(new DSts(83, "RPC - Not Connected #", 0));
            lst.Add(new DSts(84, "Not Connect", 0));
            lst.Add(new DSts(88, "Outstation", 0));
            lst.Add(new DSts(24, "Visited", 0));
            lst.Add(new DSts(96, "Existing Client Enquiry", 0));
            lst.Add(new DSts(90, "FC visit but invalid", 0));
            lst.Add(new DSts(91, "Visited But Not Marked", 0));
            lst.Add(new DSts(92, "Visited & Joined", 0));
            lst.Add(new DSts(100, "Hthome", 0));
            lst.Add(new DSts(98, "REJOIN APPT FIX", 0));
            lst.Add(new DSts(103, "Outstation Enquiry", 0));
            lst.Add(new DSts(104, "Payment Link Sent", 0));
            lst.Add(new DSts(105, "Call Disconnected", 0));
            lst.Add(new DSts(107, "Short call", 0));
            lst.Add(new DSts(109, "HC Verification", 0));
            return lst.SingleOrDefault(x => x.stsID == sid);
        }
    }
}
