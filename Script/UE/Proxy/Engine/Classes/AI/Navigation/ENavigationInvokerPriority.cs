using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENavigationInvokerPriority")]
	public enum ENavigationInvokerPriority : byte
	{
		VeryLow = 1,
		Low = 2,
		Default = 3,
		High = 4,
		VeryHigh = 5,
	}
}