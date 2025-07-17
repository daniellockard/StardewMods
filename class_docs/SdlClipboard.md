# SdlClipboard

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static string GetText()
- - public static bool SetText(string text)

## Private Members
- - private static SdlClipboard PlatformClipboard;
- - private static ClipboardPlatformType GetPlatformType()

## Protected Members
- - protected string PlatformName;
- - protected virtual IntPtr GetTextImpl()
- - protected virtual int SetTextImpl(IntPtr text)

## Internal Members
- - internal static readonly ClipboardPlatformType Platform;

## Other Members
- - static SdlClipboard()
