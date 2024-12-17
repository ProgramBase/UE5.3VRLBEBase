using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnhancedInputUserSettings_EnhancedInputUserSettingsApplied__PythonCallable.EnhancedInputUserSettings_EnhancedInputUserSettingsApplied__PythonCallable")]
	public partial class EnhancedInputUserSettings_EnhancedInputUserSettingsApplied__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnhancedInputUserSettings_EnhancedInputUserSettingsApplied__PythonCallable.EnhancedInputUserSettings_EnhancedInputUserSettingsApplied__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}