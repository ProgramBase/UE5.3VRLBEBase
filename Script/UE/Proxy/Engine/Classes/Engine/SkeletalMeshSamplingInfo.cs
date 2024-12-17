using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMeshSamplingInfo")]
	public partial class FSkeletalMeshSamplingInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkeletalMeshSamplingInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkeletalMeshSamplingInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkeletalMeshSamplingInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkeletalMeshSamplingInfo A, FSkeletalMeshSamplingInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkeletalMeshSamplingInfo A, FSkeletalMeshSamplingInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkeletalMeshSamplingInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSkeletalMeshSamplingRegion> Regions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Regions, __ReturnBuffer);

					return *(TArray<FSkeletalMeshSamplingRegion>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Regions, __InBuffer);
				}
			}
		}

		public FSkeletalMeshSamplingBuiltData BuiltData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BuiltData, __ReturnBuffer);

					return *(FSkeletalMeshSamplingBuiltData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BuiltData, __InBuffer);
				}
			}
		}

		private static uint __Regions = 0;

		private static uint __BuiltData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}