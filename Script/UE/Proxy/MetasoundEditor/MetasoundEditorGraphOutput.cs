using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphOutput")]
	public partial class UMetasoundEditorGraphOutput : UMetasoundEditorGraphVertex, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphOutput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}