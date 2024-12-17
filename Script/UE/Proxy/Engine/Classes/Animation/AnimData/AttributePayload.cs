using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AttributePayload")]
	public partial class FAttributePayload : FEmptyPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AttributePayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAttributePayload()
		{
		}

		public static bool operator ==(FAttributePayload A, FAttributePayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAttributePayload A, FAttributePayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAttributePayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAnimationAttributeIdentifier Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(FAnimationAttributeIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		private static uint __Identifier = 0;

	}
}