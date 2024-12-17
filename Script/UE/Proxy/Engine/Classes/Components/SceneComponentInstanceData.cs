using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneComponentInstanceData")]
	public partial class FSceneComponentInstanceData : FActorComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SceneComponentInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSceneComponentInstanceData()
		{
		}

		public static bool operator ==(FSceneComponentInstanceData A, FSceneComponentInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSceneComponentInstanceData A, FSceneComponentInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSceneComponentInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<USceneComponent, FTransform> AttachedInstanceComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedInstanceComponents, __ReturnBuffer);

					return *(TMap<USceneComponent, FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedInstanceComponents, __InBuffer);
				}
			}
		}

		private static uint __AttachedInstanceComponents = 0;

	}
}