using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEmitterScalabilitySettingsArray")]
	public partial class FNiagaraEmitterScalabilitySettingsArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraEmitterScalabilitySettingsArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraEmitterScalabilitySettingsArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraEmitterScalabilitySettingsArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraEmitterScalabilitySettingsArray A, FNiagaraEmitterScalabilitySettingsArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraEmitterScalabilitySettingsArray A, FNiagaraEmitterScalabilitySettingsArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraEmitterScalabilitySettingsArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraEmitterScalabilitySettings> Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(TArray<FNiagaraEmitterScalabilitySettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		private static uint __Settings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}