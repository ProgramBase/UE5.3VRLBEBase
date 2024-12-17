using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditNewActorsDropped__PythonCallable.OnEditNewActorsDropped__PythonCallable")]
	public partial class OnEditNewActorsDropped__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditNewActorsDropped__PythonCallable.OnEditNewActorsDropped__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}