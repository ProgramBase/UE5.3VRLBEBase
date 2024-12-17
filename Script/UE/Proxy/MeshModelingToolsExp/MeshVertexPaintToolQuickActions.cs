using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshVertexPaintToolQuickActions")]
	public partial class UMeshVertexPaintToolQuickActions : UMeshVertexPaintToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshVertexPaintToolQuickActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void PaintAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PaintAll);
			}
		}

		public virtual void FillWhite()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FillWhite);
			}
		}

		public virtual void FillBlack()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FillBlack);
			}
		}

		public virtual void EraseAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EraseAll);
			}
		}

		private static uint __PaintAll = 0;

		private static uint __FillWhite = 0;

		private static uint __FillBlack = 0;

		private static uint __EraseAll = 0;
	}
}