using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.TriangulateSplinesToolBuilder")]
	public partial class UTriangulateSplinesToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.TriangulateSplinesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}