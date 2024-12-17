using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnGetItemChildrenDynamic__PythonCallable.OnGetItemChildrenDynamic__PythonCallable")]
	public partial class OnGetItemChildrenDynamic__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnGetItemChildrenDynamic__PythonCallable.OnGetItemChildrenDynamic__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}