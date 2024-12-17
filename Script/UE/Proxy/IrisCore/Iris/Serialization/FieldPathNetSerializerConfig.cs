using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.FieldPathNetSerializerConfig")]
	public partial class FFieldPathNetSerializerConfig : FNetSerializerConfig, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.FieldPathNetSerializerConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFieldPathNetSerializerConfig()
		{
		}

		public static bool operator ==(FFieldPathNetSerializerConfig A, FFieldPathNetSerializerConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFieldPathNetSerializerConfig A, FFieldPathNetSerializerConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFieldPathNetSerializerConfig;

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

		private static uint __Property = 0;

	}
}