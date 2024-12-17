using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.CookAdvancedOptions")]
	public partial class FCookAdvancedOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.CookAdvancedOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCookAdvancedOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCookAdvancedOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCookAdvancedOptions A, FCookAdvancedOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCookAdvancedOptions A, FCookAdvancedOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCookAdvancedOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCookParallelSerialize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCookParallelSerialize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCookParallelSerialize, __InBuffer);
				}
			}
		}

		public int NumberOfAssetsPerFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfAssetsPerFrame, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfAssetsPerFrame, __InBuffer);
				}
			}
		}

		public TMap<UClass, int> OverrideNumberOfAssetsPerFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNumberOfAssetsPerFrame, __ReturnBuffer);

					return *(TMap<UClass, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OverrideNumberOfAssetsPerFrame, __InBuffer);
				}
			}
		}

		public bool bAccompanyCookForShader
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAccompanyCookForShader, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAccompanyCookForShader, __InBuffer);
				}
			}
		}

		private static uint __bCookParallelSerialize = 0;

		private static uint __NumberOfAssetsPerFrame = 0;

		private static uint __OverrideNumberOfAssetsPerFrame = 0;

		private static uint __bAccompanyCookForShader = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}