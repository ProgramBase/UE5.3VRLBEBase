using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderPreInitialize__PythonCallable.OnTakeRecorderPreInitialize__PythonCallable")]
	public partial class OnTakeRecorderPreInitialize__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderPreInitialize__PythonCallable.OnTakeRecorderPreInitialize__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}