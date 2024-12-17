using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.GatherTextFromTextFilesConfiguration")]
	public partial class FGatherTextFromTextFilesConfiguration : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.GatherTextFromTextFilesConfiguration");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGatherTextFromTextFilesConfiguration() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGatherTextFromTextFilesConfiguration() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGatherTextFromTextFilesConfiguration A, FGatherTextFromTextFilesConfiguration B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGatherTextFromTextFilesConfiguration A, FGatherTextFromTextFilesConfiguration B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGatherTextFromTextFilesConfiguration;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool IsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IsEnabled, __InBuffer);
				}
			}
		}

		public TArray<FGatherTextSearchDirectory> SearchDirectories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SearchDirectories, __ReturnBuffer);

					return *(TArray<FGatherTextSearchDirectory>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SearchDirectories, __InBuffer);
				}
			}
		}

		public TArray<FGatherTextExcludePath> ExcludePathWildcards
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExcludePathWildcards, __ReturnBuffer);

					return *(TArray<FGatherTextExcludePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExcludePathWildcards, __InBuffer);
				}
			}
		}

		public TArray<FGatherTextFileExtension> FileExtensions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FileExtensions, __ReturnBuffer);

					return *(TArray<FGatherTextFileExtension>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FileExtensions, __InBuffer);
				}
			}
		}

		public bool ShouldGatherFromEditorOnlyData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShouldGatherFromEditorOnlyData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShouldGatherFromEditorOnlyData, __InBuffer);
				}
			}
		}

		private static uint __IsEnabled = 0;

		private static uint __SearchDirectories = 0;

		private static uint __ExcludePathWildcards = 0;

		private static uint __FileExtensions = 0;

		private static uint __ShouldGatherFromEditorOnlyData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}