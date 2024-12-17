using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.LastResortPropertyNetSerializerConfig")]
	public partial class FLastResortPropertyNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.LastResortPropertyNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLastResortPropertyNetSerializerConfig()
		{
		}

		public static bool operator ==(FLastResortPropertyNetSerializerConfig A, FLastResortPropertyNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLastResortPropertyNetSerializerConfig A, FLastResortPropertyNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLastResortPropertyNetSerializerConfig;

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

		public uint MaxAllowedObjectReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedObjectReferences, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxAllowedObjectReferences, __InBuffer);
				}
			}
		}

		private static uint __Property = 0;

		private static uint __MaxAllowedObjectReferences = 0;

	}
}