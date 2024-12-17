using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnCanvasRenderTargetUpdate__PythonCallable.OnCanvasRenderTargetUpdate__PythonCallable")]
	public partial class OnCanvasRenderTargetUpdate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnCanvasRenderTargetUpdate__PythonCallable.OnCanvasRenderTargetUpdate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}