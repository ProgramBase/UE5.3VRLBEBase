using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDeviceProfileStateEntry")]
	public partial class FNiagaraDeviceProfileStateEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDeviceProfileStateEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDeviceProfileStateEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDeviceProfileStateEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDeviceProfileStateEntry A, FNiagaraDeviceProfileStateEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDeviceProfileStateEntry A, FNiagaraDeviceProfileStateEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDeviceProfileStateEntry;

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

		public uint QualityLevelMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __QualityLevelMask, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __QualityLevelMask, __InBuffer);
				}
			}
		}

		public uint SetQualityLevelMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SetQualityLevelMask, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SetQualityLevelMask, __InBuffer);
				}
			}
		}

		private static uint __ProfileName = 0;

		private static uint __QualityLevelMask = 0;

		private static uint __SetQualityLevelMask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}