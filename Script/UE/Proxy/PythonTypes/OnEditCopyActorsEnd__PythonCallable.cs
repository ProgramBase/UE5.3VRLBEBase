using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditCopyActorsEnd__PythonCallable.OnEditCopyActorsEnd__PythonCallable")]
	public partial class OnEditCopyActorsEnd__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditCopyActorsEnd__PythonCallable.OnEditCopyActorsEnd__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}