using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceEmitterBinding")]
	public partial class FNiagaraDataInterfaceEmitterBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraDataInterfaceEmitterBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraDataInterfaceEmitterBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraDataInterfaceEmitterBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraDataInterfaceEmitterBinding A, FNiagaraDataInterfaceEmitterBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraDataInterfaceEmitterBinding A, FNiagaraDataInterfaceEmitterBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraDataInterfaceEmitterBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ENiagaraDataInterfaceEmitterBindingMode BindingMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingMode, __ReturnBuffer);

					return *(ENiagaraDataInterfaceEmitterBindingMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingMode, __InBuffer);
				}
			}
		}

		public FName EmitterName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmitterName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmitterName, __InBuffer);
				}
			}
		}

		private static uint __BindingMode = 0;

		private static uint __EmitterName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}