using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class NextStateBuilder
    {
        private struct Link2Ref
        {
            internal string Name { get; }       // Next State Record name to link to
            internal bool IsAlternate { get; }  // Indicates destination as Alternate NS or if false, Sequence NS

            public Link2Ref(string name, bool isAlternate)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                IsAlternate = isAlternate;
            }
        }

        public NextStateFunc NextStateFunc { get; }

        private readonly Dictionary<NextStateRec, Link2Ref> m_unLnkdRecordList = new Dictionary<NextStateRec, Link2Ref>();
        private readonly Dictionary<string, NextStateRec> m_recNameXRef = new Dictionary<string, NextStateRec>();

        public NextStateBuilder(NextStateRec startState)
        {
            if (startState is null)
                throw new ArgumentNullException(nameof(startState));

            NextStateFunc = new NextStateFunc(startState);
            m_recNameXRef.Add(startState.Name, startState);
        }
        public NextStateBuilder(NextStateRec startState, NextStateFunc.ActionDelegte action)
            : this(startState)
        {
            if (action is null)
                throw new ArgumentNullException(nameof(action));

            NextStateFunc.Action += action;
        }

        public void SetNextStateStartRecord(NextStateRec startRec)
        {
            NextStateFunc.StartState = startRec;
            m_recNameXRef.Add(startRec.Name, startRec);
        }

        /// <summary>Add the Sequence NextState to an NS record</summary>
        /// <param name="record">Record to receive link to the Sequence NS Record</param>
        /// <param name="nextState">The Next stae record to be linked to record</param>
        public void AddSequenceNSRecord(NextStateRec record, NextStateRec nextState)
        {
            record.LinkNext(nextState);
        }

        /// <summary>Add the Allternative NextState to an NS record</summary>
        /// <param name="record">Record to receive link to the Alternative NS Record</param>
        /// <param name="altNextState">The Next stae record to be linked as Alternative to record</param>
        public void AddAlternativeNSRecord(NextStateRec record, NextStateRec altNextState)
        {
            record.LinkAlternate(altNextState);
        }

        /// <summary>Add a record with a name of a next state record to link to</summary>
        /// <param name="record">Record to be saved</param>
        /// <param name="linkToName">Name of record to link to</param>
        public void AddNSRecordRef(NextStateRec record, string linkToName, bool isAlternate)
        {
            if (m_recNameXRef.ContainsKey(linkToName))
            {
                // gramma has been already defined -can be linked as required
                NextStateRec link = m_recNameXRef[linkToName];
                if (isAlternate) record.LinkAlternate(link);
                else record.LinkNext(link);
            }
            else
                m_unLnkdRecordList.Add(record, new Link2Ref(linkToName, isAlternate));       // Gramma not yet defined, add to list to be resovled later
        }

        public void AddNSRecordRef(string name, NextStateRec record)
        {
            m_recNameXRef.Add(name, record);
        }

        /// <summary>Add a NAMED record with a next state record supplied</summary>
        /// <param name="name">Record's name to be added to the name cross reference list</param>
        /// <param name="record">Record to be saved</param>
        /// <param name="nextState">The Next stae record to be linked to record</param>
        public void AddNextStateRecord(string name, NextStateRec record, NextStateRec nextState)
        {
            //NextStateFunc.AddNextStateRecord(record, nextState);
            m_recNameXRef.Add(name, record);
            throw new NotImplementedException("Needs completing!");
        }

        /// <summary>Add a NAMED record with a name of a next state record to link to</summary>
        /// <param name="name">Record's name to be added to the name cross reference list</param>
        /// <param name="record">Record to be saved</param>
        /// <param name="linkToName">Name of record to link to</param>
        public void AddNextStateRecord(string name, NextStateRec record, string linkToName)
        {
            //NextStateFunc.AddNextStateRecord(record, null);
            m_recNameXRef.Add(name, record);
            //m_unLnkdRecordList.Add(record, linkToName);
            throw new NotImplementedException("Needs completing!");
        }

        /// <summary>Resolves those records that do not yet have a NextState recorded</summary>
        /// <remarks>Where a record is added, but the NextState is not yet added, then its NestState's name is recorded.
        /// This methods resolves these unlimked records after all records have been recorded and their objects created</remarks>
        public void ResolveUnlinkedRecords()
        {
            foreach (KeyValuePair<NextStateRec, Link2Ref> item in m_unLnkdRecordList)
            {
                NextStateRec record = item.Key;
                NextStateRec next = m_recNameXRef[item.Value.Name];
                throw new NotImplementedException("Needs completing!");
               // NextStateFunc.AddRecordNextLink(record, next);
            }
        }

    }
}