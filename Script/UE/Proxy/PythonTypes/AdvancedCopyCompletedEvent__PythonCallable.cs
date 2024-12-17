using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/AdvancedCopyCompletedEvent__PythonCallable.AdvancedCopyCompletedEvent__PythonCallable")]
	public partial class AdvancedCopyCompletedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/AdvancedCopyCompletedEvent__PythonCallable.AdvancedCopyCompletedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}