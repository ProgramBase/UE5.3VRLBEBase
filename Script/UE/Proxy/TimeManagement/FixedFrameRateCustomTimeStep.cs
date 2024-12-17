using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.FixedFrameRateCustomTimeStep")]
	public partial class UFixedFrameRateCustomTimeStep : UEngineCustomTimeStep, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TimeManagement.FixedFrameRateCustomTimeStep");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}