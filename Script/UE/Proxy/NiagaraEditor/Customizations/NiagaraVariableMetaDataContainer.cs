using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraVariableMetaDataContainer")]
	public partial class FNiagaraVariableMetaDataContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraVariableMetaDataContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVariableMetaDataContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraVariableMetaDataContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraVariableMetaDataContainer A, FNiagaraVariableMetaDataContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVariableMetaDataContainer A, FNiagaraVariableMetaDataContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVariableMetaDataContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariableMetaData MetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __ReturnBuffer);

					return *(FNiagaraVariableMetaData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaData, __InBuffer);
				}
			}
		}

		private static uint __MetaData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}