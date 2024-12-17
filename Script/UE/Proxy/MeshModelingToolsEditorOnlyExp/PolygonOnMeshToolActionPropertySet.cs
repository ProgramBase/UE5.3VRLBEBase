using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.PolygonOnMeshToolActionPropertySet")]
	public partial class UPolygonOnMeshToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.PolygonOnMeshToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void DrawPolygon()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DrawPolygon);
			}
		}

		private static uint __DrawPolygon = 0;
	}
}