using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.SingleSelectionMeshEditingToolBuilder")]
	public partial class USingleSelectionMeshEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.SingleSelectionMeshEditingToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}