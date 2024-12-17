using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SpinBox_OnSpinBoxBeginSliderMovement__PythonCallable.SpinBox_OnSpinBoxBeginSliderMovement__PythonCallable")]
	public partial class SpinBox_OnSpinBoxBeginSliderMovement__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SpinBox_OnSpinBoxBeginSliderMovement__PythonCallable.SpinBox_OnSpinBoxBeginSliderMovement__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}