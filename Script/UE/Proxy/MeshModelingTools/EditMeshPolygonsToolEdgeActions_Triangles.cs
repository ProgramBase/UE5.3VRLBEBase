using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolEdgeActions_Triangles")]
	public partial class UEditMeshPolygonsToolEdgeActions_Triangles : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolEdgeActions_Triangles");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Weld()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Weld);
			}
		}

		public virtual void Split()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Split);
			}
		}

		public virtual void Flip()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Flip);
			}
		}

		public virtual void FillHole()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FillHole);
			}
		}

		public virtual void Collapse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Collapse);
			}
		}

		private static uint __Weld = 0;

		private static uint __Split = 0;

		private static uint __Flip = 0;

		private static uint __FillHole = 0;

		private static uint __Collapse = 0;
	}
}