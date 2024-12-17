using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.LODManagerMaterialActions")]
	public partial class ULODManagerMaterialActions : ULODManagerActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.LODManagerMaterialActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void CleanMaterials()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CleanMaterials);
			}
		}

		private static uint __CleanMaterials = 0;
	}
}