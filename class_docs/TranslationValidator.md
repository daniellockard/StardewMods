# TranslationValidator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, string baseAssetName)
- - public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, Func<string, string, string> getSyntax)
- - public TranslationValidatorResult CompareEntry(string key, string baseText, string translationText, Func<string, string> getSyntax)
- - public bool ValidateGenderSwitchBlocks(string text, out string error, out string errorBlock)
- - public int GetDiffIndex(string baseText, string translatedText)
- - public enum TranslationValidatorIssue

## Private Members
- - private readonly SyntaxAbstractor Abstractor = new SyntaxAbstractor();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
