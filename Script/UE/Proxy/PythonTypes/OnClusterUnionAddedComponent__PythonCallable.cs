using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnClusterUnionAddedComponent__PythonCallable.OnClusterUnionAddedComponent__PythonCallable")]
	public partial class OnClusterUnionAddedComponent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnClusterUnionAddedComponent__PythonCallable.OnClusterUnionAddedComponent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}