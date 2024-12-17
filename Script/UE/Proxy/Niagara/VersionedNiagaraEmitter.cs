using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.VersionedNiagaraEmitter")]
	public partial class FVersionedNiagaraEmitter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.VersionedNiagaraEmitter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVersionedNiagaraEmitter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVersionedNiagaraEmitter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVersionedNiagaraEmitter A, FVersionedNiagaraEmitter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVersionedNiagaraEmitter A, FVersionedNiagaraEmitter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVersionedNiagaraEmitter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraEmitter Emitter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Emitter, __ReturnBuffer);

					return *(UNiagaraEmitter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Emitter, __InBuffer);
				}
			}
		}

		public FGuid Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		private static uint __Emitter = 0;

		private static uint __Version = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}