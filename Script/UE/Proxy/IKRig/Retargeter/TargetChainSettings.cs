using Script.CoreUObject;
using Script.Library;

namespace Script.IKRig
{
	[PathName("/Script/IKRig.TargetChainSettings")]
	public partial class FTargetChainSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IKRig.TargetChainSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetChainSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetChainSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetChainSettings A, FTargetChainSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetChainSettings A, FTargetChainSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetChainSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTargetChainFKSettings FK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FK, __ReturnBuffer);

					return *(FTargetChainFKSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FK, __InBuffer);
				}
			}
		}

		public FTargetChainIKSettings IK
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IK, __ReturnBuffer);

					return *(FTargetChainIKSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IK, __InBuffer);
				}
			}
		}

		public FTargetChainSpeedPlantSettings SpeedPlanting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpeedPlanting, __ReturnBuffer);

					return *(FTargetChainSpeedPlantSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpeedPlanting, __InBuffer);
				}
			}
		}

		private static uint __FK = 0;

		private static uint __IK = 0;

		private static uint __SpeedPlanting = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}