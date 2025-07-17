# MarriageDialogueReference

**Summary:** Handles in-game dialogue or conversations.

## Public Members
- - public const string ENDEARMENT_TOKEN = "%endearment";
- - public const string ENDEARMENT_TOKEN_LOWER = "%endearmentlower";
- - public NetFields NetFields { get; } = new NetFields("MarriageDialogueReference");
- - public string DialogueFile => _dialogueFile.Value;
- - public string DialogueKey => _dialogueKey.Value;
- - public bool IsGendered => _isGendered.Value;
- - public string[] Substitutions => _substitutions.ToArray();
- - public MarriageDialogueReference()
- - public MarriageDialogueReference(string dialogue_file, string dialogue_key, bool gendered = false, params string[] substitutions)
- - public string GetText()
- - public bool IsItemGrabDialogue(NPC n)
- - public Dialogue GetDialogue(NPC n)
- - public bool Equals(MarriageDialogueReference other)
- - public override bool Equals(object obj)
- - public override int GetHashCode()

## Private Members
- - private readonly NetString _dialogueFile = new NetString("");
- - private readonly NetString _dialogueKey = new NetString("");
- - private readonly NetBool _isGendered = new NetBool(value: false);
- - private readonly NetStringList _substitutions = new NetStringList();

## Protected Members
- - protected void _ReplaceTokens(Dialogue dialogue, NPC npc)
- - protected string _ReplaceTokens(string text, NPC npc)

## Internal Members
- *(None)*

## Other Members
- *(None)*
