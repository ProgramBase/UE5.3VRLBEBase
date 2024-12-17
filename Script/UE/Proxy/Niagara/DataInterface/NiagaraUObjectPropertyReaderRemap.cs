using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraUObjectPropertyReaderRemap")]
	public partial class FNiagaraUObjectPropertyReaderRemap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraUObjectPropertyReaderRemap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraUObjectPropertyReaderRemap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraUObjectPropertyReaderRemap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraUObjectPropertyReaderRemap A, FNiagaraUObjectPropertyReaderRemap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraUObjectPropertyReaderRemap A, FNiagaraUObjectPropertyReaderRemap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraUObjectPropertyReaderRemap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName GraphName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GraphName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GraphName, __InBuffer);
				}
			}
		}

		public FName RemapName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RemapName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RemapName, __InBuffer);
				}
			}
		}

		private static uint __GraphName = 0;

		private static uint __RemapName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}