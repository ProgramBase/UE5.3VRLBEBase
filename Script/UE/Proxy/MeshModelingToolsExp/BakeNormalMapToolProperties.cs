using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BakeNormalMapToolProperties")]
	public partial class UBakeNormalMapToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BakeNormalMapToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}