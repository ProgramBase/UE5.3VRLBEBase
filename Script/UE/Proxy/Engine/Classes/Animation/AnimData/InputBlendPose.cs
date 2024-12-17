using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputBlendPose")]
	public partial class FInputBlendPose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.InputBlendPose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInputBlendPose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInputBlendPose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInputBlendPose A, FInputBlendPose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInputBlendPose A, FInputBlendPose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInputBlendPose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FBranchFilter> BranchFilters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BranchFilters, __ReturnBuffer);

					return *(TArray<FBranchFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BranchFilters, __InBuffer);
				}
			}
		}

		private static uint __BranchFilters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}