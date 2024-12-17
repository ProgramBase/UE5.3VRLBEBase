using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.LevelInstanceEditor
{
	[PathName("/Script/LevelInstanceEditor.LevelInstanceActorFactory")]
	public partial class ULevelInstanceActorFactory : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelInstanceEditor.LevelInstanceActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}