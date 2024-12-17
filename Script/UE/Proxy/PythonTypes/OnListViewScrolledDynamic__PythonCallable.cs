using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListViewScrolledDynamic__PythonCallable.OnListViewScrolledDynamic__PythonCallable")]
	public partial class OnListViewScrolledDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListViewScrolledDynamic__PythonCallable.OnListViewScrolledDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}