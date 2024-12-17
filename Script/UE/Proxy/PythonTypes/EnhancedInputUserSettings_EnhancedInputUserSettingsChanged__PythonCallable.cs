using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnhancedInputUserSettings_EnhancedInputUserSettingsChanged__PythonCallable.EnhancedInputUserSettings_EnhancedInputUserSettingsChanged__PythonCallable")]
	public partial class EnhancedInputUserSettings_EnhancedInputUserSettingsChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnhancedInputUserSettings_EnhancedInputUserSettingsChanged__PythonCallable.EnhancedInputUserSettings_EnhancedInputUserSettingsChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}