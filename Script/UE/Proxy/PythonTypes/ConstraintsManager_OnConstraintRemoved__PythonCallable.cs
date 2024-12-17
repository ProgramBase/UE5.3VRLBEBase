using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ConstraintsManager_OnConstraintRemoved__PythonCallable.ConstraintsManager_OnConstraintRemoved__PythonCallable")]
	public partial class ConstraintsManager_OnConstraintRemoved__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ConstraintsManager_OnConstraintRemoved__PythonCallable.ConstraintsManager_OnConstraintRemoved__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}