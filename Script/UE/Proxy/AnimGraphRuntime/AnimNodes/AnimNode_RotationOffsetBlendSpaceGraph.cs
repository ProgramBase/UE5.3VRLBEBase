﻿using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph")]
	public partial class FAnimNode_RotationOffsetBlendSpaceGraph : FAnimNode_BlendSpaceGraphBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_RotationOffsetBlendSpaceGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_RotationOffsetBlendSpaceGraph()
		{
		}

		public static bool operator ==(FAnimNode_RotationOffsetBlendSpaceGraph A, FAnimNode_RotationOffsetBlendSpaceGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_RotationOffsetBlendSpaceGraph A, FAnimNode_RotationOffsetBlendSpaceGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_RotationOffsetBlendSpaceGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink BasePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BasePose, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BasePose, __InBuffer);
				}
			}
		}

		public int LODThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODThreshold, __InBuffer);
				}
			}
		}

		public float Alpha
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Alpha, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Alpha, __InBuffer);
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

		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaBoolBlend, __ReturnBuffer);

					return *(FInputAlphaBoolBlend*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaBoolBlend, __InBuffer);
				}
			}
		}

		public FName AlphaCurveName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaCurveName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaCurveName, __InBuffer);
				}
			}
		}

		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaScaleBiasClamp, __ReturnBuffer);

					return *(FInputScaleBiasClamp*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaScaleBiasClamp, __InBuffer);
				}
			}
		}

		public EAnimAlphaInputType AlphaInputType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AlphaInputType, __ReturnBuffer);

					return *(EAnimAlphaInputType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AlphaInputType, __InBuffer);
				}
			}
		}

		public bool bAlphaBoolEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAlphaBoolEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAlphaBoolEnabled, __InBuffer);
				}
			}
		}

		private static uint __BasePose = 0;

		private static uint __LODThreshold = 0;

		private static uint __Alpha = 0;

		private static uint __AlphaScaleBias = 0;

		private static uint __AlphaBoolBlend = 0;

		private static uint __AlphaCurveName = 0;

		private static uint __AlphaScaleBiasClamp = 0;

		private static uint __AlphaInputType = 0;

		private static uint __bAlphaBoolEnabled = 0;

	}
}