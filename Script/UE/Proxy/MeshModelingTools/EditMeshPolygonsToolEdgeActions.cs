using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolEdgeActions")]
	public partial class UEditMeshPolygonsToolEdgeActions : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolEdgeActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Weld()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Weld);
			}
		}

		public virtual void Straighten()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Straighten);
			}
		}

		public virtual void Simplify()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Simplify);
			}
		}

		public virtual void FillHole()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FillHole);
			}
		}

		public virtual void Bridge()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Bridge);
			}
		}

		public virtual void Bevel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Bevel);
			}
		}

		private static uint __Weld = 0;

		private static uint __Straighten = 0;

		private static uint __Simplify = 0;

		private static uint __FillHole = 0;

		private static uint __Bridge = 0;

		private static uint __Bevel = 0;
	}
}