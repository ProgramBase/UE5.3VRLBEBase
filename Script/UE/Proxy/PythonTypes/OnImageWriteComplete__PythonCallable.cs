using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnImageWriteComplete__PythonCallable.OnImageWriteComplete__PythonCallable")]
	public partial class OnImageWriteComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnImageWriteComplete__PythonCallable.OnImageWriteComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}