using Script.CoreUObject;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.LODManagerHiResSourceModelActions")]
	public partial class ULODManagerHiResSourceModelActions : ULODManagerActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.LODManagerHiResSourceModelActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void MoveToLOD0()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MoveToLOD0);
			}
		}

		public virtual void Delete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Delete);
			}
		}

		private static uint __MoveToLOD0 = 0;

		private static uint __Delete = 0;
	}
}