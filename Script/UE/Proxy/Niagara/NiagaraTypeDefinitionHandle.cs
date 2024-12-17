using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraTypeDefinitionHandle")]
	public partial class FNiagaraTypeDefinitionHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraTypeDefinitionHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraTypeDefinitionHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraTypeDefinitionHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraTypeDefinitionHandle A, FNiagaraTypeDefinitionHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraTypeDefinitionHandle A, FNiagaraTypeDefinitionHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraTypeDefinitionHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int RegisteredTypeIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredTypeIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RegisteredTypeIndex, __InBuffer);
				}
			}
		}

		private static uint __RegisteredTypeIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}