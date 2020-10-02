using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{

    public struct TokenRef
    {
        public enum Type
        {
            Null, Non, Empty, BOL, EOL, EOF,
            Identifier, Keyword, Modifier, String, Char, Integer, Float, Operator,
            Error
        }

        public Type OfType { get; }
        public string Text { get; private set; }
        public bool IsFixed { get; private set; }

        private TokenRef(Type type)
        {
            OfType = type;
            Text = null;
            IsFixed = false;
        }

        private TokenRef(Type type, string text)
        {
            OfType = type;
            Text = text;
            IsFixed = true;
        }

        private TokenRef(Type type, string text, bool isFixed)
        {
            OfType = type;
            Text = text;
            IsFixed = isFixed;
        }

        internal static TokenRef Create(Type type, string text)
        {
            return new TokenRef(type, text, true);
        }

        public void UpdateText(string text)
        {
            if (IsFixed)
                throw new InvalidOperationException("Cannot Update (and maked fixed texxt as already fixed!");

            Text = text;
        }

        public void UpdateWithFixedText(string text)
        {
            if (IsFixed)
                throw new InvalidOperationException("Cannot Update (and maked fixed texxt as already fixed!");

            Text = text;
            IsFixed = true;
        }

        public void MakeFixedText()
        {
            IsFixed = true;
        }

        public static TokenRef CreateNonToken()
        {
            return new TokenRef(Type.Non, null);
        }
        public static TokenRef CreateNonToken(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Non, text);
        }
        public static TokenRef CreateEmpty()
        {
            return new TokenRef(Type.Empty, null);
        }
        public static TokenRef CreateBOL()
        {
            return new TokenRef(Type.BOL, null);
        }
        public static TokenRef CreateEOL()
        {
            return new TokenRef(Type.EOL, null);
        }
        public static TokenRef CreateEOF()
        {
           return new TokenRef(Type.EOF, null);
        }
        public static TokenRef CreateIdentifier()
        {
            return new TokenRef(Type.Identifier);
        }
        public static TokenRef CreateIdentifier(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Identifier, text);
        }
        public static TokenRef CreateKeyword(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Keyword, text);
        }
        public static TokenRef CreateModifier()
        {
            return new TokenRef(Type.Modifier, null);
        }
        public static TokenRef CreateModifier(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Modifier, text);
        }

        internal static TokenRef CreateOperator(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(nameof(text));

            return new TokenRef(Type.Operator, text);
        }

        public static TokenRef CreateString(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.String, text);
        }
        public static TokenRef CreateChar()
        {
            return new TokenRef(Type.Char, null);
        }
        public static TokenRef CreateChar(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Char, text);
        }
        public static TokenRef CreateInteger()
        {
            return new TokenRef(Type.Identifier, null);
        }
        public static TokenRef CreateInteger(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Identifier, text);
        }
        public static TokenRef CreateFloat()
        {
            return new TokenRef(Type.Float, null);
        }
        public static TokenRef CreateFloat(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Float, text);
        }
        public static TokenRef CreateError()
        {
            return new TokenRef(Type.Error, null);
        }
        public static TokenRef CreateError(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return new TokenRef(Type.Error, text);
        }

        public static bool operator ==(TokenRef token1, TokenRef token2)
        {
            return token1.Equals(token2);
        }

        public static bool operator !=(TokenRef token1, TokenRef token2)
        {
            return !token1.Equals(token2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (!(obj is TokenRef))
                throw new ArithmeticException($"'{nameof(obj)}' isn't a 'TokenRec' object!");

            return ((TokenRef)obj).OfType == OfType && (((TokenRef)obj).Text == Text || ((TokenRef)obj).Text == null);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"TokenRef: \"{Text}\" of type {OfType}";
        }
    }
}
