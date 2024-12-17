using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSpaceDeformerToolActionPropertySet")]
	public partial class UMeshSpaceDeformerToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSpaceDeformerToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ShiftToCenter()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShiftToCenter);
			}
		}

		private static uint __ShiftToCenter = 0;
	}
}