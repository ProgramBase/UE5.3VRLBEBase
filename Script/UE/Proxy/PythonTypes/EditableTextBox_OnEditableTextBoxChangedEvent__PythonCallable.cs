using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EditableTextBox_OnEditableTextBoxChangedEvent__PythonCallable.EditableTextBox_OnEditableTextBoxChangedEvent__PythonCallable")]
	public partial class EditableTextBox_OnEditableTextBoxChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EditableTextBox_OnEditableTextBoxChangedEvent__PythonCallable.EditableTextBox_OnEditableTextBoxChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}