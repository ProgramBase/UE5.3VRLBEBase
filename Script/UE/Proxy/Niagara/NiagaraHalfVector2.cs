using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraHalfVector2")]
	public partial class FNiagaraHalfVector2 : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraHalfVector2");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraHalfVector2() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraHalfVector2() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraHalfVector2 A, FNiagaraHalfVector2 B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraHalfVector2 A, FNiagaraHalfVector2 B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraHalfVector2;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ushort x
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __x, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __x, __InBuffer);
				}
			}
		}

		public ushort y
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __y, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __y, __InBuffer);
				}
			}
		}

		private static uint __x = 0;

		private static uint __y = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}