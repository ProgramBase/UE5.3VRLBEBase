using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptDataUsageInfo")]
	public partial class FNiagaraScriptDataUsageInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScriptDataUsageInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScriptDataUsageInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraScriptDataUsageInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraScriptDataUsageInfo A, FNiagaraScriptDataUsageInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScriptDataUsageInfo A, FNiagaraScriptDataUsageInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScriptDataUsageInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bReadsAttributeData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bReadsAttributeData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bReadsAttributeData, __InBuffer);
				}
			}
		}

		private static uint __bReadsAttributeData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}