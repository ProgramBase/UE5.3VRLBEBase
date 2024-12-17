using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MultiLineEditableText_OnMultiLineEditableTextCommittedEvent__PythonCallable.MultiLineEditableText_OnMultiLineEditableTextCommittedEvent__PythonCallable")]
	public partial class MultiLineEditableText_OnMultiLineEditableTextCommittedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MultiLineEditableText_OnMultiLineEditableTextCommittedEvent__PythonCallable.MultiLineEditableText_OnMultiLineEditableTextCommittedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}