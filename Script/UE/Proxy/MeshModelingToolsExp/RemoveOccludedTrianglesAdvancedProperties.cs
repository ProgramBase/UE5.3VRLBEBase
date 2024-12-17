using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesAdvancedProperties")]
	public partial class URemoveOccludedTrianglesAdvancedProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesAdvancedProperties");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}