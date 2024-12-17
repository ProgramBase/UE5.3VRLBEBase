using Script.CoreUObject;
using Script.MeshDescription;
using Script.Library;

namespace Script.StaticMeshDescription
{
	[PathName("/Script/StaticMeshDescription.StaticMeshDescription")]
	public partial class UStaticMeshDescription : UMeshDescriptionBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StaticMeshDescription.StaticMeshDescription");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID, FVector2D UV, int UVIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UV?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = UVIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVertexInstanceUV, __InBuffer);
			}
		}

		public virtual void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID, FName SlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PolygonGroupID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPolygonGroupMaterialSlotName, __InBuffer);
			}
		}

		public virtual FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID, int UVIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = VertexInstanceID?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = UVIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexInstanceUV, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual void CreateCube(FVector Center, FVector HalfExtents, FPolygonGroupID PolygonGroup, ref FPolygonID PolygonID_PlusX, ref FPolygonID PolygonID_MinusX, ref FPolygonID PolygonID_PlusY, ref FPolygonID PolygonID_MinusY, ref FPolygonID PolygonID_PlusZ, ref FPolygonID PolygonID_MinusZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[72];

				*(nint*)(__InBuffer) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = HalfExtents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PolygonGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PolygonID_PlusX?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = PolygonID_MinusX?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = PolygonID_PlusY?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = PolygonID_MinusY?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = PolygonID_PlusZ?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 64) = PolygonID_MinusZ?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[48];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CreateCube, __InBuffer, __OutBuffer);

				PolygonID_PlusX = *(FPolygonID*)(__OutBuffer);

				PolygonID_MinusX = *(FPolygonID*)(__OutBuffer + 8);

				PolygonID_PlusY = *(FPolygonID*)(__OutBuffer + 16);

				PolygonID_MinusY = *(FPolygonID*)(__OutBuffer + 24);

				PolygonID_PlusZ = *(FPolygonID*)(__OutBuffer + 32);

				PolygonID_MinusZ = *(FPolygonID*)(__OutBuffer + 40);

			}
		}

		private static uint __SetVertexInstanceUV = 0;

		private static uint __SetPolygonGroupMaterialSlotName = 0;

		private static uint __GetVertexInstanceUV = 0;

		private static uint __CreateCube = 0;
	}
}