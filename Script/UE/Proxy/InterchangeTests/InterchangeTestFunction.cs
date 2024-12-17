using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.InterchangeTestFunction")]
	public partial class FInterchangeTestFunction : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeTests.InterchangeTestFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeTestFunction() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeTestFunction() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeTestFunction A, FInterchangeTestFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeTestFunction A, FInterchangeTestFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeTestFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObject> AssetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetClass, __InBuffer);
				}
			}
		}

		public FString OptionalAssetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OptionalAssetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OptionalAssetName, __InBuffer);
				}
			}
		}

		public UFunction CheckFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CheckFunction, __ReturnBuffer);

					return *(UFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CheckFunction, __InBuffer);
				}
			}
		}

		public TMap<FName, FString> Parameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Parameters, __ReturnBuffer);

					return *(TMap<FName, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Parameters, __InBuffer);
				}
			}
		}

		private static uint __AssetClass = 0;

		private static uint __OptionalAssetName = 0;

		private static uint __CheckFunction = 0;

		private static uint __Parameters = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}