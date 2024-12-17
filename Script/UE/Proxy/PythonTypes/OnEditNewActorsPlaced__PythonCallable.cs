using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnEditNewActorsPlaced__PythonCallable.OnEditNewActorsPlaced__PythonCallable")]
	public partial class OnEditNewActorsPlaced__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnEditNewActorsPlaced__PythonCallable.OnEditNewActorsPlaced__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}