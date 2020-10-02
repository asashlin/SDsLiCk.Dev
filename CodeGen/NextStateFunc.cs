using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class NextStateFunc
    {
        public delegate bool ActionDelegte(string action);
        public ActionDelegte Action;

        private readonly Stack<NextStateRec> m_level = new Stack<NextStateRec>();

        public NextStateRec CurrentState { get; private set; }
        public NextStateRec StartState { get; internal set; }

        public NextStateFunc(NextStateRec startState, ActionDelegte action)
        {

            StartState = startState ?? throw new ArgumentNullException(nameof(startState)); 
            CurrentState = startState;
            Action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public NextStateFunc(NextStateRec startState)
        {

            StartState = startState ?? throw new ArgumentNullException(nameof(startState));
            CurrentState = startState;
        }

        public void Reset()
        {
            CurrentState = StartState;
            m_level.Clear();
        }

        public ParseResponse GoToNextState(SourceObject next)
        {
            ParseResponse response = ParseResponse.Null;
            NextStateRec state = CurrentState;
            TokenRef token = TokenRef.Create(next.OfType, next.Text);

            do
            {
                Debug.WriteIf(state != null, $"{{{token}}} against {{{state.Token}}}", "Check");

                if (state == null)
                {
                    response = ParseResponse.Reject;
                    Debug.WriteLine(" -Match! Response = Reject");
                }

                else if (token == state.Token)
                {
                    response = state.Response;
                    Debug.WriteLine(" -Match! Response = " + response);
                }

                else if (state.Token.OfType == TokenRef.Type.Empty)
                {
                    response = state.Response;
                    Debug.WriteLine(" -Match on Empty! Response = " + response);
                }

                else if (state.Token.OfType == TokenRef.Type.Null)
                {
                    if (state.Response == ParseResponse.Next)
                    {
                        state = state.Sequence;
                        response = ParseResponse.Null;
                    }
                    else
                        response = state.Response;

                    Debug.WriteLine(" -Special Response = " + response);
                }

                else
                {
                    Debug.WriteLine(" -NO Match! Check Next");
                    state = state.Sequence;
                }


            } while (response == ParseResponse.Null);

            // Determine next state based on response
            Debug.Write($"{{{state.Token }}} -> ", "Result");
            switch (response)
            {
                case ParseResponse.Next:
                    CurrentState = state.Sequence;
                    break;

                default:
                    throw new InvalidEnumValueException(typeof(ParseResponse), response);

            }

            Debug.WriteLine($"{{{CurrentState.Token}}} -Response {response}!");

            return response;
        }
    }
}