using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlendSpaceBlendProfile")]
	public partial class FBlendSpaceBlendProfile : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlendSpaceBlendProfile");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendSpaceBlendProfile() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlendSpaceBlendProfile() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlendSpaceBlendProfile A, FBlendSpaceBlendProfile B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendSpaceBlendProfile A, FBlendSpaceBlendProfile B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendSpaceBlendProfile;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UBlendProfile BlendProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendProfile, __ReturnBuffer);

					return *(UBlendProfile*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendProfile, __InBuffer);
				}
			}
		}

		public float TargetWeightInterpolationSpeedPerSec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetWeightInterpolationSpeedPerSec, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetWeightInterpolationSpeedPerSec, __InBuffer);
				}
			}
		}

		private static uint __BlendProfile = 0;

		private static uint __TargetWeightInterpolationSpeedPerSec = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}