using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraMessageStore")]
	public partial class FNiagaraMessageStore : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraMessageStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraMessageStore() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraMessageStore() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraMessageStore A, FNiagaraMessageStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraMessageStore A, FNiagaraMessageStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraMessageStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FGuid, UNiagaraMessageDataBase> MessageKeyToMessageMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MessageKeyToMessageMap, __ReturnBuffer);

					return *(TMap<FGuid, UNiagaraMessageDataBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MessageKeyToMessageMap, __InBuffer);
				}
			}
		}

		public TArray<FGuid> DismissedMessageKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DismissedMessageKeys, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DismissedMessageKeys, __InBuffer);
				}
			}
		}

		private static uint __MessageKeyToMessageMap = 0;

		private static uint __DismissedMessageKeys = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}