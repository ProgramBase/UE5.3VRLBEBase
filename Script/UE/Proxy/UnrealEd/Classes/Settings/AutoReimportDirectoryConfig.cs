using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AutoReimportDirectoryConfig")]
	public partial class FAutoReimportDirectoryConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.AutoReimportDirectoryConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutoReimportDirectoryConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutoReimportDirectoryConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutoReimportDirectoryConfig A, FAutoReimportDirectoryConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutoReimportDirectoryConfig A, FAutoReimportDirectoryConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutoReimportDirectoryConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString SourceDirectory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceDirectory, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceDirectory, __InBuffer);
				}
			}
		}

		public FString MountPoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MountPoint, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MountPoint, __InBuffer);
				}
			}
		}

		public TArray<FAutoReimportWildcard> Wildcards
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Wildcards, __ReturnBuffer);

					return *(TArray<FAutoReimportWildcard>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Wildcards, __InBuffer);
				}
			}
		}

		private static uint __SourceDirectory = 0;

		private static uint __MountPoint = 0;

		private static uint __Wildcards = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}