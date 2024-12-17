using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMouseCaptureEndEvent__PythonCallable.OnMouseCaptureEndEvent__PythonCallable")]
	public partial class OnMouseCaptureEndEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMouseCaptureEndEvent__PythonCallable.OnMouseCaptureEndEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}