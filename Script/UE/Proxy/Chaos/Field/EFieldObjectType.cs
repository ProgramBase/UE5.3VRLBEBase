using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldObjectType")]
	public enum EFieldObjectType : byte
	{
		Field_Object_Rigid = 0,
		Field_Object_Cloth = 1,
		Field_Object_Destruction = 2,
		Field_Object_Character = 3,
		Field_Object_All = 4,
		Field_Object_Max = 5,
	}
}