using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraGraphParameterReferenceCollection")]
	public partial class FNiagaraGraphParameterReferenceCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraGraphParameterReferenceCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraGraphParameterReferenceCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraGraphParameterReferenceCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraGraphParameterReferenceCollection A, FNiagaraGraphParameterReferenceCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraGraphParameterReferenceCollection A, FNiagaraGraphParameterReferenceCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraGraphParameterReferenceCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraGraphParameterReference> ParameterReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterReferences, __ReturnBuffer);

					return *(TArray<FNiagaraGraphParameterReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterReferences, __InBuffer);
				}
			}
		}

		public bool bCreatedByUser
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCreatedByUser, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCreatedByUser, __InBuffer);
				}
			}
		}

		private static uint __ParameterReferences = 0;

		private static uint __bCreatedByUser = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}