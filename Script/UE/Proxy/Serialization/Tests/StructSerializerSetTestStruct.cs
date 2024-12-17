using Script.CoreUObject;
using Script.Library;

namespace Script.Serialization
{
	[PathName("/Script/Serialization.StructSerializerSetTestStruct")]
	public partial class FStructSerializerSetTestStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Serialization.StructSerializerSetTestStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructSerializerSetTestStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStructSerializerSetTestStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStructSerializerSetTestStruct A, FStructSerializerSetTestStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructSerializerSetTestStruct A, FStructSerializerSetTestStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructSerializerSetTestStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FString> StrSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrSet, __ReturnBuffer);

					return *(TSet<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrSet, __InBuffer);
				}
			}
		}

		public TSet<int> IntSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntSet, __ReturnBuffer);

					return *(TSet<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntSet, __InBuffer);
				}
			}
		}

		public TSet<FName> NameSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NameSet, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NameSet, __InBuffer);
				}
			}
		}

		public TSet<FStructSerializerBuiltinTestStruct> StructSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StructSet, __ReturnBuffer);

					return *(TSet<FStructSerializerBuiltinTestStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StructSet, __InBuffer);
				}
			}
		}

		private static uint __StrSet = 0;

		private static uint __IntSet = 0;

		private static uint __NameSet = 0;

		private static uint __StructSet = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}