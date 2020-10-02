using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class NextStateRec
    {
        public enum Type
        {
            Null, GrammaDef, GrammaRef, TokenRef
        }

        public string Name { get; }
        public string Identifier { get; }
        public Type OfType { get; }
        public TokenRef Token { get; }
        public NextStateRec Sequence { get; private set; }
        public NextStateRec Alternate { get; private set; }
        public ParseResponse Response { get; }
        public string Action { get; }


        // 			Null, Empty, Identifier, Keyword, Modifier, String, Char, Integer, Float, Operator, Error
        private NextStateRec(Type ofType, TokenRef token, ParseResponse response)
        {
            Name = token.Text;
            Identifier = Name;
            OfType = ofType;
            Token = token;      
            Sequence = null;            // end of list by default
            Alternate = null;           // no alternate by default 
            Response = response;
        }

        private NextStateRec(Type ofType, TokenRef token, string identifier, ParseResponse response)
        {
            Name = token.Text;
            Identifier = identifier;
            OfType = ofType;
            Token = token;      
            Sequence = null;            // end of list by default
            Alternate = null;           // no alternate by default 
            Response = response;
        }
        private NextStateRec(Type ofType, string name, TokenRef token, ParseResponse response)
        {
            Name = name;
            Identifier = name;
            OfType = ofType;
            Token = token;      
            Sequence = null;            // end of list by default
            Alternate = null;           // no alternate by default 
            Response = response;
        }
        private NextStateRec(Type ofType, string name, TokenRef token, string identifier, ParseResponse response)
        {
            Name = name;
            Identifier = identifier;
            OfType = ofType;
            Token = token;      
            Sequence = null;            // end of list by default
            Alternate = null;           // no alternate by default 
            Response = response;
        }

        // Link the next NSRecord to the end of the list, returning the object that contains this next Record
        internal void LinkNext(NextStateRec next)
        {
            if (Sequence != null)
                throw new InvalidOperationException($"Can only set Next State Once! Sequence has already been set.\n\tSequence={Sequence}\n\tLinkNext={next}");

            Sequence = next;
        }

        internal void LinkAlternate(NextStateRec alt)
        {
            if (Alternate != null)
                throw new InvalidOperationException($"Can only set Alternate State Once! Alternate has already been set.\n\tAlternate={Alternate}\n\tLinkNext={alt}");

            Alternate = alt;
        }

        public static NextStateRec CreateGrammaDef(string name)
        {
            return new NextStateRec(Type.GrammaDef, name, TokenRef.CreateNonToken(), ParseResponse.Null);
        }

        public static NextStateRec CreateGrammaRef(string name, ParseResponse response)
        {
            return new NextStateRec(Type.GrammaRef, name, TokenRef.CreateNonToken(), response);
        }

        public static NextStateRec CreateGrammaRef(string name)
        {
            return new NextStateRec(Type.GrammaRef, name, TokenRef.CreateNonToken(), ParseResponse.Next);
        }

        public static NextStateRec CreateEmpty(ParseResponse response)
        {
            return new NextStateRec(Type.TokenRef, "Empty", TokenRef.CreateEmpty(), "&Empty", response);
        }

        public static NextStateRec CreateTokenRef(string name, TokenRef.Type type)
        {
            return CreateTokenRef(name, type, ParseResponse.Next);
        }

        public static NextStateRec CreateTokenRef(TokenRef.Type type, ParseResponse response)
        {
            return CreateTokenRef(null, type, response);
        }

        public static NextStateRec CreateTokenRef(string name, TokenRef.Type type, ParseResponse response)
        {
            NextStateRec nsRec;
            switch (type)
            {
                case TokenRef.Type.Null:
                    throw new FormatException($"SourceObject Type {type.ToString()} is valid BUT NOT in the context as a Next State Token Ref!");

                case TokenRef.Type.Empty:
                    nsRec = new NextStateRec(Type.TokenRef, TokenRef.CreateEmpty(), null, response);
                    break;

                case TokenRef.Type.Identifier:
                    if (!(name is null))
                        throw new ArgumentNullException(nameof(name), $"NextStateRecords can not contain Identifier Tokens with predefined names -{nameof(name)} must be set to 'null', not '{name}'!");

                    nsRec = new NextStateRec(Type.TokenRef, TokenRef.CreateIdentifier(), response);
                    break;

                case TokenRef.Type.Keyword:
                    nsRec = new NextStateRec(Type.TokenRef, TokenRef.CreateKeyword(name), name, response);
                    break;

                case TokenRef.Type.Operator:
                    nsRec = new NextStateRec(Type.TokenRef, TokenRef.CreateOperator(name), name, response);
                    break;

                case TokenRef.Type.Error:
                    throw new NotImplementedException("Error types yet to be implemented!");

                default:
                    throw InvalidEnumValueException.InvalidArgument(typeof(TokenRef.Type), type, nameof(name));
            }

            return nsRec;
        }

        public override string ToString()
        {
            return $"NextStateRec '{Name}': {OfType} -Token {Token.Text}, Seq={Sequence.Name}, Alt={Alternate.Name}, Response={Response}";
        }
    }
}