using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.FbxTestPlanExpectedResult")]
	public partial class FFbxTestPlanExpectedResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.FbxTestPlanExpectedResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFbxTestPlanExpectedResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFbxTestPlanExpectedResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFbxTestPlanExpectedResult A, FFbxTestPlanExpectedResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFbxTestPlanExpectedResult A, FFbxTestPlanExpectedResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFbxTestPlanExpectedResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EFBXExpectedResultPreset ExpectedPresetsType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsType, __ReturnBuffer);

					return *(EFBXExpectedResultPreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsType, __InBuffer);
				}
			}
		}

		public TArray<int> ExpectedPresetsDataInteger
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataInteger, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataInteger, __InBuffer);
				}
			}
		}

		public TArray<float> ExpectedPresetsDataFloat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataFloat, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataFloat, __InBuffer);
				}
			}
		}

		public TArray<double> ExpectedPresetsDataDouble
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataDouble, __ReturnBuffer);

					return *(TArray<double>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataDouble, __InBuffer);
				}
			}
		}

		public TArray<FString> ExpectedPresetsDataString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataString, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpectedPresetsDataString, __InBuffer);
				}
			}
		}

		private static uint __ExpectedPresetsType = 0;

		private static uint __ExpectedPresetsDataInteger = 0;

		private static uint __ExpectedPresetsDataFloat = 0;

		private static uint __ExpectedPresetsDataDouble = 0;

		private static uint __ExpectedPresetsDataString = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}