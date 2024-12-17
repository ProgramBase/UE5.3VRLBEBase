using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolActions_Triangles")]
	public partial class UEditMeshPolygonsToolActions_Triangles : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolActions_Triangles");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RecalcNormals()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RecalcNormals);
			}
		}

		public virtual void PushPull()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PushPull);
			}
		}

		public virtual void Poke()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Poke);
			}
		}

		public virtual void Outset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Outset);
			}
		}

		public virtual void Offset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Offset);
			}
		}

		public virtual void Inset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Inset);
			}
		}

		public virtual void Flip()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Flip);
			}
		}

		public virtual void Extrude()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Extrude);
			}
		}

		public virtual void Duplicate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Duplicate);
			}
		}

		public virtual void Disconnect()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Disconnect);
			}
		}

		public virtual void Delete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Delete);
			}
		}

		public virtual void CutFaces()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CutFaces);
			}
		}

		private static uint __RecalcNormals = 0;

		private static uint __PushPull = 0;

		private static uint __Poke = 0;

		private static uint __Outset = 0;

		private static uint __Offset = 0;

		private static uint __Inset = 0;

		private static uint __Flip = 0;

		private static uint __Extrude = 0;

		private static uint __Duplicate = 0;

		private static uint __Disconnect = 0;

		private static uint __Delete = 0;

		private static uint __CutFaces = 0;
	}
}