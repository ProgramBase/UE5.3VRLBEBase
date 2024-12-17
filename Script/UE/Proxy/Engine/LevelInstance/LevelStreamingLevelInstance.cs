using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelStreamingLevelInstance")]
	public partial class ULevelStreamingLevelInstance : ULevelStreamingDynamic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelStreamingLevelInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}