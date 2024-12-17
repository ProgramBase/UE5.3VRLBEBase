using Script.CoreUObject;
using Script.Library;
using Script.ToolWidgets;

namespace Script.EditorWidgets
{
	[PathName("/Script/EditorWidgets.FilterBarSettings")]
	public partial class FFilterBarSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorWidgets.FilterBarSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFilterBarSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFilterBarSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFilterBarSettings A, FFilterBarSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFilterBarSettings A, FFilterBarSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFilterBarSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, bool> CustomFilters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomFilters, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomFilters, __InBuffer);
				}
			}
		}

		public TMap<FString, bool> TypeFilters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TypeFilters, __ReturnBuffer);

					return *(TMap<FString, bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TypeFilters, __InBuffer);
				}
			}
		}

		public TArray<FCustomTextFilterState> CustomTextFilters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomTextFilters, __ReturnBuffer);

					return *(TArray<FCustomTextFilterState>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomTextFilters, __InBuffer);
				}
			}
		}

		public bool bIsLayoutSaved
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsLayoutSaved, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsLayoutSaved, __InBuffer);
				}
			}
		}

		public EFilterBarLayout FilterBarLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterBarLayout, __ReturnBuffer);

					return *(EFilterBarLayout*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterBarLayout, __InBuffer);
				}
			}
		}

		private static uint __CustomFilters = 0;

		private static uint __TypeFilters = 0;

		private static uint __CustomTextFilters = 0;

		private static uint __bIsLayoutSaved = 0;

		private static uint __FilterBarLayout = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}