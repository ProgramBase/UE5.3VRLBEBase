using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.DrawAndRevolveToolBuilder")]
	public partial class UDrawAndRevolveToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.DrawAndRevolveToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}