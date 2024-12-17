using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NCPool")]
	public partial class FNCPool : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NCPool");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNCPool() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNCPool() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNCPool A, FNCPool B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNCPool A, FNCPool B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNCPool;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNCPoolElement> FreeElements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FreeElements, __ReturnBuffer);

					return *(TArray<FNCPoolElement>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FreeElements, __InBuffer);
				}
			}
		}

		private static uint __FreeElements = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}