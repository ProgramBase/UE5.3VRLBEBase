using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioVirtualizationChanged__PythonCallable.OnAudioVirtualizationChanged__PythonCallable")]
	public partial class OnAudioVirtualizationChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioVirtualizationChanged__PythonCallable.OnAudioVirtualizationChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}