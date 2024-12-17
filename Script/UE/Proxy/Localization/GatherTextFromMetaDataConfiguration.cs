using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.GatherTextFromMetaDataConfiguration")]
	public partial class FGatherTextFromMetaDataConfiguration : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.GatherTextFromMetaDataConfiguration");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGatherTextFromMetaDataConfiguration() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGatherTextFromMetaDataConfiguration() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGatherTextFromMetaDataConfiguration A, FGatherTextFromMetaDataConfiguration B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGatherTextFromMetaDataConfiguration A, FGatherTextFromMetaDataConfiguration B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGatherTextFromMetaDataConfiguration;

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

		public TArray<FMetaDataKeyGatherSpecification> KeySpecifications
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __KeySpecifications, __ReturnBuffer);

					return *(TArray<FMetaDataKeyGatherSpecification>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __KeySpecifications, __InBuffer);
				}
			}
		}

		public TArray<FString> FieldTypesToInclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldTypesToInclude, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldTypesToInclude, __InBuffer);
				}
			}
		}

		public TArray<FString> FieldTypesToExclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldTypesToExclude, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldTypesToExclude, __InBuffer);
				}
			}
		}

		public TArray<FString> FieldOwnerTypesToInclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldOwnerTypesToInclude, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldOwnerTypesToInclude, __InBuffer);
				}
			}
		}

		public TArray<FString> FieldOwnerTypesToExclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FieldOwnerTypesToExclude, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FieldOwnerTypesToExclude, __InBuffer);
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

		private static uint __IncludePathWildcards = 0;

		private static uint __ExcludePathWildcards = 0;

		private static uint __KeySpecifications = 0;

		private static uint __FieldTypesToInclude = 0;

		private static uint __FieldTypesToExclude = 0;

		private static uint __FieldOwnerTypesToInclude = 0;

		private static uint __FieldOwnerTypesToExclude = 0;

		private static uint __ShouldGatherFromEditorOnlyData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}