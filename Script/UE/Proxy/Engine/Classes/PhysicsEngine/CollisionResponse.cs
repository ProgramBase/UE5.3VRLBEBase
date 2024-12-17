using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CollisionResponse")]
	public partial class FCollisionResponse : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CollisionResponse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollisionResponse() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCollisionResponse() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCollisionResponse A, FCollisionResponse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollisionResponse A, FCollisionResponse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollisionResponse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FCollisionResponseContainer ResponseToChannels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResponseToChannels, __ReturnBuffer);

					return *(FCollisionResponseContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResponseToChannels, __InBuffer);
				}
			}
		}

		public TArray<FResponseChannel> ResponseArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResponseArray, __ReturnBuffer);

					return *(TArray<FResponseChannel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResponseArray, __InBuffer);
				}
			}
		}

		private static uint __ResponseToChannels = 0;

		private static uint __ResponseArray = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}