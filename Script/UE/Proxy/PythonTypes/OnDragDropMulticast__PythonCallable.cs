using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDragDropMulticast__PythonCallable.OnDragDropMulticast__PythonCallable")]
	public partial class OnDragDropMulticast__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDragDropMulticast__PythonCallable.OnDragDropMulticast__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}