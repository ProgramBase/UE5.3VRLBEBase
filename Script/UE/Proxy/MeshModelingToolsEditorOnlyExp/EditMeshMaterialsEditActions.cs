using Script.CoreUObject;
using Script.MeshModelingToolsExp;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsEditActions")]
	public partial class UEditMeshMaterialsEditActions : UMeshSelectionToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsEditActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void AssignActiveMaterial()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AssignActiveMaterial);
			}
		}

		private static uint __AssignActiveMaterial = 0;
	}
}