using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPlatformInterfaceDataType")]
	public enum EPlatformInterfaceDataType : byte
	{
		PIDT_None = 0,
		PIDT_Int = 1,
		PIDT_Float = 2,
		PIDT_String = 3,
		PIDT_Object = 4,
		PIDT_Custom = 5,
	}
}