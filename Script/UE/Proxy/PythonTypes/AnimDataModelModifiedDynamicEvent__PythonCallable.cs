using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AnimDataModelModifiedDynamicEvent__PythonCallable.AnimDataModelModifiedDynamicEvent__PythonCallable")]
	public partial class AnimDataModelModifiedDynamicEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AnimDataModelModifiedDynamicEvent__PythonCallable.AnimDataModelModifiedDynamicEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}