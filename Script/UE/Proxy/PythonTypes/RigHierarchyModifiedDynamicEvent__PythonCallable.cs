using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/RigHierarchyModifiedDynamicEvent__PythonCallable.RigHierarchyModifiedDynamicEvent__PythonCallable")]
	public partial class RigHierarchyModifiedDynamicEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/RigHierarchyModifiedDynamicEvent__PythonCallable.RigHierarchyModifiedDynamicEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}