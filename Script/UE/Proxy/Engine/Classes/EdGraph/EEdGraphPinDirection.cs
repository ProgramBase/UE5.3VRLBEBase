using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEdGraphPinDirection")]
	public enum EEdGraphPinDirection : byte
	{
		EGPD_Input = 0,
		EGPD_Output = 1,
	}
}