using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MenuAnchor_GetUserWidget__PythonCallable.MenuAnchor_GetUserWidget__PythonCallable")]
	public partial class MenuAnchor_GetUserWidget__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MenuAnchor_GetUserWidget__PythonCallable.MenuAnchor_GetUserWidget__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}