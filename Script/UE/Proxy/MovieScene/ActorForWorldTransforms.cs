using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.ActorForWorldTransforms")]
	public partial class FActorForWorldTransforms : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.ActorForWorldTransforms");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorForWorldTransforms() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorForWorldTransforms() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorForWorldTransforms A, FActorForWorldTransforms B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorForWorldTransforms A, FActorForWorldTransforms B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorForWorldTransforms;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<AActor> Actor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USceneComponent> Component
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Component, __ReturnBuffer);

					return *(TWeakObjectPtr<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Component, __InBuffer);
				}
			}
		}

		public FName SocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __InBuffer);
				}
			}
		}

		private static uint __Actor = 0;

		private static uint __Component = 0;

		private static uint __SocketName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}