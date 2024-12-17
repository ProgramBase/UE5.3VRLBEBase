using Script.CoreUObject;
using Script.Library;

namespace Script.PropertyPath
{
	[PathName("/Script/PropertyPath.CachedPropertyPath")]
	public partial class FCachedPropertyPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PropertyPath.CachedPropertyPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedPropertyPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedPropertyPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedPropertyPath A, FCachedPropertyPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedPropertyPath A, FCachedPropertyPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedPropertyPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPropertyPathSegment> Segments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __ReturnBuffer);

					return *(TArray<FPropertyPathSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Segments, __InBuffer);
				}
			}
		}

		public UFunction CachedFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedFunction, __ReturnBuffer);

					return *(UFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedFunction, __InBuffer);
				}
			}
		}

		private static uint __Segments = 0;

		private static uint __CachedFunction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}