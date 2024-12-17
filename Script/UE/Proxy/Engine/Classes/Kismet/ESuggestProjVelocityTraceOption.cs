using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESuggestProjVelocityTraceOption")]
	public enum ESuggestProjVelocityTraceOption : byte
	{
		DoNotTrace = 0,
		TraceFullPath = 1,
		OnlyTraceWhileAscending = 2,
	}
}