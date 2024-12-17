using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend")]
	public partial class FAnimNode_MultiWayBlend : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_MultiWayBlend");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_MultiWayBlend()
		{
		}

		public static bool operator ==(FAnimNode_MultiWayBlend A, FAnimNode_MultiWayBlend B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_MultiWayBlend A, FAnimNode_MultiWayBlend B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_MultiWayBlend;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPoseLink> Poses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Poses, __ReturnBuffer);

					return *(TArray<FPoseLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Poses, __InBuffer);
				}
			}
		}

		public TArray<float> DesiredAlphas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DesiredAlphas, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DesiredAlphas, __InBuffer);
				}
			}
		}

		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaScaleBias, __ReturnBuffer);

					return *(FInputScaleBias*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaScaleBias, __InBuffer);
				}
			}
		}

		public bool bAdditiveNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAdditiveNode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAdditiveNode, __InBuffer);
				}
			}
		}

		public bool bNormalizeAlpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNormalizeAlpha, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNormalizeAlpha, __InBuffer);
				}
			}
		}

		private static uint __Poses = 0;

		private static uint __DesiredAlphas = 0;

		private static uint __AlphaScaleBias = 0;

		private static uint __bAdditiveNode = 0;

		private static uint __bNormalizeAlpha = 0;

	}
}