using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.LODManagerTool")]
	public partial class ULODManagerTool : UMultiSelectionMeshEditingTool, IStaticClass
	{
		public ULODManagerLODProperties LODInfoProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfoProperties, __ReturnBuffer);

					return *(ULODManagerLODProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfoProperties, __InBuffer);
				}
			}
		}

		public ULODManagerPreviewLODProperties LODPreviewProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreviewProperties, __ReturnBuffer);

					return *(ULODManagerPreviewLODProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreviewProperties, __InBuffer);
				}
			}
		}

		public ULODManagerHiResSourceModelActions HiResSourceModelActions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiResSourceModelActions, __ReturnBuffer);

					return *(ULODManagerHiResSourceModelActions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiResSourceModelActions, __InBuffer);
				}
			}
		}

		public ULODManagerMaterialActions MaterialActions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialActions, __ReturnBuffer);

					return *(ULODManagerMaterialActions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialActions, __InBuffer);
				}
			}
		}

		public UPreviewMesh LODPreview
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreview, __ReturnBuffer);

					return *(UPreviewMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreview, __InBuffer);
				}
			}
		}

		public UPreviewGeometry LODPreviewLines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreviewLines, __ReturnBuffer);

					return *(UPreviewGeometry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODPreviewLines, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.LODManagerTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RemoveUnreferencedMaterials()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveUnreferencedMaterials);
			}
		}

		public virtual void MoveHiResToLOD0()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MoveHiResToLOD0);
			}
		}

		public virtual void DeleteHiResSourceModel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DeleteHiResSourceModel);
			}
		}

		private static uint __LODInfoProperties = 0;

		private static uint __LODPreviewProperties = 0;

		private static uint __HiResSourceModelActions = 0;

		private static uint __MaterialActions = 0;

		private static uint __LODPreview = 0;

		private static uint __LODPreviewLines = 0;

		private static uint __RemoveUnreferencedMaterials = 0;

		private static uint __MoveHiResToLOD0 = 0;

		private static uint __DeleteHiResSourceModel = 0;
	}
}