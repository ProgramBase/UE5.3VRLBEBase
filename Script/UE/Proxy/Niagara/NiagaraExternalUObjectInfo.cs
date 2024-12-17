using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraExternalUObjectInfo")]
	public partial class FNiagaraExternalUObjectInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraExternalUObjectInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraExternalUObjectInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraExternalUObjectInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraExternalUObjectInfo A, FNiagaraExternalUObjectInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraExternalUObjectInfo A, FNiagaraExternalUObjectInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraExternalUObjectInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariableBase Variable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __ReturnBuffer);

					return *(FNiagaraVariableBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __InBuffer);
				}
			}
		}

		public FName ExternalName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalName, __InBuffer);
				}
			}
		}

		private static uint __Variable = 0;

		private static uint __ExternalName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}