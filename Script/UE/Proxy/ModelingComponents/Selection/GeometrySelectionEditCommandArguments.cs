using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.GeometrySelectionEditCommandArguments")]
	public partial class UGeometrySelectionEditCommandArguments : UInteractiveCommandArguments, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.GeometrySelectionEditCommandArguments");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}