using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLevelSequencePlayerCameraCutEvent__PythonCallable.OnLevelSequencePlayerCameraCutEvent__PythonCallable")]
	public partial class OnLevelSequencePlayerCameraCutEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLevelSequencePlayerCameraCutEvent__PythonCallable.OnLevelSequencePlayerCameraCutEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}