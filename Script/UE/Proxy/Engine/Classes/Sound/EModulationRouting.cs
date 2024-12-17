using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EModulationRouting")]
	public enum EModulationRouting : byte
	{
		Disable = 0,
		Inherit = 1,
		Override = 2,
		Union = 3,
	}
}