using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBA.SDsLiCk.CodeGen
{
    /// <summary>A Symbol Table for Scanner/Parsers/Compilers that uses a generic record type</summary>
    /// <typeparam name="TRecord">The object type for the SymbolTable to Record</typeparam>
    /// <typeparam name="TType">An object type repesenting a value indicating the symbols type, e.g. a declared enum</typeparam>
    public class SymbolTable<TRecord, TType>
    {
        public delegate TRecord CreateRecordDelegate(string token, TType type);

        private readonly CreateRecordDelegate AddSymbolRecord; 

        private readonly Dictionary<string, TRecord> m_symbolTable = new Dictionary<string, TRecord>();

        public SymbolTable(CreateRecordDelegate addSymbolRecord)
            => AddSymbolRecord += addSymbolRecord ?? throw new ArgumentNullException(nameof(addSymbolRecord), "A valid 'CreateRecordDelegate' is required for adding Symbol records!");

        /// <summary>Find or add, if not found, a symbol record</summary>
        /// <param name="token">the token as text</param>
        /// <param name="type">The type of the token to use in creating its symbol record -ignored if token found</param>
        /// <returns>The symbol record as recorded in the table</returns>
        /// <remarks>... This method does not check the found ...</remarks>
        public TRecord FindOrAdd(string token, TType type)
        {
            if (m_symbolTable.ContainsKey(token))
                return m_symbolTable[token];

            else
            {
                TRecord record = AddSymbolRecord(token, type);
                m_symbolTable.Add(token, record);
                return record;
            }
        }

        public TRecord Find(string token)
        {
            return (m_symbolTable.ContainsKey(token)) ? m_symbolTable[token] : default(TRecord);
        }

        public void Add(string token, TType type)
        {
            try
            {
                TRecord record = AddSymbolRecord(token, type);
                m_symbolTable.Add(token, record);
            }
            catch (Exception e)
            {

                throw new InvalidOperationException($"Token '{token}' could not be added!\nSee inner exception.", e);
            }
        }

        public bool TryFind(string token, out TRecord symbol)
        {
            bool success = m_symbolTable.ContainsKey(token);
            symbol = success ? m_symbolTable[token] : default(TRecord);
            return success;
        }

        public bool TryAdd(string token, TType type)
        {
            bool success = !m_symbolTable.ContainsKey(token);
            if(success)
            {
                try
                {
                    TRecord record = AddSymbolRecord(token, type);
                    m_symbolTable.Add(token, record);
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException($"Token '{token}' could not be added!\nSee inner exception.", e);
                }
            }
            return success;
        }
    }
}
