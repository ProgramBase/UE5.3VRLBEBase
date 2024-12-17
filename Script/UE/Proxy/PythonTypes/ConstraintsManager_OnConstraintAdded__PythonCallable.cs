using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ConstraintsManager_OnConstraintAdded__PythonCallable.ConstraintsManager_OnConstraintAdded__PythonCallable")]
	public partial class ConstraintsManager_OnConstraintAdded__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ConstraintsManager_OnConstraintAdded__PythonCallable.ConstraintsManager_OnConstraintAdded__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}