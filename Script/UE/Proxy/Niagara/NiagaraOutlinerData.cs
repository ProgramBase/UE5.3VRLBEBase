using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraOutlinerData")]
	public partial class FNiagaraOutlinerData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraOutlinerData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraOutlinerData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraOutlinerData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraOutlinerData A, FNiagaraOutlinerData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraOutlinerData A, FNiagaraOutlinerData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraOutlinerData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FNiagaraOutlinerWorldData> WorldData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldData, __ReturnBuffer);

					return *(TMap<FString, FNiagaraOutlinerWorldData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldData, __InBuffer);
				}
			}
		}

		private static uint __WorldData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}