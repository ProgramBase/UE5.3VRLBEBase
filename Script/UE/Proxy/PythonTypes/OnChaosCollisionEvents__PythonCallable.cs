using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnChaosCollisionEvents__PythonCallable.OnChaosCollisionEvents__PythonCallable")]
	public partial class OnChaosCollisionEvents__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnChaosCollisionEvents__PythonCallable.OnChaosCollisionEvents__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}