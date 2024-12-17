using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELocationBoneSocketSelectionMethod")]
	public enum ELocationBoneSocketSelectionMethod : byte
	{
		BONESOCKETSEL_Sequential = 0,
		BONESOCKETSEL_Random = 1,
	}
}