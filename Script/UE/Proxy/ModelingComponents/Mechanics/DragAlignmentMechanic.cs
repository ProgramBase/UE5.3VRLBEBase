using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.DragAlignmentMechanic")]
	public partial class UDragAlignmentMechanic : UInteractionMechanic, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.DragAlignmentMechanic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}