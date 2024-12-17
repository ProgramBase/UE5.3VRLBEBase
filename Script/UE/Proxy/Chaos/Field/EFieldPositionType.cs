using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EFieldPositionType")]
	public enum EFieldPositionType : byte
	{
		Field_Position_CenterOfMass = 0,
		Field_Position_PivotPoint = 1,
		Field_Position_Max = 2,
	}
}