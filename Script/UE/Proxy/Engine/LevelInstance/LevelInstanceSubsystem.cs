using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelInstanceSubsystem")]
	public partial class ULevelInstanceSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelInstanceSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}