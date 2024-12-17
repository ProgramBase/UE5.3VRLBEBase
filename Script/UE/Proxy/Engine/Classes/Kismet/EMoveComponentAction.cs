using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMoveComponentAction")]
	public enum EMoveComponentAction : byte
	{
		Move = 0,
		Stop = 1,
		Return = 2,
	}
}