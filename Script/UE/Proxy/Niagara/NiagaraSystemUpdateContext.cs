using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemUpdateContext")]
	public partial class FNiagaraSystemUpdateContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemUpdateContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemUpdateContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemUpdateContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemUpdateContext A, FNiagaraSystemUpdateContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemUpdateContext A, FNiagaraSystemUpdateContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemUpdateContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UNiagaraComponent> ComponentsToReset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToReset, __ReturnBuffer);

					return *(TArray<UNiagaraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToReset, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraComponent> ComponentsToReInit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToReInit, __ReturnBuffer);

					return *(TArray<UNiagaraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToReInit, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraComponent> ComponentsToNotifySimDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToNotifySimDestroy, __ReturnBuffer);

					return *(TArray<UNiagaraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentsToNotifySimDestroy, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraSystem> SystemSimsToDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemSimsToDestroy, __ReturnBuffer);

					return *(TArray<UNiagaraSystem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemSimsToDestroy, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraSystem> SystemSimsToRecache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemSimsToRecache, __ReturnBuffer);

					return *(TArray<UNiagaraSystem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemSimsToRecache, __InBuffer);
				}
			}
		}

		private static uint __ComponentsToReset = 0;

		private static uint __ComponentsToReInit = 0;

		private static uint __ComponentsToNotifySimDestroy = 0;

		private static uint __SystemSimsToDestroy = 0;

		private static uint __SystemSimsToRecache = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}