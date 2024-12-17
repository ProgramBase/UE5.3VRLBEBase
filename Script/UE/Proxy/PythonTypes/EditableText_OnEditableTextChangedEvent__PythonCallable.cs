using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/EditableText_OnEditableTextChangedEvent__PythonCallable.EditableText_OnEditableTextChangedEvent__PythonCallable")]
	public partial class EditableText_OnEditableTextChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/EditableText_OnEditableTextChangedEvent__PythonCallable.EditableText_OnEditableTextChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}