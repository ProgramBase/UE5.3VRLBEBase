using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentReference")]
	public partial class FComponentReference : FBaseComponentReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ComponentReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FComponentReference()
		{
		}

		public static bool operator ==(FComponentReference A, FComponentReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FComponentReference A, FComponentReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FComponentReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<AActor> OtherActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OtherActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
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