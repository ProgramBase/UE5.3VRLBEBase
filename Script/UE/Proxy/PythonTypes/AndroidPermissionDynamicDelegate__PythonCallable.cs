using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AndroidPermissionDynamicDelegate__PythonCallable.AndroidPermissionDynamicDelegate__PythonCallable")]
	public partial class AndroidPermissionDynamicDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AndroidPermissionDynamicDelegate__PythonCallable.AndroidPermissionDynamicDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}