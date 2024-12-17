using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderStarted__PythonCallable.OnTakeRecorderStarted__PythonCallable")]
	public partial class OnTakeRecorderStarted__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderStarted__PythonCallable.OnTakeRecorderStarted__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}