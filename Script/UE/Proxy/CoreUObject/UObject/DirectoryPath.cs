using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DirectoryPath")]
	public partial class FDirectoryPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.DirectoryPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDirectoryPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDirectoryPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDirectoryPath A, FDirectoryPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDirectoryPath A, FDirectoryPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDirectoryPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Path
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Path, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Path, __InBuffer);
				}
			}
		}

		private static uint __Path = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}