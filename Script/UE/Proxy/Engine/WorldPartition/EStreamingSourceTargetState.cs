using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStreamingSourceTargetState")]
	public enum EStreamingSourceTargetState : byte
	{
		Loaded = 0,
		Activated = 1,
	}
}