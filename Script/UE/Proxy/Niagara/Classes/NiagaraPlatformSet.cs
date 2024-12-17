using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPlatformSet")]
	public partial class FNiagaraPlatformSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraPlatformSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraPlatformSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraPlatformSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraPlatformSet A, FNiagaraPlatformSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraPlatformSet A, FNiagaraPlatformSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraPlatformSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceProfileStates, __ReturnBuffer);

					return *(TArray<FNiagaraDeviceProfileStateEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceProfileStates, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraPlatformSetCVarCondition> CVarConditions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditions, __ReturnBuffer);

					return *(TArray<FNiagaraPlatformSetCVarCondition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CVarConditions, __InBuffer);
				}
			}
		}

		public int QualityLevelMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QualityLevelMask, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QualityLevelMask, __InBuffer);
				}
			}
		}

		private static uint __DeviceProfileStates = 0;

		private static uint __CVarConditions = 0;

		private static uint __QualityLevelMask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}