using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELocationEmitterSelectionMethod")]
	public enum ELocationEmitterSelectionMethod : byte
	{
		ELESM_Random = 0,
		ELESM_Sequential = 1,
	}
}