using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.GeometrySelectionEditCommandResult")]
	public partial class UGeometrySelectionEditCommandResult : UInteractiveCommandResult, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.GeometrySelectionEditCommandResult");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}