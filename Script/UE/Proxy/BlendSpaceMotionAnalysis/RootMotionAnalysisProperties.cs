using Script.CoreUObject;
using Script.Engine;
using Script.Persona;
using Script.Library;

namespace Script.BlendSpaceMotionAnalysis
{
	[PathName("/Script/BlendSpaceMotionAnalysis.RootMotionAnalysisProperties")]
	public partial class URootMotionAnalysisProperties : UAnalysisProperties, IStaticClass
	{
		public EAnalysisRootMotionAxis FunctionAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionAxis, __ReturnBuffer);

					return *(EAnalysisRootMotionAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionAxis, __InBuffer);
				}
			}
		}

		public FBoneSocketTarget BoneSocket
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoneSocket, __ReturnBuffer);

					return *(FBoneSocketTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoneSocket, __InBuffer);
				}
			}
		}

		public EAnalysisSpace Space
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Space, __ReturnBuffer);

					return *(EAnalysisSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Space, __InBuffer);
				}
			}
		}

		public FBoneSocketTarget SpaceBoneSocket
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpaceBoneSocket, __ReturnBuffer);

					return *(FBoneSocketTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpaceBoneSocket, __InBuffer);
				}
			}
		}

		public EAnalysisLinearAxis CharacterFacingAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterFacingAxis, __ReturnBuffer);

					return *(EAnalysisLinearAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterFacingAxis, __InBuffer);
				}
			}
		}

		public EAnalysisLinearAxis CharacterUpAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterUpAxis, __ReturnBuffer);

					return *(EAnalysisLinearAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterUpAxis, __InBuffer);
				}
			}
		}

		public float StartTimeFraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartTimeFraction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartTimeFraction, __InBuffer);
				}
			}
		}

		public float EndTimeFraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EndTimeFraction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EndTimeFraction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlendSpaceMotionAnalysis.RootMotionAnalysisProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FunctionAxis = 0;

		private static uint __BoneSocket = 0;

		private static uint __Space = 0;

		private static uint __SpaceBoneSocket = 0;

		private static uint __CharacterFacingAxis = 0;

		private static uint __CharacterUpAxis = 0;

		private static uint __StartTimeFraction = 0;

		private static uint __EndTimeFraction = 0;
	}
}