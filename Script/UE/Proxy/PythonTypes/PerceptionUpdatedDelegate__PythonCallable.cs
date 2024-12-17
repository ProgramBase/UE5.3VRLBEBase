using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/PerceptionUpdatedDelegate__PythonCallable.PerceptionUpdatedDelegate__PythonCallable")]
	public partial class PerceptionUpdatedDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/PerceptionUpdatedDelegate__PythonCallable.PerceptionUpdatedDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}