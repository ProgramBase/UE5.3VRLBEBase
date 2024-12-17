using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnListItemScrolledIntoViewDynamic__PythonCallable.OnListItemScrolledIntoViewDynamic__PythonCallable")]
	public partial class OnListItemScrolledIntoViewDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnListItemScrolledIntoViewDynamic__PythonCallable.OnListItemScrolledIntoViewDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}