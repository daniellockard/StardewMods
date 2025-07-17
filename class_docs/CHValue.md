# CHValue

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public CHValueUnion RawValue;
- - public CHValueEnum ValueType = CHValueEnum.Unknown;
- - public CHValue()
- - public void Parse(CHJsonParserContext context)
- - public object GetManagedObject()
- - public CHObject ValueObject;
- - public CHArray ValueArray;
- - public CHString ValueString;
- - public CHNumber ValueNumber;
- - public CHBoolean ValueBoolean;
- - public object ValueNull;

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- - internal enum CHValueEnum
- - internal struct CHValueUnion

## Other Members
- *(None)*
