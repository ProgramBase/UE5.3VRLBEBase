using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnClusterUnionRemovedComponent__PythonCallable.OnClusterUnionRemovedComponent__PythonCallable")]
	public partial class OnClusterUnionRemovedComponent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnClusterUnionRemovedComponent__PythonCallable.OnClusterUnionRemovedComponent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}