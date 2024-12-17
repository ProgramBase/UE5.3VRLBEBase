using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.SingleTargetWithSelectionToolBuilder")]
	public partial class USingleTargetWithSelectionToolBuilder : UInteractiveToolWithToolTargetsBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.SingleTargetWithSelectionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}