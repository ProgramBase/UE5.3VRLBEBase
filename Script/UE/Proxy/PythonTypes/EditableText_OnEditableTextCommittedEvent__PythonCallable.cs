using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EditableText_OnEditableTextCommittedEvent__PythonCallable.EditableText_OnEditableTextCommittedEvent__PythonCallable")]
	public partial class EditableText_OnEditableTextCommittedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EditableText_OnEditableTextCommittedEvent__PythonCallable.EditableText_OnEditableTextCommittedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}