using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnQueueSubtitles__PythonCallable.OnQueueSubtitles__PythonCallable")]
	public partial class OnQueueSubtitles__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnQueueSubtitles__PythonCallable.OnQueueSubtitles__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}