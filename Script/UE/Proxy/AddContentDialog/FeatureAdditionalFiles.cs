using Script.CoreUObject;
using Script.Library;

namespace Script.AddContentDialog
{
	[PathName("/Script/AddContentDialog.FeatureAdditionalFiles")]
	public partial class FFeatureAdditionalFiles : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AddContentDialog.FeatureAdditionalFiles");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFeatureAdditionalFiles() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFeatureAdditionalFiles() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFeatureAdditionalFiles A, FFeatureAdditionalFiles B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFeatureAdditionalFiles A, FFeatureAdditionalFiles B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFeatureAdditionalFiles;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DestinationFilesFolder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DestinationFilesFolder, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DestinationFilesFolder, __InBuffer);
				}
			}
		}

		public TArray<FString> AdditionalFilesList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalFilesList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalFilesList, __InBuffer);
				}
			}
		}

		private static uint __DestinationFilesFolder = 0;

		private static uint __AdditionalFilesList = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}