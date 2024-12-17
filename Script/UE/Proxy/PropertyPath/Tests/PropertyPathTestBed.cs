using Script.CoreUObject;
using Script.Library;

namespace Script.PropertyPath
{
	[PathName("/Script/PropertyPath.PropertyPathTestBed")]
	public partial class FPropertyPathTestBed : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PropertyPath.PropertyPathTestBed");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyPathTestBed() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyPathTestBed() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyPathTestBed A, FPropertyPathTestBed B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyPathTestBed A, FPropertyPathTestBed B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyPathTestBed;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPropertyPathTestObject Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(UPropertyPathTestObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		public UPropertyPathTestObject ModifiedObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModifiedObject, __ReturnBuffer);

					return *(UPropertyPathTestObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModifiedObject, __InBuffer);
				}
			}
		}

		public FPropertyPathTestStruct ModifiedStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModifiedStruct, __ReturnBuffer);

					return *(FPropertyPathTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModifiedStruct, __InBuffer);
				}
			}
		}

		public FPropertyPathTestStruct DefaultStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultStruct, __ReturnBuffer);

					return *(FPropertyPathTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultStruct, __InBuffer);
				}
			}
		}

		private static uint __Object = 0;

		private static uint __ModifiedObject = 0;

		private static uint __ModifiedStruct = 0;

		private static uint __DefaultStruct = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}