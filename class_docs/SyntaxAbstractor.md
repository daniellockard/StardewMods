# SyntaxAbstractor

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string TextMarker = "text";
- - public readonly Dictionary<string, ExtractSyntaxDelegate> SyntaxHandlers = new Dictionary<string, ExtractSyntaxDelegate>(StringComparer.OrdinalIgnoreCase)
- - public ExtractSyntaxDelegate GetSyntaxHandler(string baseAssetName)
- - public string ExtractSyntaxFor(string baseAssetName, string key, string value)
- - public string ExtractPlainTextSyntax(string value)
- - public string ExtractDialogueSyntax(string value)
- - public string ExtractDialogueSyntax(string baseAssetName, string key, string value)
- - public string ExtractEventSyntax(string value)
- - public string ExtractFestivalSyntax(string baseAssetName, string key, string value)
- - public string ExtractCreditsSyntax(string text)
- - public string ExtractMailSyntax(string text)
- - public string ExtractDelimitedDataSyntax(string text, char delimiter, params int[] textFields)
- - public string ExtractDelimitedDataSyntax(string text, char delimiter, int[] textFields, int[] dialogueFields)
- - public string Extract16StringsSyntax(string key, string text)
- - public string ExtractLexiconSyntax(string key, string text)

## Private Members
- - private static string DialogueSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
- - private static string PlainTextSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
- - private static string EventSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
- - private static string FestivalSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
- - private void ExtractEventSyntaxImpl(string text, ref int index, StringBuilder syntax, int maxIndex = -1)
- - private void AppendEventCommandArg(StringBuilder syntax, string[] args, int index, bool prependSpace = true)
- - private void AppendEventCommandDialogueArg(StringBuilder syntax, string[] args, int index, bool prependSpace = true, bool quote = true)
- - private string ExtractNpcGenderedDialogueSyntax(string text)
- - private void ExtractDialogueSyntaxImpl(string text, char commandDelimiter, ref int index, StringBuilder syntax, int maxIndex = -1)
- - private void ExtractDialogueCommandSyntax(string text, ref int index, StringBuilder syntax, char commandDelimiter)
- - private void ExtractDialogueItemSpawnSyntax(string text, ref int index, StringBuilder syntax)
- - private void ExtractMailCommandSyntax(string text, ref int index, StringBuilder syntax)
- - private void ExtractTagSyntax(string text, ref int index, StringBuilder syntax)
- - private void ExtractRevealTasteCommandSyntax(string text, ref int index, StringBuilder syntax)
- - private void EndTextContext(ref bool hasText, StringBuilder syntax)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
