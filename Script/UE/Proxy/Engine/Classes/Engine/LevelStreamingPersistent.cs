using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelStreamingPersistent")]
	public partial class ULevelStreamingPersistent : ULevelStreaming, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelStreamingPersistent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}