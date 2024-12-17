using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.MultiSelectionMeshEditingToolBuilder")]
	public partial class UMultiSelectionMeshEditingToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.MultiSelectionMeshEditingToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}