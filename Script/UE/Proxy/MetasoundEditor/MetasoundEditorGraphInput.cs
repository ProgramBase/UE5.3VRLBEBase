using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundEditorGraphInput")]
	public partial class UMetasoundEditorGraphInput : UMetasoundEditorGraphVertex, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEditor.MetasoundEditorGraphInput");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}