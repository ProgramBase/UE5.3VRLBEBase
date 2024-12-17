using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/MultiLineEditableText_OnMultiLineEditableTextChangedEvent__PythonCallable.MultiLineEditableText_OnMultiLineEditableTextChangedEvent__PythonCallable")]
	public partial class MultiLineEditableText_OnMultiLineEditableTextChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/MultiLineEditableText_OnMultiLineEditableTextChangedEvent__PythonCallable.MultiLineEditableText_OnMultiLineEditableTextChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}