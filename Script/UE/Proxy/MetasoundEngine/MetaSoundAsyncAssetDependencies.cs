using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundAsyncAssetDependencies")]
	public partial class FMetaSoundAsyncAssetDependencies : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundAsyncAssetDependencies");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundAsyncAssetDependencies() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaSoundAsyncAssetDependencies() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaSoundAsyncAssetDependencies A, FMetaSoundAsyncAssetDependencies B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundAsyncAssetDependencies A, FMetaSoundAsyncAssetDependencies B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundAsyncAssetDependencies;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject MetaSound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaSound, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaSound, __InBuffer);
				}
			}
		}

		private static uint __MetaSound = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}