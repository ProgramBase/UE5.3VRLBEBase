using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.GeometrySelectionEditCommand")]
	public partial class UGeometrySelectionEditCommand : UInteractiveCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.GeometrySelectionEditCommand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}