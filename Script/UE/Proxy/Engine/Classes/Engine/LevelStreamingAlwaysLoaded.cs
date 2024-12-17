using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelStreamingAlwaysLoaded")]
	public partial class ULevelStreamingAlwaysLoaded : ULevelStreaming, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelStreamingAlwaysLoaded");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}