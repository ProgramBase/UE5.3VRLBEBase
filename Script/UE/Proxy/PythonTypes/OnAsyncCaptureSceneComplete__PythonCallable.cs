using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAsyncCaptureSceneComplete__PythonCallable.OnAsyncCaptureSceneComplete__PythonCallable")]
	public partial class OnAsyncCaptureSceneComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAsyncCaptureSceneComplete__PythonCallable.OnAsyncCaptureSceneComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}