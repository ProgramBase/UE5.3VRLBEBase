using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AsyncPhysicsTimestamp")]
	public partial class FAsyncPhysicsTimestamp : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AsyncPhysicsTimestamp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAsyncPhysicsTimestamp() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAsyncPhysicsTimestamp() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAsyncPhysicsTimestamp A, FAsyncPhysicsTimestamp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAsyncPhysicsTimestamp A, FAsyncPhysicsTimestamp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAsyncPhysicsTimestamp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int ServerFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ServerFrame, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ServerFrame, __InBuffer);
				}
			}
		}

		public int LocalFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalFrame, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalFrame, __InBuffer);
				}
			}
		}

		private static uint __ServerFrame = 0;

		private static uint __LocalFrame = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}