using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldOperationType")]
	public enum EFieldOperationType : byte
	{
		Field_Multiply = 0,
		Field_Divide = 1,
		Field_Add = 2,
		Field_Substract = 3,
	}
}