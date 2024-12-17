using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraVMExecutableByteCode")]
	public partial class FNiagaraVMExecutableByteCode : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraVMExecutableByteCode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraVMExecutableByteCode() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraVMExecutableByteCode() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraVMExecutableByteCode A, FNiagaraVMExecutableByteCode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraVMExecutableByteCode A, FNiagaraVMExecutableByteCode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraVMExecutableByteCode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<byte> Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		public int UncompressedSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UncompressedSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UncompressedSize, __InBuffer);
				}
			}
		}

		private static uint __Data = 0;

		private static uint __UncompressedSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}