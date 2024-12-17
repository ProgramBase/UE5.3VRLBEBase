using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldCullingOperationType")]
	public enum EFieldCullingOperationType : byte
	{
		Field_Culling_Inside = 0,
		Field_Culling_Outside = 1,
		Field_Culling_Operation_Max = 2,
	}
}