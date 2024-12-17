using Script.CoreUObject;
using Script.Library;

namespace Script.Serialization
{
	[PathName("/Script/Serialization.StructSerializerTestStruct")]
	public partial class FStructSerializerTestStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Serialization.StructSerializerTestStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStructSerializerTestStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStructSerializerTestStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStructSerializerTestStruct A, FStructSerializerTestStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStructSerializerTestStruct A, FStructSerializerTestStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStructSerializerTestStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FStructSerializerNumericTestStruct Numerics
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Numerics, __ReturnBuffer);

					return *(FStructSerializerNumericTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Numerics, __InBuffer);
				}
			}
		}

		public FStructSerializerBooleanTestStruct Booleans
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Booleans, __ReturnBuffer);

					return *(FStructSerializerBooleanTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Booleans, __InBuffer);
				}
			}
		}

		public FStructSerializerObjectTestStruct Objects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Objects, __ReturnBuffer);

					return *(FStructSerializerObjectTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Objects, __InBuffer);
				}
			}
		}

		public FStructSerializerBuiltinTestStruct Builtins
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Builtins, __ReturnBuffer);

					return *(FStructSerializerBuiltinTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Builtins, __InBuffer);
				}
			}
		}

		public FStructSerializerArrayTestStruct Arrays
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Arrays, __ReturnBuffer);

					return *(FStructSerializerArrayTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Arrays, __InBuffer);
				}
			}
		}

		public FStructSerializerMapTestStruct Maps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Maps, __ReturnBuffer);

					return *(FStructSerializerMapTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Maps, __InBuffer);
				}
			}
		}

		public FStructSerializerSetTestStruct Sets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sets, __ReturnBuffer);

					return *(FStructSerializerSetTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sets, __InBuffer);
				}
			}
		}

		public FStructSerializerLWCTypesTest LWCTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LWCTypes, __ReturnBuffer);

					return *(FStructSerializerLWCTypesTest*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LWCTypes, __InBuffer);
				}
			}
		}

		private static uint __Numerics = 0;

		private static uint __Booleans = 0;

		private static uint __Objects = 0;

		private static uint __Builtins = 0;

		private static uint __Arrays = 0;

		private static uint __Maps = 0;

		private static uint __Sets = 0;

		private static uint __LWCTypes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}