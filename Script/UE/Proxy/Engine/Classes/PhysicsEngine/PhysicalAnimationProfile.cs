using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicalAnimationProfile")]
	public partial class FPhysicalAnimationProfile : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PhysicalAnimationProfile");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicalAnimationProfile() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicalAnimationProfile() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicalAnimationProfile A, FPhysicalAnimationProfile B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicalAnimationProfile A, FPhysicalAnimationProfile B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicalAnimationProfile;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileName, __InBuffer);
				}
			}
		}

		public FPhysicalAnimationData PhysicalAnimationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationData, __ReturnBuffer);

					return *(FPhysicalAnimationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalAnimationData, __InBuffer);
				}
			}
		}

		private static uint __ProfileName = 0;

		private static uint __PhysicalAnimationData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}