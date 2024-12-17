using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphSchema")]
	public partial class UMetasoundEditorGraphSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}