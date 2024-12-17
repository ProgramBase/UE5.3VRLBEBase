using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MultiLineEditableTextBox_OnMultiLineEditableTextBoxCommittedEvent__PythonCallable.MultiLineEditableTextBox_OnMultiLineEditableTextBoxCommittedEvent__PythonCallable")]
	public partial class MultiLineEditableTextBox_OnMultiLineEditableTextBoxCommittedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MultiLineEditableTextBox_OnMultiLineEditableTextBoxCommittedEvent__PythonCallable.MultiLineEditableTextBox_OnMultiLineEditableTextBoxCommittedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}