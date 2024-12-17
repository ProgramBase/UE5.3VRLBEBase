using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshGroupPaintToolFreezeActions")]
	public partial class UMeshGroupPaintToolFreezeActions : UMeshGroupPaintToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshGroupPaintToolFreezeActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnfreezeAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnfreezeAll);
			}
		}

		public virtual void ShrinkCurrent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShrinkCurrent);
			}
		}

		public virtual void GrowCurrent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __GrowCurrent);
			}
		}

		public virtual void FreezeOthers()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FreezeOthers);
			}
		}

		public virtual void FreezeCurrent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FreezeCurrent);
			}
		}

		public virtual void FloodFillCurrent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FloodFillCurrent);
			}
		}

		public virtual void ClearCurrent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearCurrent);
			}
		}

		public virtual void ClearAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearAll);
			}
		}

		private static uint __UnfreezeAll = 0;

		private static uint __ShrinkCurrent = 0;

		private static uint __GrowCurrent = 0;

		private static uint __FreezeOthers = 0;

		private static uint __FreezeCurrent = 0;

		private static uint __FloodFillCurrent = 0;

		private static uint __ClearCurrent = 0;

		private static uint __ClearAll = 0;
	}
}