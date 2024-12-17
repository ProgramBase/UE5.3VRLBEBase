using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.DragAlignmentInteraction")]
	public partial class UDragAlignmentInteraction : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.DragAlignmentInteraction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}