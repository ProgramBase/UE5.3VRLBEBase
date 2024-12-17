using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/LevelSequenceActor_OnLevelSequenceLoaded__PythonCallable.LevelSequenceActor_OnLevelSequenceLoaded__PythonCallable")]
	public partial class LevelSequenceActor_OnLevelSequenceLoaded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/LevelSequenceActor_OnLevelSequenceLoaded__PythonCallable.LevelSequenceActor_OnLevelSequenceLoaded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}