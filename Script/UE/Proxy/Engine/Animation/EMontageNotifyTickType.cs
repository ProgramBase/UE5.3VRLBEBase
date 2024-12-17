using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMontageNotifyTickType")]
	public enum EMontageNotifyTickType : byte
	{
		Queued = 0,
		BranchingPoint = 1,
	}
}