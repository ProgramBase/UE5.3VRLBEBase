using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEmitterScriptProperties")]
	public partial class FNiagaraEmitterScriptProperties : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraEmitterScriptProperties");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraEmitterScriptProperties() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraEmitterScriptProperties() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraEmitterScriptProperties A, FNiagaraEmitterScriptProperties B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraEmitterScriptProperties A, FNiagaraEmitterScriptProperties B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraEmitterScriptProperties;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraScript Script
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Script, __ReturnBuffer);

					return *(UNiagaraScript*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Script, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraEventReceiverProperties> EventReceivers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventReceivers, __ReturnBuffer);

					return *(TArray<FNiagaraEventReceiverProperties>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventReceivers, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraEventGeneratorProperties> EventGenerators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventGenerators, __ReturnBuffer);

					return *(TArray<FNiagaraEventGeneratorProperties>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventGenerators, __InBuffer);
				}
			}
		}

		private static uint __Script = 0;

		private static uint __EventReceivers = 0;

		private static uint __EventGenerators = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}