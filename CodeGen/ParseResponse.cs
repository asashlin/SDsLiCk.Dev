namespace IBA.SDsLiCk.CodeGen
{
    public enum ParseResponse
    {
        Null,     // Unknown or special response (for special states including GrammaDef/Ref)
        Next,     // move to the next token in sequence to parse (also used with OfType == Null to indicate special Record that should use the next state with the same token)
        Reject,   // used where an syntax error is found
        Accept,   // last token that causes a sequence to be accepted -returns to base state when stack is popped and excutes indicate action
        Append,   // Causes value of token/gramma to be appended to current gramma value

        Call,     // stacks the current NS Record to save as a return point
        Resume,   // Pops the NS Record from the stack to return to calling points NextState
        SetBase,  // stacks the current base and sets current NS Record as new base
        Rebase    // pops the NS Record from the stack and sets as current base

    }
}