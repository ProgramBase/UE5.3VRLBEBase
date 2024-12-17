using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.SignKeyEntry")]
	public partial class FSignKeyEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.SignKeyEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSignKeyEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSignKeyEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSignKeyEntry A, FSignKeyEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSignKeyEntry A, FSignKeyEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSignKeyEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSignKeyItem PublicKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PublicKey, __ReturnBuffer);

					return *(FSignKeyItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PublicKey, __InBuffer);
				}
			}
		}

		public FSignKeyItem PrivateKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrivateKey, __ReturnBuffer);

					return *(FSignKeyItem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrivateKey, __InBuffer);
				}
			}
		}

		private static uint __PublicKey = 0;

		private static uint __PrivateKey = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}