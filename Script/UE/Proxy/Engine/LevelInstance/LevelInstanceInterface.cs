using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelInstanceInterface")]
	public partial class ULevelInstanceInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelInstanceInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.LevelInstanceInterface")]
	public interface ILevelInstanceInterface : IInterface
	{
		 void UnloadLevelInstance();

		 bool SetWorldAsset(TSoftObjectPtr<UWorld> WorldAsset);

		 void LoadLevelInstance();

		 bool IsLoaded();

		 TSoftObjectPtr<UWorld> GetWorldAsset();

		 ULevel GetLoadedLevel();
	}
}