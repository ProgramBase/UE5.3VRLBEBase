using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnhancedInputLocalPlayerSubsystem_OnControlMappingsRebuilt__PythonCallable.EnhancedInputLocalPlayerSubsystem_OnControlMappingsRebuilt__PythonCallable")]
	public partial class EnhancedInputLocalPlayerSubsystem_OnControlMappingsRebuilt__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnhancedInputLocalPlayerSubsystem_OnControlMappingsRebuilt__PythonCallable.EnhancedInputLocalPlayerSubsystem_OnControlMappingsRebuilt__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}