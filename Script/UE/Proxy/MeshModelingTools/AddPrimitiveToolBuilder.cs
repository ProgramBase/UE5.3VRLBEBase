using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.AddPrimitiveToolBuilder")]
	public partial class UAddPrimitiveToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.AddPrimitiveToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}