using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnDeleteActorsEnd__PythonCallable.OnDeleteActorsEnd__PythonCallable")]
	public partial class OnDeleteActorsEnd__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnDeleteActorsEnd__PythonCallable.OnDeleteActorsEnd__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}