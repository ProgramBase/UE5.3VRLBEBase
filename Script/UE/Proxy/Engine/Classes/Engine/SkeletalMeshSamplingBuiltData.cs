using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshSamplingBuiltData")]
	public partial class FSkeletalMeshSamplingBuiltData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshSamplingBuiltData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshSamplingBuiltData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkeletalMeshSamplingBuiltData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkeletalMeshSamplingBuiltData A, FSkeletalMeshSamplingBuiltData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshSamplingBuiltData A, FSkeletalMeshSamplingBuiltData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshSamplingBuiltData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSkeletalMeshSamplingLODBuiltData> WholeMeshBuiltData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WholeMeshBuiltData, __ReturnBuffer);

					return *(TArray<FSkeletalMeshSamplingLODBuiltData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WholeMeshBuiltData, __InBuffer);
				}
			}
		}

		public TArray<FSkeletalMeshSamplingRegionBuiltData> RegionBuiltData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RegionBuiltData, __ReturnBuffer);

					return *(TArray<FSkeletalMeshSamplingRegionBuiltData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RegionBuiltData, __InBuffer);
				}
			}
		}

		private static uint __WholeMeshBuiltData = 0;

		private static uint __RegionBuiltData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}