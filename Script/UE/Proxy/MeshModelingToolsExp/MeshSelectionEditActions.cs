using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSelectionEditActions")]
	public partial class UMeshSelectionEditActions : UMeshSelectionToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSelectionEditActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Shrink()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Shrink);
			}
		}

		public virtual void SelectAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectAll);
			}
		}

		public virtual void OptimizeBorder()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OptimizeBorder);
			}
		}

		public virtual void LargestTriCountPart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __LargestTriCountPart);
			}
		}

		public virtual void LargestAreaPart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __LargestAreaPart);
			}
		}

		public virtual void Invert()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Invert);
			}
		}

		public virtual void Grow()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Grow);
			}
		}

		public virtual void FloodFill()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FloodFill);
			}
		}

		public virtual void ExpandToMaterials()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ExpandToMaterials);
			}
		}

		public virtual void Clear()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Clear);
			}
		}

		private static uint __Shrink = 0;

		private static uint __SelectAll = 0;

		private static uint __OptimizeBorder = 0;

		private static uint __LargestTriCountPart = 0;

		private static uint __LargestAreaPart = 0;

		private static uint __Invert = 0;

		private static uint __Grow = 0;

		private static uint __FloodFill = 0;

		private static uint __ExpandToMaterials = 0;

		private static uint __Clear = 0;
	}
}