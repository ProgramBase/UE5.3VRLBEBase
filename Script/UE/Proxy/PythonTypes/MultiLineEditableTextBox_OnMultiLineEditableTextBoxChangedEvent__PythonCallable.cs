using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MultiLineEditableTextBox_OnMultiLineEditableTextBoxChangedEvent__PythonCallable.MultiLineEditableTextBox_OnMultiLineEditableTextBoxChangedEvent__PythonCallable")]
	public partial class MultiLineEditableTextBox_OnMultiLineEditableTextBoxChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MultiLineEditableTextBox_OnMultiLineEditableTextBoxChangedEvent__PythonCallable.MultiLineEditableTextBox_OnMultiLineEditableTextBoxChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}