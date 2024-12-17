using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphNode")]
	public partial class UMetasoundEditorGraphNode : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}