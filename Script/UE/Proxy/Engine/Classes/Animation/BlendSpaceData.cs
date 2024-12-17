using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlendSpaceData")]
	public partial class FBlendSpaceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlendSpaceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpaceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlendSpaceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlendSpaceData A, FBlendSpaceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpaceData A, FBlendSpaceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpaceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBlendSpaceSegment> Segments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __ReturnBuffer);

					return *(TArray<FBlendSpaceSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __InBuffer);
				}
			}
		}

		public TArray<FBlendSpaceTriangle> Triangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Triangles, __ReturnBuffer);

					return *(TArray<FBlendSpaceTriangle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Triangles, __InBuffer);
				}
			}
		}

		private static uint __Segments = 0;

		private static uint __Triangles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}