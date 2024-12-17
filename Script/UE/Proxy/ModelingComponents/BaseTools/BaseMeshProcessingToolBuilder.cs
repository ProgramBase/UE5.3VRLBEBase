using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.BaseMeshProcessingToolBuilder")]
	public partial class UBaseMeshProcessingToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.BaseMeshProcessingToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}