using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ServerStreamingLevelsVisibility")]
	public partial class AServerStreamingLevelsVisibility : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ServerStreamingLevelsVisibility");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}