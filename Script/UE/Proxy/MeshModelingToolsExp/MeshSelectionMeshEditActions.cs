using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSelectionMeshEditActions")]
	public partial class UMeshSelectionMeshEditActions : UMeshSelectionToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSelectionMeshEditActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SmoothBorder()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SmoothBorder);
			}
		}

		public virtual void Separate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Separate);
			}
		}

		public virtual void FlipNormals()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FlipNormals);
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

		public virtual void CreatePolygroup()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CreatePolygroup);
			}
		}

		private static uint __SmoothBorder = 0;

		private static uint __Separate = 0;

		private static uint __FlipNormals = 0;

		private static uint __Duplicate = 0;

		private static uint __Disconnect = 0;

		private static uint __Delete = 0;

		private static uint __CreatePolygroup = 0;
	}
}