using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SimpleCollisionEditorToolBuilder")]
	public partial class USimpleCollisionEditorToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SimpleCollisionEditorToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}