using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundAssetDirectory")]
	public partial class FMetaSoundAssetDirectory : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEngine.MetaSoundAssetDirectory");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetaSoundAssetDirectory() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetaSoundAssetDirectory() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetaSoundAssetDirectory A, FMetaSoundAssetDirectory B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetaSoundAssetDirectory A, FMetaSoundAssetDirectory B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetaSoundAssetDirectory;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDirectoryPath Directory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Directory, __ReturnBuffer);

					return *(FDirectoryPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Directory, __InBuffer);
				}
			}
		}

		private static uint __Directory = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}