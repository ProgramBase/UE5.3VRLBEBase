using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.Engine
{
	[PathName("/Script/Engine.PropertyAccessIndirectionChain")]
	public partial class FPropertyAccessIndirectionChain : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PropertyAccessIndirectionChain");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyAccessIndirectionChain() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyAccessIndirectionChain() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyAccessIndirectionChain A, FPropertyAccessIndirectionChain B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyAccessIndirectionChain A, FPropertyAccessIndirectionChain B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyAccessIndirectionChain;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TFieldPath<FProperty> Property
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Property, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Property, __InBuffer);
				}
			}
		}

		public int IndirectionStartIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IndirectionStartIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IndirectionStartIndex, __InBuffer);
				}
			}
		}

		public int IndirectionEndIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IndirectionEndIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IndirectionEndIndex, __InBuffer);
				}
			}
		}

		private static uint __Property = 0;

		private static uint __IndirectionStartIndex = 0;

		private static uint __IndirectionEndIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}