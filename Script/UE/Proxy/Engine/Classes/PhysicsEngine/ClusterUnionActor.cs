using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClusterUnionActor")]
	public partial class AClusterUnionActor : AActor, IStaticClass
	{
		public UClusterUnionComponent ClusterUnion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterUnion, __ReturnBuffer);

					return *(UClusterUnionComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterUnion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ClusterUnionActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UClusterUnionComponent GetClusterUnionComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetClusterUnionComponent, __ReturnBuffer);

				return *(UClusterUnionComponent*)__ReturnBuffer;
			}
		}

		private static uint __ClusterUnion = 0;

		private static uint __GetClusterUnionComponent = 0;
	}
}