using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNavDataGenericEvent__PythonCallable.OnNavDataGenericEvent__PythonCallable")]
	public partial class OnNavDataGenericEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNavDataGenericEvent__PythonCallable.OnNavDataGenericEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}