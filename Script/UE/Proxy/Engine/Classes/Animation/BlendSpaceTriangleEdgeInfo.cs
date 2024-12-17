using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlendSpaceTriangleEdgeInfo")]
	public partial class FBlendSpaceTriangleEdgeInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlendSpaceTriangleEdgeInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpaceTriangleEdgeInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlendSpaceTriangleEdgeInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlendSpaceTriangleEdgeInfo A, FBlendSpaceTriangleEdgeInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpaceTriangleEdgeInfo A, FBlendSpaceTriangleEdgeInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpaceTriangleEdgeInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector2D Normal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Normal, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Normal, __InBuffer);
				}
			}
		}

		public int NeighbourTriangleIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NeighbourTriangleIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NeighbourTriangleIndex, __InBuffer);
				}
			}
		}

		public int AdjacentPerimeterTriangleIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdjacentPerimeterTriangleIndices, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdjacentPerimeterTriangleIndices, __InBuffer);
				}
			}
		}

		public int AdjacentPerimeterVertexIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdjacentPerimeterVertexIndices, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdjacentPerimeterVertexIndices, __InBuffer);
				}
			}
		}

		private static uint __Normal = 0;

		private static uint __NeighbourTriangleIndex = 0;

		private static uint __AdjacentPerimeterTriangleIndices = 0;

		private static uint __AdjacentPerimeterVertexIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}