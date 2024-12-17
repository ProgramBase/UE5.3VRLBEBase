using Script.CoreUObject;
using Script.Library;

namespace Script.Serialization
{
	[PathName("/Script/Serialization.StructSerializerMapTestStruct")]
	public partial class FStructSerializerMapTestStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Serialization.StructSerializerMapTestStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructSerializerMapTestStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStructSerializerMapTestStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStructSerializerMapTestStruct A, FStructSerializerMapTestStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructSerializerMapTestStruct A, FStructSerializerMapTestStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructSerializerMapTestStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<int, FString> IntToStr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntToStr, __ReturnBuffer);

					return *(TMap<int, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntToStr, __InBuffer);
				}
			}
		}

		public TMap<FString, FString> StrToStr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrToStr, __ReturnBuffer);

					return *(TMap<FString, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrToStr, __InBuffer);
				}
			}
		}

		public TMap<FString, FVector> StrToVec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrToVec, __ReturnBuffer);

					return *(TMap<FString, FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrToVec, __InBuffer);
				}
			}
		}

		public TMap<FString, FStructSerializerBuiltinTestStruct> StrToStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrToStruct, __ReturnBuffer);

					return *(TMap<FString, FStructSerializerBuiltinTestStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrToStruct, __InBuffer);
				}
			}
		}

		private static uint __IntToStr = 0;

		private static uint __StrToStr = 0;

		private static uint __StrToVec = 0;

		private static uint __StrToStruct = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}