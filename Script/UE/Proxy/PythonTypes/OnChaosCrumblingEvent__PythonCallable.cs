using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosCrumblingEvent__PythonCallable.OnChaosCrumblingEvent__PythonCallable")]
	public partial class OnChaosCrumblingEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosCrumblingEvent__PythonCallable.OnChaosCrumblingEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}