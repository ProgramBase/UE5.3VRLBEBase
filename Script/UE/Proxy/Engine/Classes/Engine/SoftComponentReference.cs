using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoftComponentReference")]
	public partial class FSoftComponentReference : FBaseComponentReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoftComponentReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoftComponentReference()
		{
		}

		public static bool operator ==(FSoftComponentReference A, FSoftComponentReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoftComponentReference A, FSoftComponentReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoftComponentReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftObjectPtr<AActor> OtherActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OtherActor, __ReturnBuffer);

					return *(TSoftObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OtherActor, __InBuffer);
				}
			}
		}

		private static uint __OtherActor = 0;

	}
}