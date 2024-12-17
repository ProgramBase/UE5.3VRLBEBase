using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelStreamingLevelInstanceEditor")]
	public partial class ULevelStreamingLevelInstanceEditor : ULevelStreamingAlwaysLoaded, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelStreamingLevelInstanceEditor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}