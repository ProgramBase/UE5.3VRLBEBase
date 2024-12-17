using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AssetManagerEditor
{
	[PathName("/Script/AssetManagerEditor.EdGraph_ReferenceViewer")]
	public partial class UEdGraph_ReferenceViewer : UEdGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetManagerEditor.EdGraph_ReferenceViewer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}