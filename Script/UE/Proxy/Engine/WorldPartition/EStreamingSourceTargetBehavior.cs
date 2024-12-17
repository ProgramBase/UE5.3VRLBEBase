using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EStreamingSourceTargetBehavior")]
	public enum EStreamingSourceTargetBehavior : byte
	{
		Include = 0,
		Exclude = 1,
	}
}