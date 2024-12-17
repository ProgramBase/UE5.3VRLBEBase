using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnItemExpansionChangedDynamic__PythonCallable.OnItemExpansionChangedDynamic__PythonCallable")]
	public partial class OnItemExpansionChangedDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnItemExpansionChangedDynamic__PythonCallable.OnItemExpansionChangedDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}