using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnGameUserSettingsUINeedsUpdate__PythonCallable.OnGameUserSettingsUINeedsUpdate__PythonCallable")]
	public partial class OnGameUserSettingsUINeedsUpdate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnGameUserSettingsUINeedsUpdate__PythonCallable.OnGameUserSettingsUINeedsUpdate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}