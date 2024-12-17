using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTableAltered__PythonCallable.OnTableAltered__PythonCallable")]
	public partial class OnTableAltered__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTableAltered__PythonCallable.OnTableAltered__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}