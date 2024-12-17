using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive")]
	public partial class FAnimNode_MakeDynamicAdditive : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_MakeDynamicAdditive()
		{
		}

		public static bool operator ==(FAnimNode_MakeDynamicAdditive A, FAnimNode_MakeDynamicAdditive B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_MakeDynamicAdditive A, FAnimNode_MakeDynamicAdditive B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_MakeDynamicAdditive;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink Base
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Base, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Base, __InBuffer);
				}
			}
		}

		public FPoseLink Additive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Additive, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Additive, __InBuffer);
				}
			}
		}

		public bool bMeshSpaceAdditive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMeshSpaceAdditive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMeshSpaceAdditive, __InBuffer);
				}
			}
		}

		private static uint __Base = 0;

		private static uint __Additive = 0;

		private static uint __bMeshSpaceAdditive = 0;

	}
}