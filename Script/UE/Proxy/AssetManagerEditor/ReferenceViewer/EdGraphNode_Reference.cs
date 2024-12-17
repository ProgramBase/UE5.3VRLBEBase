using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AssetManagerEditor
{
	[PathName("/Script/AssetManagerEditor.EdGraphNode_Reference")]
	public partial class UEdGraphNode_Reference : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetManagerEditor.EdGraphNode_Reference");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}