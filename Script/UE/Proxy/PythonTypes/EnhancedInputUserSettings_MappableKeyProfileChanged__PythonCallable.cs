using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EnhancedInputUserSettings_MappableKeyProfileChanged__PythonCallable.EnhancedInputUserSettings_MappableKeyProfileChanged__PythonCallable")]
	public partial class EnhancedInputUserSettings_MappableKeyProfileChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EnhancedInputUserSettings_MappableKeyProfileChanged__PythonCallable.EnhancedInputUserSettings_MappableKeyProfileChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}