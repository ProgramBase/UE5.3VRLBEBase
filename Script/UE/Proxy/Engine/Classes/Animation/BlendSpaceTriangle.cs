using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlendSpaceTriangle")]
	public partial class FBlendSpaceTriangle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlendSpaceTriangle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpaceTriangle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlendSpaceTriangle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlendSpaceTriangle A, FBlendSpaceTriangle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpaceTriangle A, FBlendSpaceTriangle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpaceTriangle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SampleIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SampleIndices, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SampleIndices, __InBuffer);
				}
			}
		}

		public FVector2D Vertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertices, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vertices, __InBuffer);
				}
			}
		}

		public FBlendSpaceTriangleEdgeInfo EdgeInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EdgeInfo, __ReturnBuffer);

					return *(FBlendSpaceTriangleEdgeInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EdgeInfo, __InBuffer);
				}
			}
		}

		private static uint __SampleIndices = 0;

		private static uint __Vertices = 0;

		private static uint __EdgeInfo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}