using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelInstanceEditorInstanceActor")]
	public partial class ALevelInstanceEditorInstanceActor : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelInstanceEditorInstanceActor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}