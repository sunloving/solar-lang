﻿using System.Text.RegularExpressions;
using Solar.Domain.Grammar.Lexis.Static;

namespace Solar.Domain.Grammar.Lexis.GlobalStateObjects.TokenTypes.Whitespaces
{
    public class IndentTokenType : LexicalTokenTypeBase
    {
        protected override Regex CharacteristicRegex => LexemesRegularExpressions.Indent;
    }
}