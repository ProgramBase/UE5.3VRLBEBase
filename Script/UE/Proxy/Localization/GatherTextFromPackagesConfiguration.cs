using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.GatherTextFromPackagesConfiguration")]
	public partial class FGatherTextFromPackagesConfiguration : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.GatherTextFromPackagesConfiguration");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGatherTextFromPackagesConfiguration() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGatherTextFromPackagesConfiguration() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGatherTextFromPackagesConfiguration A, FGatherTextFromPackagesConfiguration B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGatherTextFromPackagesConfiguration A, FGatherTextFromPackagesConfiguration B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGatherTextFromPackagesConfiguration;

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

		public TArray<FGatherTextIncludePath> IncludePathWildcards
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IncludePathWildcards, __ReturnBuffer);

					return *(TArray<FGatherTextIncludePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IncludePathWildcards, __InBuffer);
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

		public TArray<FName> Collections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collections, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collections, __InBuffer);
				}
			}
		}

		public TArray<FSoftClassPath> ExcludeClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeClasses, __ReturnBuffer);

					return *(TArray<FSoftClassPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExcludeClasses, __InBuffer);
				}
			}
		}

		public bool ShouldExcludeDerivedClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShouldExcludeDerivedClasses, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShouldExcludeDerivedClasses, __InBuffer);
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

		public bool SkipGatherCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkipGatherCache, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkipGatherCache, __InBuffer);
				}
			}
		}

		private static uint __IsEnabled = 0;

		private static uint __IncludePathWildcards = 0;

		private static uint __ExcludePathWildcards = 0;

		private static uint __FileExtensions = 0;

		private static uint __Collections = 0;

		private static uint __ExcludeClasses = 0;

		private static uint __ShouldExcludeDerivedClasses = 0;

		private static uint __ShouldGatherFromEditorOnlyData = 0;

		private static uint __SkipGatherCache = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}